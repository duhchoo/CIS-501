using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Alarm501
{
    public enum AlarmSounds
    {
        Radar,
        Beacon,
        Chimes,
        Circuit,
        Reflection
    }

    public partial class Form1 : Form
    {
        // Setting up Timer
        System.Timers.Timer timer;

        // Used for the Stop and Snooze Buttons.
        int targetAlarmIndex = 0;

        public Form1()
        {
            InitializeComponent();

            //if (File.Exists("..\\..\\AlarmData.txt"))
            //{
            //    StreamReader sr = new StreamReader("..\\..\\AlarmData.txt");
            //    while (!sr.EndOfStream)
            //    {
            //        string[] alarmData = sr.ReadLine().Split(',');
            //        Alarm newAlarm = new Alarm();
            //        newAlarm.Time = DateTime.Parse(alarmData[0]);

            //        if (alarmData[1] == "ON")
            //        {
            //            newAlarm.IsOn = true;
            //        }

            //        uxAlarmList.Items.Add(newAlarm);

            //    }

            //    sr.Close();
            //}


        }

        /// <summary>
        /// When the Form has been loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.SynchronizingObject = this;
            timer.AutoReset = true;
            timer.Start();
            

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.Second + " second...");

            for(int i = 0; i < uxAlarmList.Items.Count; i++)
            {
                Alarm alarm = new Alarm();
                if (uxAlarmList.Items[i] is Alarm x)
                {
                    alarm = x;
                }


                Console.WriteLine("we're in");
                if (currentTime.Hour == alarm.Time.Hour && currentTime.Minute == alarm.Time.Minute && currentTime.Second == alarm.Time.Second && alarm.IsOn && currentTime.ToString("tt") == alarm.Time.ToString("tt")) 
                {

                    uxAlarmStatus.Text = "Beep Beep Beep"; 
                    targetAlarmIndex = i;
                    uxStop.Enabled = true;
                    uxSnooze.Enabled = true;
                }
            }
        }

        /// <summary>
        /// When the Edit Button has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(uxAlarmList.SelectedItem);
            var dialogResult = editForm.ShowDialog();
            for (int i = 0; i < uxAlarmList.Items.Count; i++)
            {
                if (uxAlarmList.Items[i] == uxAlarmList.SelectedItem)
                {
                    uxAlarmList.Items[i] = editForm._alarm;
                }
            }

        }

        /// <summary>
        /// When the Add Button has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            var dialogResult = addForm.ShowDialog();
            if (addForm.newAlarm != null && uxAlarmList.Items.Count <= 5)
            {
                uxAlarmList.Items.Add(addForm.newAlarm);

                string stat = "OFF";
                if (addForm.newAlarm.IsOn) { stat = "ON"; }
                Console.WriteLine(addForm.newAlarm.Time.ToString() + " " + stat + " (" + addForm.newAlarm.Sound.ToString() + ")");

            }
            if (uxAlarmList.Items.Count == 5)
            {
                uxAdd.Enabled = false;
            }


        }
        
        /// <summary>
        /// When the Snooze Button has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSnooze_Click(object sender, EventArgs e)
        {
            Alarm oldAlarm = new Alarm();
            if (uxAlarmList.Items[targetAlarmIndex] is Alarm x)
            {
                oldAlarm = x;
            }

            Alarm tempAlarm = new Alarm();
            tempAlarm.Time = DateTime.Now.AddMinutes(oldAlarm.SnoozeTime);
            tempAlarm.IsOn = oldAlarm.IsOn;
            uxAlarmList.Items[targetAlarmIndex] = tempAlarm;

            uxAlarmStatus.Text = "Snoozed";
            uxSnooze.Enabled = false;
            uxStop.Enabled = false;
        }

        /// <summary>
        /// When the Stop button has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStop_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm();
            if (uxAlarmList.Items[targetAlarmIndex] is Alarm x)
            {
                alarm = x;
            }
            alarm.IsOn = false;
            uxAlarmList.Items[targetAlarmIndex] = alarm;

            uxAlarmStatus.Text = "Stopped";
            uxSnooze.Enabled = false;
            uxStop.Enabled = false;
        }

        private void uxAlarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxEdit.Enabled = true;
            Alarm alarm = new Alarm();
            if (uxAlarmList.SelectedItem is Alarm tempAlarm)
            {
                alarm = tempAlarm;
            }
            if (alarm.IsOn)
            {
                uxAlarmStatus.Text = "Running";
            }
            else if (!alarm.IsOn)
            {
                uxAlarmStatus.Text = "Off";
            }
            else
            {
                uxAlarmStatus.Text = "";
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            //if (File.Exists("..\\..\\AlarmData.txt"))
            //{
            //    using (StreamWriter sw = new StreamWriter("..\\..\\AlarmData.txt"))
            //    {
            //        foreach (Alarm alarm in uxAlarmList.Items)
            //        {
            //            if (alarm.IsOn)
            //            {
            //                sw.WriteLine(alarm.Time.ToString("hh:mm:ss tt") + "," + "ON");
            //            }
            //            else
            //            {
            //                sw.WriteLine(alarm.Time.ToString("hh:mm:ss tt") + "," + "OFF");
            //            }
                        
            //        }
            //    }
            //}
            //else
            //{
            //    using (StreamWriter sw = File.CreateText("..\\..\\AlarmData.txt"))
            //    {
            //        foreach (Alarm alarm in uxAlarmList.Items)
            //        {
            //            if (alarm.IsOn)
            //            {
            //                sw.WriteLine(alarm.Time.ToString("hh:mm:ss tt") + "," + "ON");
            //            }
            //            else
            //            {
            //                sw.WriteLine(alarm.Time.ToString("hh:mm:ss tt") + "," + "OFF");
            //            }

            //        }
            //    }
            //}
        }
    }
}
