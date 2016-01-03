namespace DataVizFromScratch
{
    partial class View_Map
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.mctlWB = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDelimiterSeparatedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Top.SuspendLayout();
            this.panel_Center.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.menuStrip1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(826, 40);
            this.panel_Top.TabIndex = 0;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 438);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(826, 40);
            this.panel_Bottom.TabIndex = 1;
            // 
            // panel_Left
            // 
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 40);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(40, 398);
            this.panel_Left.TabIndex = 2;
            // 
            // panel_Right
            // 
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(786, 40);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(40, 398);
            this.panel_Right.TabIndex = 3;
            // 
            // panel_Center
            // 
            this.panel_Center.Controls.Add(this.mctlWB);
            this.panel_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Center.Location = new System.Drawing.Point(40, 40);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(746, 398);
            this.panel_Center.TabIndex = 4;
            // 
            // mctlWB
            // 
            this.mctlWB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mctlWB.Location = new System.Drawing.Point(0, 0);
            this.mctlWB.MinimumSize = new System.Drawing.Size(20, 20);
            this.mctlWB.Name = "mctlWB";
            this.mctlWB.ScrollBarsEnabled = false;
            this.mctlWB.Size = new System.Drawing.Size(746, 398);
            this.mctlWB.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDelimiterSeparatedFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDelimiterSeparatedFileToolStripMenuItem
            // 
            this.openDelimiterSeparatedFileToolStripMenuItem.Name = "openDelimiterSeparatedFileToolStripMenuItem";
            this.openDelimiterSeparatedFileToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openDelimiterSeparatedFileToolStripMenuItem.Text = "Open Delimiter Separated File";
            this.openDelimiterSeparatedFileToolStripMenuItem.Click += new System.EventHandler(this.openDelimiterSeparatedFileToolStripMenuItem_Click);
            // 
            // View_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 478);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Top);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "View_Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.View_Map_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_Center.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.WebBrowser mctlWB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDelimiterSeparatedFileToolStripMenuItem;
    }
}

