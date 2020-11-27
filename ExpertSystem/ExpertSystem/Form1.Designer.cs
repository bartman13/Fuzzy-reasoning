namespace ExpertSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rozpocznijJakoEkspertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozpocznijJakoUżytkwownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rozpocznijJakoEkspertToolStripMenuItem,
            this.rozpocznijJakoUżytkwownikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rozpocznijJakoEkspertToolStripMenuItem
            // 
            this.rozpocznijJakoEkspertToolStripMenuItem.Name = "rozpocznijJakoEkspertToolStripMenuItem";
            this.rozpocznijJakoEkspertToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.rozpocznijJakoEkspertToolStripMenuItem.Text = "Rozpocznij jako Ekspert";
            this.rozpocznijJakoEkspertToolStripMenuItem.Click += new System.EventHandler(this.rozpocznijJakoEkspertToolStripMenuItem_Click);
            // 
            // rozpocznijJakoUżytkwownikToolStripMenuItem
            // 
            this.rozpocznijJakoUżytkwownikToolStripMenuItem.Name = "rozpocznijJakoUżytkwownikToolStripMenuItem";
            this.rozpocznijJakoUżytkwownikToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.rozpocznijJakoUżytkwownikToolStripMenuItem.Text = "Rozpocznij jako użytkwownik";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 674);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rozpocznijJakoEkspertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozpocznijJakoUżytkwownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
    }
}

