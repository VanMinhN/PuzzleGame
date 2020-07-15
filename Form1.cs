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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			
            this.BackgroundImage = Properties.Resources.background_image;
            this.BackgroundImageLayout = ImageLayout.Stretch; //Fit the image to the window app
         
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //START BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the current Form
            //Createt a new Form by create an instance of Mode
            Mode mode = new Mode();
            mode.Closed += (s, args) => this.Close();
            mode.Show(); //Show the new Form
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult IExit = MessageBox.Show("Confirm if you want to exit","Puzzle game",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (IExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //EXIT BUTTON
        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult IExit = MessageBox.Show("Confirm if you want to exit", "Puzzle game", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (IExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String myTxt = "Hello, Welcome to Puzzle Game. I will tell you a couple rules\n\n" +
                "You need to use the empty box to move and swap the number by using the mouse and click the number that you want to swap with the empty box.\n"
                + "The direction of the empty box is only allow to move up, down, left, and right. You can't move diagonal.\n\n"
                + "The Winning condition: All the number must be arranged in ascending order.";
            MessageBox.Show(myTxt);
        }
    }
}
