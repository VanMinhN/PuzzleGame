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
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
			this.BackgroundImage = Properties.Resources.background_image;
            this.BackgroundImageLayout = ImageLayout.Stretch; //Fit the image to the window app
        }

        private void EasyMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            _3x3Game game = new _3x3Game();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void NormalMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            _4x4Game game = new _4x4Game();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void HardModeB_Click(object sender, EventArgs e)
        {
            this.Hide();
            _5x5Game game = new _5x5Game();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }
    }
}
