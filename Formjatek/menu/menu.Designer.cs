namespace menu
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.button2 = new System.Windows.Forms.Button();
            this.controlbutton = new System.Windows.Forms.Button();
            this.aboutbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(458, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 55);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlbutton
            // 
            this.controlbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlbutton.BackgroundImage")));
            this.controlbutton.Location = new System.Drawing.Point(458, 90);
            this.controlbutton.Name = "controlbutton";
            this.controlbutton.Size = new System.Drawing.Size(159, 55);
            this.controlbutton.TabIndex = 2;
            this.controlbutton.UseVisualStyleBackColor = true;
            this.controlbutton.Click += new System.EventHandler(this.controlbutton_Click);
            // 
            // aboutbutton
            // 
            this.aboutbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutbutton.BackgroundImage")));
            this.aboutbutton.Location = new System.Drawing.Point(458, 151);
            this.aboutbutton.Name = "aboutbutton";
            this.aboutbutton.Size = new System.Drawing.Size(159, 62);
            this.aboutbutton.TabIndex = 3;
            this.aboutbutton.UseVisualStyleBackColor = true;
            this.aboutbutton.Click += new System.EventHandler(this.aboutbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Image = ((System.Drawing.Image)(resources.GetObject("exitbutton.Image")));
            this.exitbutton.Location = new System.Drawing.Point(458, 219);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(159, 55);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 399);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.aboutbutton);
            this.Controls.Add(this.controlbutton);
            this.Controls.Add(this.button2);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button controlbutton;
        private System.Windows.Forms.Button aboutbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}