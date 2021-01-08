namespace WindowsFormsApp1
{
    partial class Mode
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
            this.EasyMode = new System.Windows.Forms.Button();
            this.NormalMode = new System.Windows.Forms.Button();
            this.HardModeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EasyMode
            // 
            this.EasyMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyMode.Location = new System.Drawing.Point(310, 40);
            this.EasyMode.Name = "EasyMode";
            this.EasyMode.Size = new System.Drawing.Size(145, 79);
            this.EasyMode.TabIndex = 0;
            this.EasyMode.Text = "Easy";
            this.EasyMode.UseVisualStyleBackColor = true;
            this.EasyMode.Click += new System.EventHandler(this.EasyMode_Click);
            // 
            // NormalMode
            // 
            this.NormalMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalMode.Location = new System.Drawing.Point(310, 156);
            this.NormalMode.Name = "NormalMode";
            this.NormalMode.Size = new System.Drawing.Size(145, 75);
            this.NormalMode.TabIndex = 1;
            this.NormalMode.Text = "Normal";
            this.NormalMode.UseVisualStyleBackColor = true;
            this.NormalMode.Click += new System.EventHandler(this.NormalMode_Click);
            // 
            // HardModeB
            // 
            this.HardModeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HardModeB.Location = new System.Drawing.Point(310, 271);
            this.HardModeB.Name = "HardModeB";
            this.HardModeB.Size = new System.Drawing.Size(145, 65);
            this.HardModeB.TabIndex = 2;
            this.HardModeB.Text = "Hard";
            this.HardModeB.UseVisualStyleBackColor = true;
            this.HardModeB.Click += new System.EventHandler(this.HardModeB_Click);
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HardModeB);
            this.Controls.Add(this.NormalMode);
            this.Controls.Add(this.EasyMode);
            this.Name = "Mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EasyMode;
        private System.Windows.Forms.Button NormalMode;
        private System.Windows.Forms.Button HardModeB;
    }
}