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
    public partial class _3x3Game : Form
    {
        private double _tick = 0;
        public _3x3Game()
        {
            InitializeComponent();
            timer1.Start();
			this.BackgroundImage = Properties.Resources.background_image;
            this.BackgroundImageLayout = ImageLayout.Stretch; //Fit the image to the window app
        }
        protected int moveNumber = 0, TotalScore = 10000;
        private void ShuffleB()
        {
            List<int> labelList = new List<int>();

            Random rad = new Random();
            bool flag = true;
            int labelIndex;
            while (flag)
            {
                //initialize number into List
                for (int i = 0; i < 9; i++)
                {
                    do{ labelIndex = rad.Next(9); 
                    }while (labelList.Contains(labelIndex)); //Check the repeated number
                    labelList.Add(labelIndex); //add number if it is not repeated
                }
                //If solvable then flag become false and exit the while Loop.
                if (SolveMethod.isSolvable(labelList)) { flag = false; } //Check
                else { labelList.Clear(); } //Fail then clear the List
            }
            int index1 = 0;
            foreach (Button btn in this.panel1.Controls)
            {
                btn.Text = (labelList[index1] == 0) ? "" : labelList[index1].ToString(); //if the number is 0 then make it empty
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight); //if the button is empty then color it white
                index1++;
            }
            moveNumber = 0;
            NoOfMovements.Text = "Move#: " + moveNumber;
        }
        private void SwapNumber(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "") { return; }
            Button whiteBtn = null;
            foreach (Button bt in this.panel1.Controls)
            {
                if(bt.Text == "")
                {
                    whiteBtn = bt;
                    break;
                }
            }
            if ((btn.TabIndex == 6 || btn.TabIndex == 3) && btn.TabIndex == (whiteBtn.TabIndex + 1))
            {

            }
            else if ((btn.TabIndex == 5 || btn.TabIndex == 2) && btn.TabIndex == (whiteBtn.TabIndex-1))
            {

            }
            else if (btn.TabIndex == (whiteBtn.TabIndex -1) ||
                btn.TabIndex == (whiteBtn.TabIndex - 3) ||
                btn.TabIndex == (whiteBtn.TabIndex + 3) ||
                btn.TabIndex == (whiteBtn.TabIndex + 1) )
            {
                 whiteBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                 btn.BackColor = Color.White;
                 whiteBtn.Text = btn.Text;
                 btn.Text = "";
                 moveNumber++;
                 NoOfMovements.Text = "Move#: " + moveNumber;
            }
            CheckWin();
        }

        private void CheckWin()
        {
            int index = 8;
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

        private void NewGame_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //stop the current time count
            timer1.Start(); // restart the new time count
            moveNumber = 0;
            ShuffleB();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //Stop the timer when exit the time and Go to Menu
            this.Hide();
            Form1 f = new Form1();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick++;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _3x3Game_Load(object sender, EventArgs e)
        {
            ShuffleB();
        }
    }
}
