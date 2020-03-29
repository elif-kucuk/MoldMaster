namespace MoldMasterWinUI
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.WorkCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.MoldType = new System.Windows.Forms.ToolStripMenuItem();
            this.moldTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkCenter,
            this.MoldType,
            this.moldTransferToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // WorkCenter
            // 
            this.WorkCenter.Name = "WorkCenter";
            this.WorkCenter.Size = new System.Drawing.Size(85, 20);
            this.WorkCenter.Text = "Work Center";
            this.WorkCenter.Click += new System.EventHandler(this.WorkCenter_Click_1);
            // 
            // MoldType
            // 
            this.MoldType.Name = "MoldType";
            this.MoldType.Size = new System.Drawing.Size(74, 20);
            this.MoldType.Text = "Mold Type";
            this.MoldType.Click += new System.EventHandler(this.MoldType_Click);
            // 
            // moldTransferToolStripMenuItem
            // 
            this.moldTransferToolStripMenuItem.Name = "moldTransferToolStripMenuItem";
            this.moldTransferToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.moldTransferToolStripMenuItem.Text = "Mold Transfer";
            this.moldTransferToolStripMenuItem.Click += new System.EventHandler(this.moldTransferToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1164, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem WorkCenter;
        private System.Windows.Forms.ToolStripMenuItem MoldType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem moldTransferToolStripMenuItem;
    }
}