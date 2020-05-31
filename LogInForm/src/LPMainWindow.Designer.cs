using System.Drawing;
using System.Windows.Forms;

namespace LogInForm
{
    partial class LPMainWindow
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
            this.CollectionGroupBox = new System.Windows.Forms.GroupBox();
            this.NightCollectionButton = new System.Windows.Forms.Button();
            this.MorningCollectionButton = new System.Windows.Forms.Button();
            this.LordPictureBox = new System.Windows.Forms.PictureBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quiteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustDataButton = new System.Windows.Forms.Button();
            this.RateChartFeedButton = new System.Windows.Forms.Button();
            this.CollectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LordPictureBox)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CollectionGroupBox
            // 
            this.CollectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectionGroupBox.AutoSize = true;
            this.CollectionGroupBox.Controls.Add(this.NightCollectionButton);
            this.CollectionGroupBox.Controls.Add(this.MorningCollectionButton);
            this.CollectionGroupBox.ForeColor = System.Drawing.Color.Red;
            this.CollectionGroupBox.Location = new System.Drawing.Point(619, 59);
            this.CollectionGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.CollectionGroupBox.Name = "CollectionGroupBox";
            this.CollectionGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CollectionGroupBox.Size = new System.Drawing.Size(201, 400);
            this.CollectionGroupBox.TabIndex = 0;
            this.CollectionGroupBox.TabStop = false;
            this.CollectionGroupBox.Text = "Collections";
            // 
            // NightCollectionButton
            // 
            this.NightCollectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NightCollectionButton.Location = new System.Drawing.Point(17, 115);
            this.NightCollectionButton.Name = "NightCollectionButton";
            this.NightCollectionButton.Size = new System.Drawing.Size(176, 47);
            this.NightCollectionButton.TabIndex = 1;
            this.NightCollectionButton.Text = "सायंकाळ संकलन";
            this.NightCollectionButton.UseVisualStyleBackColor = true;
            this.NightCollectionButton.Click += new System.EventHandler(this.NightCollectionButton_Click);
            // 
            // MorningCollectionButton
            // 
            this.MorningCollectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MorningCollectionButton.Location = new System.Drawing.Point(17, 44);
            this.MorningCollectionButton.Name = "MorningCollectionButton";
            this.MorningCollectionButton.Size = new System.Drawing.Size(176, 48);
            this.MorningCollectionButton.TabIndex = 0;
            this.MorningCollectionButton.Text = "सकाळ संकलन";
            this.MorningCollectionButton.UseVisualStyleBackColor = true;
            this.MorningCollectionButton.Click += new System.EventHandler(this.MorningCollectionButton_Click);
            // 
            // LordPictureBox
            // 
            this.LordPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LordPictureBox.BackgroundImage = global::LogInForm.Properties.Resources.VinayakaLandScape;
            this.LordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LordPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LordPictureBox.Location = new System.Drawing.Point(127, 59);
            this.LordPictureBox.Name = "LordPictureBox";
            this.LordPictureBox.Size = new System.Drawing.Size(484, 409);
            this.LordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LordPictureBox.TabIndex = 1;
            this.LordPictureBox.TabStop = false;
            // 
            // MenuBar
            // 
            this.MenuBar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(834, 37);
            this.MenuBar.TabIndex = 2;
            this.MenuBar.Text = "MenuBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.quiteToolStripMenuItem1,
            this.quiteToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 33);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // quiteToolStripMenuItem1
            // 
            this.quiteToolStripMenuItem1.Name = "quiteToolStripMenuItem1";
            this.quiteToolStripMenuItem1.Size = new System.Drawing.Size(154, 34);
            this.quiteToolStripMenuItem1.Text = "&Save";
            // 
            // quiteToolStripMenuItem2
            // 
            this.quiteToolStripMenuItem2.Name = "quiteToolStripMenuItem2";
            this.quiteToolStripMenuItem2.Size = new System.Drawing.Size(154, 34);
            this.quiteToolStripMenuItem2.Text = "&Quite";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(66, 33);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(72, 33);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(78, 33);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(111, 33);
            this.windowsToolStripMenuItem.Text = "&Windows";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(69, 33);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // AddCustDataButton
            // 
            this.AddCustDataButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddCustDataButton.Location = new System.Drawing.Point(13, 59);
            this.AddCustDataButton.Name = "AddCustDataButton";
            this.AddCustDataButton.Size = new System.Drawing.Size(108, 43);
            this.AddCustDataButton.TabIndex = 3;
            this.AddCustDataButton.Text = "नवीन ग्राहक जोडा";
            this.AddCustDataButton.UseVisualStyleBackColor = true;
            this.AddCustDataButton.Click += new System.EventHandler(this.AddCustDataButton_Click);
            // 
            // RateChartFeedButton
            // 
            this.RateChartFeedButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateChartFeedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RateChartFeedButton.Location = new System.Drawing.Point(13, 109);
            this.RateChartFeedButton.Name = "RateChartFeedButton";
            this.RateChartFeedButton.Size = new System.Drawing.Size(108, 42);
            this.RateChartFeedButton.TabIndex = 4;
            this.RateChartFeedButton.Text = "दर पत्रक";
            this.RateChartFeedButton.UseVisualStyleBackColor = true;
            this.RateChartFeedButton.Click += new System.EventHandler(this.RateChartFeedButton_Click);
            // 
            // LPMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.RateChartFeedButton);
            this.Controls.Add(this.AddCustDataButton);
            this.Controls.Add(this.LordPictureBox);
            this.Controls.Add(this.CollectionGroupBox);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LPMainWindow";
            this.Text = "LPMainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LPMainWindow_FormClosing);
            this.CollectionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LordPictureBox)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CollectionGroupBox;
        private System.Windows.Forms.Button NightCollectionButton;
        private System.Windows.Forms.Button MorningCollectionButton;
        private System.Windows.Forms.PictureBox LordPictureBox;
        private MenuStrip MenuBar;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem quiteToolStripMenuItem1;
        private ToolStripMenuItem quiteToolStripMenuItem2;
        private Button AddCustDataButton;
        private Button RateChartFeedButton;
    }
}