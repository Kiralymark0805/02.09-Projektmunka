namespace menu
{
    partial class wingame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wingame));
            this.getbacktolobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getbacktolobby
            // 
            this.getbacktolobby.Location = new System.Drawing.Point(175, 319);
            this.getbacktolobby.Name = "getbacktolobby";
            this.getbacktolobby.Size = new System.Drawing.Size(140, 72);
            this.getbacktolobby.TabIndex = 0;
            this.getbacktolobby.Text = "Get back to menu";
            this.getbacktolobby.UseVisualStyleBackColor = true;
            // 
            // wingame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.getbacktolobby);
            this.Name = "wingame";
            this.Text = "wingame";
            this.Load += new System.EventHandler(this.wingame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getbacktolobby;
    }
}