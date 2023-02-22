namespace character_control
{
    partial class Form1
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
            this.playertimer = new System.Windows.Forms.Timer(this.components);
            this.keytext = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.house = new System.Windows.Forms.GroupBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.wintext = new System.Windows.Forms.Label();
            this.deathpicture = new System.Windows.Forms.PictureBox();
            this.timetext = new System.Windows.Forms.Label();
            this.deathtimer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.house.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playertimer
            // 
            this.playertimer.Enabled = true;
            this.playertimer.Interval = 20;
            this.playertimer.Tick += new System.EventHandler(this.movetimerevent);
            // 
            // keytext
            // 
            this.keytext.AutoSize = true;
            this.keytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keytext.Location = new System.Drawing.Point(64, 55);
            this.keytext.Name = "keytext";
            this.keytext.Size = new System.Drawing.Size(81, 29);
            this.keytext.TabIndex = 1;
            this.keytext.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 758);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Location = new System.Drawing.Point(1, 246);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 22);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(237, 201);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(31, 28);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(245, 201);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 22);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(284, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 94);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(284, 175);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 151);
            this.panel5.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel9.Location = new System.Drawing.Point(1, 478);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(91, 22);
            this.panel9.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(284, 420);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(24, 341);
            this.panel6.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(0, 738);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1293, 22);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel8.Location = new System.Drawing.Point(1003, 478);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(24, 283);
            this.panel8.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(923, 478);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(172, 22);
            this.panel10.TabIndex = 13;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel11.Location = new System.Drawing.Point(1269, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(24, 762);
            this.panel11.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel12.Location = new System.Drawing.Point(1201, 478);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(92, 22);
            this.panel12.TabIndex = 14;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel13.Location = new System.Drawing.Point(1003, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(291, 22);
            this.panel13.TabIndex = 15;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel14.Location = new System.Drawing.Point(1003, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(24, 279);
            this.panel14.TabIndex = 16;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel15.Location = new System.Drawing.Point(284, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(743, 22);
            this.panel15.TabIndex = 17;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel16.Location = new System.Drawing.Point(648, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(24, 279);
            this.panel16.TabIndex = 18;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel17.Location = new System.Drawing.Point(381, 257);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(393, 22);
            this.panel17.TabIndex = 19;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel18.Location = new System.Drawing.Point(893, 257);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(133, 22);
            this.panel18.TabIndex = 20;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel19.Location = new System.Drawing.Point(697, 481);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(24, 279);
            this.panel19.TabIndex = 21;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel20.Location = new System.Drawing.Point(697, 478);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(133, 22);
            this.panel20.TabIndex = 22;
            // 
            // house
            // 
            this.house.Controls.Add(this.player);
            this.house.Controls.Add(this.panel21);
            this.house.Controls.Add(this.panel20);
            this.house.Controls.Add(this.panel19);
            this.house.Controls.Add(this.panel18);
            this.house.Controls.Add(this.panel17);
            this.house.Controls.Add(this.panel16);
            this.house.Controls.Add(this.panel15);
            this.house.Controls.Add(this.panel14);
            this.house.Controls.Add(this.panel13);
            this.house.Controls.Add(this.panel12);
            this.house.Controls.Add(this.panel11);
            this.house.Controls.Add(this.panel10);
            this.house.Controls.Add(this.panel8);
            this.house.Controls.Add(this.panel7);
            this.house.Controls.Add(this.panel6);
            this.house.Controls.Add(this.panel9);
            this.house.Controls.Add(this.panel5);
            this.house.Controls.Add(this.panel4);
            this.house.Controls.Add(this.panel2);
            this.house.Controls.Add(this.panel1);
            this.house.Controls.Add(this.panel3);
            this.house.Location = new System.Drawing.Point(169, 55);
            this.house.Margin = new System.Windows.Forms.Padding(4);
            this.house.Name = "house";
            this.house.Padding = new System.Windows.Forms.Padding(4);
            this.house.Size = new System.Drawing.Size(1296, 762);
            this.house.TabIndex = 23;
            this.house.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.player.Location = new System.Drawing.Point(471, 478);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(67, 62);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel21.Location = new System.Drawing.Point(217, 478);
            this.panel21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(91, 22);
            this.panel21.TabIndex = 23;
            // 
            // wintext
            // 
            this.wintext.AutoSize = true;
            this.wintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wintext.Location = new System.Drawing.Point(64, 138);
            this.wintext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wintext.Name = "wintext";
            this.wintext.Size = new System.Drawing.Size(0, 29);
            this.wintext.TabIndex = 24;
            // 
            // deathpicture
            // 
            this.deathpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deathpicture.Enabled = false;
            this.deathpicture.Location = new System.Drawing.Point(0, -2);
            this.deathpicture.Name = "deathpicture";
            this.deathpicture.Size = new System.Drawing.Size(1802, 902);
            this.deathpicture.TabIndex = 25;
            this.deathpicture.TabStop = false;
            this.deathpicture.Visible = false;
            // 
            // timetext
            // 
            this.timetext.AutoSize = true;
            this.timetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timetext.Location = new System.Drawing.Point(64, 138);
            this.timetext.Name = "timetext";
            this.timetext.Size = new System.Drawing.Size(81, 29);
            this.timetext.TabIndex = 26;
            this.timetext.Text = "label1";
            // 
            // deathtimer
            // 
            this.deathtimer.Interval = 1000;
            this.deathtimer.Tick += new System.EventHandler(this.deathtimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 900);
            this.Controls.Add(this.timetext);
            this.Controls.Add(this.wintext);
            this.Controls.Add(this.keytext);
            this.Controls.Add(this.house);
            this.Controls.Add(this.deathpicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1800, 900);
            this.MinimumSize = new System.Drawing.Size(1800, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydownpress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyuppress);
            this.panel2.ResumeLayout(false);
            this.house.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer playertimer;
        private System.Windows.Forms.Label keytext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox house;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label wintext;
        private System.Windows.Forms.PictureBox deathpicture;
        private System.Windows.Forms.Label timetext;
        private System.Windows.Forms.Timer deathtimer;
    }
}

