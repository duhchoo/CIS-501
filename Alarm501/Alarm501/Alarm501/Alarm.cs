﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501
{


    public class Alarm
    {
        private DateTime _time;
        private bool _isOn = false;
        private int _snoozeTime = 0;
        private AlarmSounds _sound;

        public DateTime Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        /// <summary>
        /// Property of whether the Alarm is on or not.
        /// </summary>
        public bool IsOn
        {
            get
            {
                return _isOn;
            }

            set
            {
                _isOn = value;
            }
        }
        
        public int SnoozeTime
        {
            get
            {
                return _snoozeTime;
            }
            set
            {
                _snoozeTime = value;
            }
        }

        public AlarmSounds Sound
        {
            get
            {
                return _sound;
            }
            set
            {
                _sound = value;
            }
        }

        public override string ToString()
        {
            string bingo = "OFF";
            if (_isOn) {
                bingo = "ON";
            }
            return "   " + _time.ToString("hh") + ":" + _time.ToString("mm") + " " + _time.ToString("tt") + "    " + bingo + " (" + Sound.ToString() + ")";
        }

    }
}
