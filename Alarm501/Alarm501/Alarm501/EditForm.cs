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

        public Alarm _alarm;

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

            this.Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
