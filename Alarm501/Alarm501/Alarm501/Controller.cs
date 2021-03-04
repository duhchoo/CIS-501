using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501
{
    public enum State
    {
        Start,
        Run,
        Buzz,
        Add,
        Edit,
        Snooze,
        Stop
    }

    public class Controller
    {
        ControlReference controlRef = null;

        private Form1 view;
        
        public Controller(Form1 view)
        {
            this.view = view;
            controlRef = view.ControllerSet;
            controlRef(this);
        }

        public void handle(State state, Alarm alarm)
        {
            switch (state)
            {
                case State.Start:
                    view.DisplayState(State.Start, alarm);
                    break;

                case State.Run:
                    view.DisplayState(State.Run, alarm);
                    break;

                case State.Buzz:
                    view.DisplayState(State.Buzz, alarm);
                    break;

                case State.Add:
                    view.DisplayState(State.Add, alarm);
                    break;

                case State.Edit:
                    view.DisplayState(State.Edit, alarm);
                    break;

                case State.Snooze:
                    view.DisplayState(State.Snooze, alarm);
                    break;

                case State.Stop:
                    view.DisplayState(State.Stop, alarm);
                    break;

                default:
                    break;
            }
        }

    }
}
