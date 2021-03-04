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
    public partial class EditForm : Form
    {

        public Alarm _alarm = new Alarm();

        public EditForm(object alarm2Edit)
        {
            InitializeComponent();
            if (alarm2Edit is Alarm tempAlarm)
            {
                _alarm = tempAlarm;
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            uxDateTimePicker.Value = _alarm.Time;

        }

        private void uxEdit_Click(object sender, EventArgs e)
        {
            
            _alarm.Time = uxDateTimePicker.Value;
            _alarm.IsOn = uxOnBox.Checked;

            switch (uxSoundPicker.SelectedItem)
            {
                case "Radar":
                    _alarm.Sound = AlarmSounds.Radar;
                    break;
                case "Beacon":
                    _alarm.Sound = AlarmSounds.Beacon;
                    break;
                case "Chimes":
                    _alarm.Sound = AlarmSounds.Chimes;
                    break;
                case "Circuit":
                    _alarm.Sound = AlarmSounds.Circuit;
                    break;
                case "Reflection":
                    _alarm.Sound = AlarmSounds.Reflection;
                    break;
                case "- Choose -":
                    _alarm.Sound = AlarmSounds.Radar;
                    break;
            }

            _alarm.SnoozeTime = Convert.ToInt32(uxSnoozePicker.Value);

            this.Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
