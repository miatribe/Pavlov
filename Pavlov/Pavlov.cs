using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Security.Principal;
using System.Windows.Forms;

namespace Pavlov
{
    public partial class Pavlov : Form
    {
        private MemRead memRead;
        private DateTime dt;
        private int foodPrev = -1;
        private int changeRate = -1;
        private bool alarmPlayed = false;
        private MenuItem alarmToggle;
        private MenuItem trackingToggle;
        private bool repeatAlarm;
        private SoundPlayer player;
        //if false = trackingHomon
        private bool trackingPet;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [STAThread]
        static void Main()
        {
            try
            {
                if ((new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
                {
                    Application.Run(new Pavlov());
                }
                else
                {
                    MessageBox.Show("Pavlov must be ran as Administrator.", "Privilege Error");
                    Application.Exit();
                }
            }
            catch
            {
                Application.Exit();
            }
        }

        public Pavlov()
        {
            InitializeComponent();
            repeatAlarm = GetAlarmRepeatBool();
            trackingPet = GetTrackingBool();
            CreateContextMenu();
            StartPosition = FormStartPosition.Manual;
            SetWindowPos();
            BackColor = Color.Pink;
            TransparencyKey = Color.Pink;
            try
            {
                player = new SoundPlayer(@"feedme.wav");
            }
            catch
            {
                player = null;
            }
            memRead = new MemRead();
            memRead.GetProcess();
            var Timer = new Timer()
            {
                Interval = (500)
            };
            Timer.Tick += new EventHandler(UpdateWindow);
            Timer.Start();
        }

        private void CreateContextMenu()
        {
            var notifyIcon = new NotifyIcon(components = new Container())
            {
                Icon = Properties.Resources.icon,
                ContextMenu = new ContextMenu(new[]
                {
                    new MenuItem("Reset Window Position", ResetWindowPos),
                    alarmToggle = new MenuItem($"Toggle Alarm Type (Current:{(GetAlarmRepeatBool()? "Repeat" : "Single")})", ToggleAlarmType),
                    trackingToggle = new MenuItem($"Toggle Tracking Type (Current:{(GetTrackingBool()? "Pet" : "Homunculus")})", ToggleTackingType),
                    new MenuItem("-"),
                    new MenuItem("Exit Pavlov", ExitBtn_Click)
                }),
                Text = "Pavlov",
                Visible = true
            };
        }

        private void ToggleAlarmType(object sender, EventArgs e)
        {
            repeatAlarm = !repeatAlarm;
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    key?.SetValue("alarmRepeat", repeatAlarm);
                }
                catch {/* If we cant write to the registry do nothing*/}
            }
            alarmToggle.Text = $"Toggle Alarm Type (Current:{(repeatAlarm ? "Repeat" : "Single")})";
        }

        private bool GetAlarmRepeatBool()
        {
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    return Convert.ToBoolean(key?.GetValue("alarmRepeat"));
                }
                catch { return true; }
            }
        }

        private void ToggleTackingType(object sender, EventArgs e)
        {
            trackingPet = !trackingPet;
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    key?.SetValue("trackPet", trackingPet);
                }
                catch {/* If we cant write to the registry do nothing*/}
            }
            trackingToggle.Text = $"Toggle Tracking Type (Current:{(GetTrackingBool() ? "Pet" : "Homunculus")})";
        }

        private bool GetTrackingBool()
        {
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    return Convert.ToBoolean(key?.GetValue("trackPet"));
                }
                catch { return true; }
            }
        }

        private void SetWindowPos()
        {
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    Location = new Point((int)key?.GetValue("winX"), (int)key?.GetValue("winY"));
                }
                catch (Exception)
                {
                    Location = new Point(10, 10);
                }
            }
        }

        private void ResetWindowPos(object sender, EventArgs e)
        {
            SaveWindowPos(10, 10);
            SetWindowPos();
        }

        private void SaveWindowPos(int winX, int winY)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    key?.SetValue("winX", winX);
                    key?.SetValue("winY", winY);
                }
                catch {/* If we cant write to the registry do nothing*/}
            }
        }

        private void UpdateWindow(object sender, EventArgs e)
        {
            var gi = trackingPet ? memRead.GetPetValues() : memRead.GetHomonValues();
            if (gi != null)
            {
                if (gi.Id != uint.MaxValue && gi.Id != 0)
                {
                    hungerLabel.Text = $"Hunger:{GetHungerString(gi.Food)} ({gi.Food}/100)";
                    intimacyLabel.Text = $"Intimacy:{GetIntimacyString(gi.Intimacy)} ({gi.Intimacy}/1000)";
                    NameLabel.Text = $"{gi.CharName} : {gi.Name}";
                    bestFeedLabel.Text = GetEstimatedTimeTillHungry(gi.Food);
                }
                else
                {
                    var petHomonText = trackingPet ? "Pet" : "Homunculus";
                    hungerLabel.Text = string.Empty;
                    intimacyLabel.Text = string.Empty;
                    bestFeedLabel.Text = string.Empty;
                    changeRate = -1;
                    foodPrev = -1;
                    NameLabel.Text = gi.CharName != "" ? $"{gi.CharName} : No {petHomonText}." : $"Unknown : No {petHomonText}.";
                    if (alarmPlayed) StopAlarm();
                }
            }
            else
            {
                hungerLabel.Text = string.Empty;
                intimacyLabel.Text = string.Empty;
                bestFeedLabel.Text = string.Empty;
                StopAlarm();
                NameLabel.Text = "Unable to find data.";
            }
        }

        private string GetEstimatedTimeTillHungry(int food)
        {
            if (foodPrev == -1) foodPrev = food;
            var change = foodPrev - food;
            if (food > 0 && changeRate == -1 && foodPrev > food) changeRate = change;
            foodPrev = food;
            if (food <= 25)
            {
                if (!alarmPlayed) PlayAlarm();
                return "Feed me!";
            }
            if (alarmPlayed) StopAlarm();
            if (changeRate != -1)
            {
                if (change != 0)
                {
                    var x = (int)Math.Ceiling((food - 25m) / changeRate);
                    dt = DateTime.Now.AddMinutes(x);
                }
                var ts = dt - DateTime.Now;
                if (ts >= new TimeSpan()) return $"Feed in about {ts.Minutes.ToString().PadLeft(2, '0')}:{ts.Seconds.ToString().PadLeft(2, '0')}";
                return "Feed very soon.";

            }
            return "Calculating...";
        }

        private void StopAlarm()
        {
            alarmPlayed = false;
            if (player != null && repeatAlarm)
            {
                player.Stop();
            }
        }

        private void PlayAlarm()
        {
            alarmPlayed = true;
            if (player != null)
            {
                if (repeatAlarm)
                {
                    player.PlayLooping();
                }
                else
                {
                    player.Play();
                }
            }
        }

        private string GetHungerString(int food)
        {
            if (food >= 91) return "Stuffed";
            if (food >= 76) return "Satisfied";
            if (food >= 26) return "Neutral";
            if (food >= 11) return "Hungry";
            return "Very Hungry";
        }

        private string GetIntimacyString(int intimacy)
        {
            if (intimacy > 910) return "Loyal";
            if (intimacy > 750) return "Cordial";
            if (intimacy > 250) return "Neutral";
            if (intimacy > 100) return "Shy";
            return "Awkward";
        }

        #region form controls
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NextClientBtn_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            changeRate = -1;
            foodPrev = -1;
            if (alarmPlayed) StopAlarm();
            memRead.GetProcess();
        }
        private void Pavlov_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowPos(Location.X, Location.Y);
        }
        #endregion


    }
}
