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

        public Alarm newAlarm = null;


        public AddForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

            this.Close();
        }
    }
}
