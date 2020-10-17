namespace Drawing_App
{
    partial class frmDrawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrawing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbSilver = new System.Windows.Forms.PictureBox();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.pbPink = new System.Windows.Forms.PictureBox();
            this.pbPurpleDark = new System.Windows.Forms.PictureBox();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbBlueDark = new System.Windows.Forms.PictureBox();
            this.pbYellow = new System.Windows.Forms.PictureBox();
            this.pbYellowDark = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbGreenDark = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbMaroon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurpleDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellowDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaroon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pbSilver);
            this.panel2.Controls.Add(this.pbBlack);
            this.panel2.Controls.Add(this.pbPink);
            this.panel2.Controls.Add(this.pbPurpleDark);
            this.panel2.Controls.Add(this.pbBlue);
            this.panel2.Controls.Add(this.pbBlueDark);
            this.panel2.Controls.Add(this.pbYellow);
            this.panel2.Controls.Add(this.pbYellowDark);
            this.panel2.Controls.Add(this.pbGreen);
            this.panel2.Controls.Add(this.pbGreenDark);
            this.panel2.Controls.Add(this.pbRed);
            this.panel2.Controls.Add(this.pbMaroon);
            this.panel2.Location = new System.Drawing.Point(597, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 65);
            this.panel2.TabIndex = 0;
            // 
            // pbSilver
            // 
            this.pbSilver.BackColor = System.Drawing.Color.Silver;
            this.pbSilver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSilver.Location = new System.Drawing.Point(161, 34);
            this.pbSilver.Name = "pbSilver";
            this.pbSilver.Size = new System.Drawing.Size(25, 23);
            this.pbSilver.TabIndex = 12;
            this.pbSilver.TabStop = false;
            this.pbSilver.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbBlack
            // 
            this.pbBlack.BackColor = System.Drawing.Color.Black;
            this.pbBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBlack.Location = new System.Drawing.Point(130, 34);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(25, 23);
            this.pbBlack.TabIndex = 11;
            this.pbBlack.TabStop = false;
            this.pbBlack.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbPink
            // 
            this.pbPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbPink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPink.Location = new System.Drawing.Point(37, 34);
            this.pbPink.Name = "pbPink";
            this.pbPink.Size = new System.Drawing.Size(25, 23);
            this.pbPink.TabIndex = 10;
            this.pbPink.TabStop = false;
            this.pbPink.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbPurpleDark
            // 
            this.pbPurpleDark.BackColor = System.Drawing.Color.Purple;
            this.pbPurpleDark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPurpleDark.Location = new System.Drawing.Point(6, 34);
            this.pbPurpleDark.Name = "pbPurpleDark";
            this.pbPurpleDark.Size = new System.Drawing.Size(25, 23);
            this.pbPurpleDark.TabIndex = 9;
            this.pbPurpleDark.TabStop = false;
            this.pbPurpleDark.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbBlue
            // 
            this.pbBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBlue.Location = new System.Drawing.Point(99, 34);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(25, 23);
            this.pbBlue.TabIndex = 8;
            this.pbBlue.TabStop = false;
            this.pbBlue.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbBlueDark
            // 
            this.pbBlueDark.BackColor = System.Drawing.Color.Navy;
            this.pbBlueDark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBlueDark.Location = new System.Drawing.Point(68, 34);
            this.pbBlueDark.Name = "pbBlueDark";
            this.pbBlueDark.Size = new System.Drawing.Size(25, 23);
            this.pbBlueDark.TabIndex = 7;
            this.pbBlueDark.TabStop = false;
            this.pbBlueDark.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbYellow
            // 
            this.pbYellow.BackColor = System.Drawing.Color.Yellow;
            this.pbYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbYellow.Location = new System.Drawing.Point(161, 5);
            this.pbYellow.Name = "pbYellow";
            this.pbYellow.Size = new System.Drawing.Size(25, 23);
            this.pbYellow.TabIndex = 6;
            this.pbYellow.TabStop = false;
            this.pbYellow.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbYellowDark
            // 
            this.pbYellowDark.BackColor = System.Drawing.Color.Gold;
            this.pbYellowDark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbYellowDark.Location = new System.Drawing.Point(130, 5);
            this.pbYellowDark.Name = "pbYellowDark";
            this.pbYellowDark.Size = new System.Drawing.Size(25, 23);
            this.pbYellowDark.TabIndex = 5;
            this.pbYellowDark.TabStop = false;
            this.pbYellowDark.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbGreen
            // 
            this.pbGreen.BackColor = System.Drawing.Color.Lime;
            this.pbGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGreen.Location = new System.Drawing.Point(99, 5);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(25, 23);
            this.pbGreen.TabIndex = 4;
            this.pbGreen.TabStop = false;
            this.pbGreen.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbGreenDark
            // 
            this.pbGreenDark.BackColor = System.Drawing.Color.Green;
            this.pbGreenDark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGreenDark.Location = new System.Drawing.Point(68, 5);
            this.pbGreenDark.Name = "pbGreenDark";
            this.pbGreenDark.Size = new System.Drawing.Size(25, 23);
            this.pbGreenDark.TabIndex = 3;
            this.pbGreenDark.TabStop = false;
            this.pbGreenDark.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbRed
            // 
            this.pbRed.BackColor = System.Drawing.Color.Red;
            this.pbRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbRed.Location = new System.Drawing.Point(37, 5);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(25, 23);
            this.pbRed.TabIndex = 2;
            this.pbRed.TabStop = false;
            this.pbRed.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // pbMaroon
            // 
            this.pbMaroon.BackColor = System.Drawing.Color.Maroon;
            this.pbMaroon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMaroon.Location = new System.Drawing.Point(6, 5);
            this.pbMaroon.Name = "pbMaroon";
            this.pbMaroon.Size = new System.Drawing.Size(25, 23);
            this.pbMaroon.TabIndex = 1;
            this.pbMaroon.TabStop = false;
            this.pbMaroon.Click += new System.EventHandler(this.pbSilver_Click);
            // 
            // frmDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing App";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurpleDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellowDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaroon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbGreenDark;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbMaroon;
        private System.Windows.Forms.PictureBox pbSilver;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.PictureBox pbPink;
        private System.Windows.Forms.PictureBox pbPurpleDark;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbBlueDark;
        private System.Windows.Forms.PictureBox pbYellow;
        private System.Windows.Forms.PictureBox pbYellowDark;
    }
}

