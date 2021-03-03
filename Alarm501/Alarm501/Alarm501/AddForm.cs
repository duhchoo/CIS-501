using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class AddForm : Form
    {
        public DateTime newTime;
        public int newSnooze;

        public Alarm newAlarm = null;


        public AddForm()
        {
            InitializeComponent();
        }

        private void uxDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            newTime = uxDateTimePicker.Value;

        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxSet_Click(object sender, EventArgs e)
        {
            newAlarm = new Alarm();
            newAlarm.Time = newTime;
            newAlarm.IsOn = uxOnBox.Checked;

            switch (uxSoundPicker.SelectedItem)
            {
                case "Radar":
                    newAlarm.Sound = AlarmSounds.Radar;
                    break;
                case "Beacon":
                    newAlarm.Sound = AlarmSounds.Beacon;
                    break;
                case "Chimes":
                    newAlarm.Sound = AlarmSounds.Chimes;
                    break;
                case "Circuit":
                    newAlarm.Sound = AlarmSounds.Circuit;
                    break;
                case "Reflection":
                    newAlarm.Sound = AlarmSounds.Reflection;
                    break;
                case "- Choose -":
                    newAlarm.Sound = AlarmSounds.Radar;
                    break;
            }

            newAlarm.SnoozeTime = Convert.ToInt32(uxSnoozePicker.Value);

            this.Close();
        }

    }
}
