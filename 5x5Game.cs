using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class _5x5Game : Form
    {
        private double _tick = 0;
        public _5x5Game()
        {
            InitializeComponent();
            timer1.Start();
            this.BackgroundImage = Properties.Resources.background_image;
            this.BackgroundImageLayout = ImageLayout.Stretch; //Fit the image to the window app
        }
        private int moveNumber = 0, TotalScore = 10000;
        //ShuffleNutton newGame
        private void ShuffleB()
        {
            List<int> labelList = new List<int>();
            Random rad = new Random();
            bool flag = true;
            int number;
            while (flag)
            {
                for (int i = 0; i < 25; i++)
                {
                    do { number = rad.Next(25); } while (labelList.Contains(number));
                    labelList.Add(number);
                }
                if (SolveMethod.isSolvable(labelList)) { flag = false; }
                else { labelList.Clear(); }
            }
            int index = 0;
            foreach (Button btn in this.panel1.Controls)
            {
                btn.Text = (labelList[index] == 0) ? "" : labelList[index] + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight); //if the button is empty then color it white
                index++;
            }

            moveNumber = 0;
            label1.Text = "Move#: " + moveNumber;
        }
        private void SwapNumber(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "") { return; }
            Button whiteBtn = null;
            foreach (Button bt in this.panel1.Controls)
            {
                if (bt.Text == "")
                {
                    whiteBtn = bt;
                    break;
                }
            }
            if ((btn.TabIndex == 5 || btn.TabIndex == 10 || btn.TabIndex == 15 || btn.TabIndex==20) && btn.TabIndex == (whiteBtn.TabIndex + 1))
            {

            }
            else if ((btn.TabIndex == 4 || btn.TabIndex == 9 || btn.TabIndex == 14 ||btn.TabIndex==19) && btn.TabIndex == (whiteBtn.TabIndex - 1))
            {

            }
            else if (btn.TabIndex == (whiteBtn.TabIndex - 1) ||
                btn.TabIndex == (whiteBtn.TabIndex - 5) ||
                btn.TabIndex == (whiteBtn.TabIndex + 5) ||
                btn.TabIndex == (whiteBtn.TabIndex + 1))
            {
                whiteBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                whiteBtn.Text = btn.Text;
                btn.Text = "";
                moveNumber++;
                label1.Text = "Move#: " + moveNumber;
            }
            CheckWin();
        }

        private void CheckWin()
        {
            int index = 24;
            foreach (Button btn in this.panel1.Controls)
            {
                if (btn.Text != "")
                {
                    int x;
                    if (!Int32.TryParse(btn.Text, out x)) //convert String to int
                    {
                        MessageBox.Show("Invalid btn.text"); //something wrong then x = 0
                    }
                    if (x != index)
                    {
                        return;
                    }
                    index--;
                }
            }
            var time = TimeSpan.FromSeconds(_tick);
            int hours = time.Hours;
            int mins = time.Minutes;
            int ss = time.Seconds;
            string ft = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, ss); //Better format
            _tick = 0; //reset the tick
            MessageBox.Show("Well Play! You beat the game. And you did it in " + moveNumber +
                " moves." + "\n\n\t\t       Score: " + (TotalScore - (moveNumber * 25)) +
                "\n\n\t\t       TIME: " + ft);
            ShuffleB();
        }


        private void NewGameB_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //stop the current time count
            timer1.Start(); // restart the new time count
            moveNumber = 0;
            ShuffleB();
        }

        private void MenuB_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form1 f = new Form1();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick++;
        }

        private void _5x5Game_Load(object sender, EventArgs e)
        {
            ShuffleB();
        }
    }
}
