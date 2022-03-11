namespace WindowsFormsApp1
{
    partial class _3x3Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NoOfMovements = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 388);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(276, 291);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SwapNumber);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(148, 291);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SwapNumber);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 291);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SwapNumber);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(276, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SwapNumber);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(148, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SwapNumber);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SwapNumber);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SwapNumber);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SwapNumber);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SwapNumber);
            // 
            // NoOfMovements
            // 
            this.NoOfMovements.AutoSize = true;
            this.NoOfMovements.BackColor = System.Drawing.SystemColors.Control;
            this.NoOfMovements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NoOfMovements.Location = new System.Drawing.Point(440, 33);
            this.NoOfMovements.Name = "NoOfMovements";
            this.NoOfMovements.Size = new System.Drawing.Size(49, 15);
            this.NoOfMovements.TabIndex = 1;
            this.NoOfMovements.Text = "Move#: ";
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(426, 110);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(119, 43);
            this.NewGame.TabIndex = 2;
            this.NewGame.Text = "NewGame";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(426, 188);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(119, 42);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _3x3Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.NoOfMovements);
            this.Controls.Add(this.panel1);
            this.Name = "_3x3Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_3x3Game";
            this.Load += new System.EventHandler(this._3x3Game_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NoOfMovements;
        private System.Windows.Forms.Button NewGame;
        private new System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Timer timer1;
    }
}