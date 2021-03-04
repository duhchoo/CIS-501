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

        Controller controller;

        // Setting up Timer
        System.Timers.Timer timer;

        // Used for the Stop and Snooze Buttons.
        int targetAlarmIndex = 0;

        public Form1()
        {
            InitializeComponent();
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

        public void ControllerSet(Controller controller)
        {
            this.controller = controller;
            this.controller.handle(State.Start, default);
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            for(int i = 0; i < uxAlarmList.Items.Count; i++)
            {
                Alarm alarm = new Alarm();
                if (uxAlarmList.Items[i] is Alarm x)
                {
                    alarm = x;
                }

                if (currentTime.Hour == alarm.Time.Hour && currentTime.Minute == alarm.Time.Minute && currentTime.Second == alarm.Time.Second && alarm.IsOn && currentTime.ToString("tt") == alarm.Time.ToString("tt")) 
                {
                    controller.handle(State.Buzz, alarm);
                    //uxAlarmStatus.Text = "Beep Beep Beep"; 
                    targetAlarmIndex = i;
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
            editForm.ShowDialog();
            controller.handle(State.Edit, editForm._alarm);
        }

        /// <summary>
        /// When the Add Button has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            controller.handle(State.Add, addForm.newAlarm);
        }
        
        /// <summary>
        /// When the Snooze Button has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSnooze_Click(object sender, EventArgs e)
        {
            if (uxAlarmList.Items[targetAlarmIndex] is Alarm alarm)
            {
                controller.handle(State.Snooze, alarm);
            }
        }

        /// <summary>
        /// When the Stop button has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStop_Click(object sender, EventArgs e)
        {
            if (uxAlarmList.Items[targetAlarmIndex] is Alarm alarm)
            {
                controller.handle(State.Stop, alarm);
            }

        }

        public void DisplayState(State state, Alarm alarm)
        {
            switch (state)
            {
                case State.Start:
                    uxStop.Enabled = false;
                    uxSnooze.Enabled = false;
                    break;

                case State.Run:
                    if (alarm.IsOn)
                    {
                        uxAlarmStatus.Text = "Running";
                    }
                    else
                    {
                        uxAlarmStatus.Text = "Off";
                    }
                    break;

                case State.Buzz:
                    uxAlarmStatus.Text = $"{alarm.Time:hh:mm tt} ({alarm.Sound}) is going off";
                    uxSnooze.Enabled = true;
                    uxStop.Enabled = true;
                    break;

                case State.Add:
                    uxAlarmList.Items.Add(alarm);
                    uxEdit.Enabled = true;
                    if (uxAlarmList.Items.Count == 5)
                    {
                        uxAdd.Enabled = false;
                    }
                    break;

                case State.Edit:
                    uxAlarmList.Items[uxAlarmList.SelectedIndex] = alarm;
                    break;

                case State.Snooze:
                    uxAlarmStatus.Text = "Snooze";
                    alarm.Time = DateTime.Now.AddMinutes(alarm.SnoozeTime);
                    uxSnooze.Enabled = false;
                    uxStop.Enabled = false;
                    uxAlarmList.Items[targetAlarmIndex] = alarm;
                    break;

                case State.Stop:
                    uxAlarmStatus.Text = "Off";
                    alarm.IsOn = false;
                    uxSnooze.Enabled = false;
                    uxStop.Enabled = false;
                    uxAlarmList.Items[targetAlarmIndex] = alarm;
                    break;
            }
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
    }
}
