
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
            this.btnViewPictures = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.btnRemoveAllPictures = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.operationalModes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.singleMode = new System.Windows.Forms.ToolStripMenuItem();
            this.multiPictureMode = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultMode = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshowMode = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.operationalModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewPictures
            // 
            this.btnViewPictures.Name = "btnViewPictures";
            this.btnViewPictures.Text = "View pictures";
            this.btnViewPictures.TabIndex = 1;
            this.btnViewPictures.UseVisualStyleBackColor = true;
            this.btnViewPictures.Location = new System.Drawing.Point(12, 12);
            this.btnViewPictures.Size = new System.Drawing.Size(200, 25);
            this.btnViewPictures.Click += new System.EventHandler(this.btnViewPictures_Click);
            // 
            // listBox
            // 
            this.listBox.Name = "listBox";
            this.listBox.TabIndex = 2;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 43);
            this.listBox.Size = new System.Drawing.Size(200, 329);
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Text = "Remove picture";
            this.btnRemovePicture.TabIndex = 3;
            this.btnRemovePicture.UseVisualStyleBackColor = true;
            this.btnRemovePicture.Location = new System.Drawing.Point(12, 378);
            this.btnRemovePicture.Size = new System.Drawing.Size(200, 25);
            this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // btnRemoveAllPictures
            // 
            this.btnRemoveAllPictures.Name = "btnRemoveAllPictures";
            this.btnRemoveAllPictures.Text = "Remove all pictures";
            this.btnRemoveAllPictures.TabIndex = 4;
            this.btnRemoveAllPictures.UseVisualStyleBackColor = true;
            this.btnRemoveAllPictures.Location = new System.Drawing.Point(12, 409);
            this.btnRemoveAllPictures.Size = new System.Drawing.Size(200, 25);
            this.btnRemoveAllPictures.Click += new System.EventHandler(this.btnRemoveAllPictures_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripStatus});
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // operationalModes
            // 
            this.operationalModes.Name = "contextMenuStrip";
            this.operationalModes.Text = "Operational modes";
            this.operationalModes.Size = new System.Drawing.Size(179, 114);
            this.operationalModes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit,
            this.singleMode,
            this.multiPictureMode,
            this.defaultMode,
            this.slideshowMode});
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Text = "Exit";
            this.exit.Size = new System.Drawing.Size(178, 22);
            this.exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // singleMode
            // 
            this.singleMode.Name = "singleMode";
            this.singleMode.Text = "Single mode";
            this.singleMode.Size = new System.Drawing.Size(178, 22);
            this.singleMode.Click += new System.EventHandler(this.singleMode_Click);
            // 
            // multiPictureMode
            // 
            this.multiPictureMode.Name = "multiPictureMode";
            this.multiPictureMode.Text = "Multi-Picture mode";
            this.multiPictureMode.Size = new System.Drawing.Size(178, 22);
            this.multiPictureMode.Click += new System.EventHandler(this.multiPictureMode_Click);
            // 
            // defaultMode
            // 
            this.defaultMode.Name = "defaultMode";
            this.defaultMode.Text = "Default Mode";
            this.defaultMode.Visible = false;
            this.defaultMode.Size = new System.Drawing.Size(178, 22);
            this.defaultMode.Click += new System.EventHandler(this.defaultMode_Click);
            // 
            // slideshowMode
            // 
            this.slideshowMode.Name = "slideshowMode";
            this.slideshowMode.Text = "Slideshow mode";
            this.slideshowMode.Size = new System.Drawing.Size(178, 22);
            this.slideshowMode.Click += new System.EventHandler(this.slideshowMode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Size = new System.Drawing.Size(504, 360);
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btnRight
            // 
            this.btnRight.Name = "btnRight";
            this.btnRight.TabIndex = 7;
            this.btnRight.Visible = false;
            this.btnRight.Location = new System.Drawing.Point(647, 378);
            this.btnRight.Size = new System.Drawing.Size(75, 56);
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.BackgroundImage = global::Picture_Viewer.Properties.Resources.Right_icon;
            // 
            // btnLeft
            // 
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Visible = false;
            this.btnLeft.Location = new System.Drawing.Point(218, 378);
            this.btnLeft.Size = new System.Drawing.Size(75, 56);
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.BackgroundImage = global::Picture_Viewer.Properties.Resources.Left_icon;
            // 
            // panel
            // 
            this.panel.Name = "panel";
            this.panel.TabIndex = 9;
            this.panel.Visible = false;
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(218, 12);
            this.panel.Size = new System.Drawing.Size(504, 422);
            this.panel.BackColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Size = new System.Drawing.Size(710, 422);
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Viewer
            // 
            this.Name = "Viewer";
            this.Text = "Picture Viewer";
            this.Controls.Add(this.btnViewPictures);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnRemovePicture);
            this.Controls.Add(this.btnRemoveAllPictures);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox2);
            this.ContextMenuStrip = this.operationalModes;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.BackgroundImage = global::Picture_Viewer.Properties.Resources.Background;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.operationalModes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewPictures;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.Button btnRemoveAllPictures;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ContextMenuStrip operationalModes;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem singleMode;
        private System.Windows.Forms.ToolStripMenuItem multiPictureMode;
        private System.Windows.Forms.ToolStripMenuItem slideshowMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.ToolStripMenuItem defaultMode;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer;
    }
}