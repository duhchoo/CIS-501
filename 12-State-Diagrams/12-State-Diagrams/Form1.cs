using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace State_Diagrams
{

    // Displays a view of the number-guessing game:
    public partial class Form1 : Form
    {

        GameController c;  // holds handle to the controller object (no delegates today, OK?)
        Status state;     // remembers the current state of the game
        int count = 0;

        public Form1(GameController c)
        {
            this.c = c;
            this.state = Status.Start;
            InitializeComponent();  // constructs the graphical part of the Form
            // set the label on it:
            label1.Text = "Type an int in range 0 - 10";
        }

        // handles a click of the OK button:
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            Tuple<Status, int> pair = c.handle(textBox1.Text);
            state = pair.Item1;    // remember the new state of the game
            int num = pair.Item2;  // a number computed by the controller
            // FINISH ME
            if (state == Status.Lose)
            {
                label1.Text = "You lost.";
            }
            else if (count >= 1 && count <= 2)
            {
                label1.Text = num.ToString();
                if (count == 2)
                {
                    pair = c.handle(textBox1.Text);
                    state = pair.Item1;

                    if (state == Status.Win)
                    {
                        textBox1.Text = "";
                        label1.Text = "You won!";
                        c = new GameController();
                        count = 0;
                    }
                    else
                    {
                        label1.Text = "You lost";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
