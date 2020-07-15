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
        public _3x3Game()
        {
            InitializeComponent();
			this.BackgroundImage = Properties.Resources.background_image;
            this.BackgroundImageLayout = ImageLayout.Stretch; //Fit the image to the window app
        }
        private static int getInvCount(int[,] puzzle)
        {
            int inv_count = 0;
            for (int i = 0; i < 3 - 1; i++)
                for (int j = i + 1; j < 3; j++)

                    // Value 0 is used for empty space 
                    if (puzzle[j, i] > 0 && puzzle[j, i] > puzzle[i, j])
                        inv_count++;
            return inv_count;
        }
        private static bool Solvable(int[,] puzzle)
        {
            // Count inversions in given 8 puzzle 
            int invCount = getInvCount(puzzle);

            // return true if inversion count is even. 
            return (invCount % 2 == 0);
        }
        int moveNumber = 0;
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
                int[,] puzzle = new int[3, 3];
                int index = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        puzzle[i, j] = labelList[index++]; //Convert 1 dimension array to 2 dimension array 
                    }
                }
                //If solvable then flag become false and exit the while Loop.
                if (Solvable(puzzle)) { flag = false; } //Check
                else { labelList.Clear(); } //Fail then clear the List
            }
            int index1 = 0;
            foreach (Button btn in this.panel1.Controls)
            {
                btn.Text = (labelList[index1] == 0) ? "" : labelList[index1] + ""; //if the number is 0 then make it empty
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
            
             if(button1.Text=="1" && button2.Text=="2" && button3.Text=="3"
               && button4.Text=="4" && button5.Text=="5" && button6.Text=="6"
               && button7.Text=="7" && button8.Text=="8" && button9.Text==""){
                MessageBox.Show("Well Play! You beat the game. And you did it in "+moveNumber+" moves.");
                ShuffleB();
             }       
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            ShuffleB();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void _3x3Game_Load(object sender, EventArgs e)
        {
            ShuffleB();
        }
    }
}
