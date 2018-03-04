using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Pavlov
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if (Pavlov.GetAlarmRepeatBool())
            {
                rbtnRepeat.Checked = true;
            }
            else
            {
                rbtnOnce.Checked = true;
            }
            if (Pavlov.GetTrackingBool())
            {
                rbtnPet.Checked = true;
            }
            else
            {
                rbtnHomon.Checked = true;
            }
            txtFoodLevel.Value = Pavlov.GetFoodAlarm();
        }

        private void SetTackingType(bool trackingBool)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    key?.SetValue("trackPet", trackingBool);
                }
                catch {/* If we cant write to the registry do nothing*/}
            }
        }

        private void SetAlarmType(bool alarmType)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    key?.SetValue("alarmRepeat", alarmType);
                }
                catch {/* If we cant write to the registry do nothing*/}
            }
        }

        private void SetFoodAlarm(int foodAlarm)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ByTribe\Pavlov"))
            {
                try
                {
                    key?.SetValue("foodAlarm", foodAlarm);
                }
                catch {/* If we cant write to the registry do nothing*/}
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetTackingType(rbtnPet.Checked);
            SetAlarmType(rbtnRepeat.Checked);
            SetFoodAlarm((int)txtFoodLevel.Value);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
