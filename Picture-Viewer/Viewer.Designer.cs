
namespace Picture_Viewer
{
    partial class Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.operationalModes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.singleMode = new System.Windows.Forms.ToolStripMenuItem();
            this.multiPictureMode = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshowMode = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultMode = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnViewPictures = new System.Windows.Forms.Button();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.btnRemoveAllPictures = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.operationalModes.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationalModes
            // 
            this.operationalModes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit,
            this.singleMode,
            this.multiPictureMode,
            this.defaultMode,
            this.slideshowMode});
            this.operationalModes.Name = "contextMenuStrip";
            this.operationalModes.ShowImageMargin = false;
            this.operationalModes.Size = new System.Drawing.Size(154, 92);
            this.operationalModes.Text = "Operational modes";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(153, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // singleMode
            // 
            this.singleMode.Name = "singleMode";
            this.singleMode.Size = new System.Drawing.Size(153, 22);
            this.singleMode.Text = "Single mode";
            this.singleMode.Click += new System.EventHandler(this.singleMode_Click);
            // 
            // multiPictureMode
            // 
            this.multiPictureMode.Name = "multiPictureMode";
            this.multiPictureMode.Size = new System.Drawing.Size(153, 22);
            this.multiPictureMode.Text = "Multi-Picture mode";
            this.multiPictureMode.Click += new System.EventHandler(this.multiPictureMode_Click);
            // 
            // slideshowMode
            // 
            this.slideshowMode.Name = "slideshowMode";
            this.slideshowMode.Size = new System.Drawing.Size(153, 22);
            this.slideshowMode.Text = "Slideshow mode";
            this.slideshowMode.Click += new System.EventHandler(this.slideshowMode_Click);
            // 
            // defaultMode
            // 
            this.defaultMode.Name = "defaultMode";
            this.defaultMode.Size = new System.Drawing.Size(155, 22);
            this.defaultMode.Text = "Default Mode";
            this.defaultMode.Visible = false;
            this.defaultMode.Click += new System.EventHandler(this.defaultMode_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 43);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox.Size = new System.Drawing.Size(200, 329);
            this.listBox.TabIndex = 2;
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            //
            // pictureBox1
            //
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.Visible = false;
            //
            // pictureBox2
            //
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(710, 422);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.Visible = false;
            // 
            // btnRight
            // 
            this.btnRight.Name = "btnRight";
            this.btnRight.BackgroundImage = Properties.Resources.Right_icon;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(647, 378);
            this.btnRight.Size = new System.Drawing.Size(75, 56);
            this.btnRight.Visible = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.BackgroundImage = Properties.Resources.Left_icon;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(218, 378);
            this.btnLeft.Size = new System.Drawing.Size(75, 56);
            this.btnLeft.Visible = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnViewPictures
            // 
            this.btnViewPictures.Location = new System.Drawing.Point(12, 12);
            this.btnViewPictures.Name = "btnViewPictures";
            this.btnViewPictures.Size = new System.Drawing.Size(200, 25);
            this.btnViewPictures.TabIndex = 1;
            this.btnViewPictures.Text = "View pictures";
            this.btnViewPictures.UseVisualStyleBackColor = true;
            this.btnViewPictures.Click += new System.EventHandler(this.btnViewPictures_Click);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Location = new System.Drawing.Point(12, 378);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(200, 25);
            this.btnRemovePicture.TabIndex = 3;
            this.btnRemovePicture.Text = "Remove picture";
            this.btnRemovePicture.UseVisualStyleBackColor = true;
            this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // btnRemoveAllPictures
            // 
            this.btnRemoveAllPictures.Location = new System.Drawing.Point(12, 409);
            this.btnRemoveAllPictures.Name = "btnRemoveAllPictures";
            this.btnRemoveAllPictures.Size = new System.Drawing.Size(200, 25);
            this.btnRemoveAllPictures.TabIndex = 4;
            this.btnRemoveAllPictures.Text = "Remove all pictures";
            this.btnRemoveAllPictures.UseVisualStyleBackColor = true;
            this.btnRemoveAllPictures.Click += new System.EventHandler(this.btnRemoveAllPictures_Click);
            //
            // panel
            //
            this.panel.Name = "panel";
            this.panel.Location = new System.Drawing.Point(218, 12);
            this.panel.Size = new System.Drawing.Size(504, 422);
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Visible = false;
            this.panel.AutoScroll = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.TabIndex = 5;
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Picture_Viewer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.ContextMenuStrip = this.operationalModes;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnViewPictures);
            this.Controls.Add(this.btnRemovePicture);
            this.Controls.Add(this.btnRemoveAllPictures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Viewer";
            this.Text = "Picture Viewer";
            this.operationalModes.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;

        private System.Windows.Forms.ListBox listBox;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnViewPictures;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.Button btnRemoveAllPictures;

        private System.Windows.Forms.ContextMenuStrip operationalModes;

        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem singleMode;
        private System.Windows.Forms.ToolStripMenuItem defaultMode;
        private System.Windows.Forms.ToolStripMenuItem slideshowMode;
        private System.Windows.Forms.ToolStripMenuItem multiPictureMode;

        private System.Windows.Forms.StatusStrip statusStrip;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

        private System.Windows.Forms.Timer timer;
    }
}