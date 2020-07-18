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
    public partial class _4x4Game : Form
    {
        private double _tick = 0;
        public _4x4Game()
        {
            InitializeComponent();
            timer1.Start();
			this.BackgroundImage = Properties.Resources.background_image;
            this.BackgroundImageLayout = ImageLayout.Stretch; //Fit the image to the window app
        }
        protected int moveNumber = 0, TotalScore = 10000;

        private static bool isSolvable(List<int> puzzle)
        {
            int parity = 0;
            int gridWidth = (int)Math.Sqrt(puzzle.Count);
            int row = 0; // the current row we are on
            int blankRow = 0; // the row with the blank tile

            for (int i = 0; i < puzzle.Count; i++)
            {
                if (i % gridWidth == 0)
                { // advance to next row
                    row++;
                }
                if (puzzle[i] == 0)
                { // the blank tile
                    blankRow = row; // save the row on which encountered
                    continue;
                }
                for (int j = i + 1; j < puzzle.Count; j++)
                {
                    if (puzzle[i] > puzzle[j] && puzzle[j] != 0)
                    {
                        parity++;
                    }
                }
            }

            if (gridWidth % 2 == 0)
            { // even grid
                if (blankRow % 2 == 0)
                { // blank on odd row; counting from bottom
                    return parity % 2 == 0;
                }
                else
                { // blank on even row; counting from bottom
                    return parity % 2 != 0;
                }
            }
            else
            { // odd grid
                return parity % 2 == 0;
            }
        }
        //ShuffleNutton newGame
        private void ShuffleB()
        {
            List<int> labelList = new List<int>();

            Random rad = new Random();
            bool flag = true;
            int number;
            while (flag)
            {
                for(int i= 0; i < 16; i++)
                {
                    do { number = rad.Next(16); } while (labelList.Contains(number));
                    labelList.Add(number);
                }
                if (isSolvable(labelList)){ flag = false; }
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
            NoOfMovement.Text = "Move#: " + moveNumber;
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
            if ((btn.TabIndex == 8 || btn.TabIndex == 4 || btn.TabIndex == 12) && btn.TabIndex == (whiteBtn.TabIndex + 1))
            {

            }
            else if ((btn.TabIndex == 3 || btn.TabIndex == 7 || btn.TabIndex == 11) && btn.TabIndex == (whiteBtn.TabIndex - 1))
            {

            }
            else if (btn.TabIndex == (whiteBtn.TabIndex - 1) ||
                btn.TabIndex == (whiteBtn.TabIndex - 4) ||
                btn.TabIndex == (whiteBtn.TabIndex + 4) ||
                btn.TabIndex == (whiteBtn.TabIndex + 1))
            {
                whiteBtn.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                whiteBtn.Text = btn.Text;
                btn.Text = "";
                moveNumber++;
                NoOfMovement.Text = "Move#: " + moveNumber;
            }
            CheckWin();
        }

        private void CheckWin()
        {
            /* int index = 0;
             foreach (Button btn in this.panel1.Controls)
             {
                 //Convert btn string to int to compare the number
                 if (btn.Text != "" && Convert.ToInt16(btn.Text)!=index)
                 {
                     return;
                 }
                 MessageBox.Show(btn.Text + " == " + index);
                 index++; 
             }
             MessageBox.Show("Well Play! You beat the game. And you did it in "+moveNumber+" moves.");
             ShuffleB();*/

            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3"
              && button4.Text == "4" && button5.Text == "5" && button6.Text == "6"
              && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" 
              && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" 
              && button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "")
            {
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
        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            moveNumber = 0;
            ShuffleB();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form1 f = new Form1();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void _4x4Game_Load(object sender, EventArgs e)
        {
            ShuffleB();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick++;
        }
    }
}
