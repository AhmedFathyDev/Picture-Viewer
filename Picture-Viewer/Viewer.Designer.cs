
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
            this.pictureName = new System.Windows.Forms.ToolStripStatusLabel();
            this.space1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.operationalMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.operationalModes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.singleMode = new System.Windows.Forms.ToolStripMenuItem();
            this.multiPictureMode = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshowMode = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.space2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.operationalModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // listBox
            // 
            this.listBox.Enabled = false;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 43);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 381);
            this.listBox.TabIndex = 2;
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Enabled = false;
            this.btnRemovePicture.Location = new System.Drawing.Point(12, 430);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(200, 25);
            this.btnRemovePicture.TabIndex = 3;
            this.btnRemovePicture.Text = "Remove picture";
            this.btnRemovePicture.UseVisualStyleBackColor = true;
            this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // btnRemoveAllPictures
            // 
            this.btnRemoveAllPictures.Enabled = false;
            this.btnRemoveAllPictures.Location = new System.Drawing.Point(12, 461);
            this.btnRemoveAllPictures.Name = "btnRemoveAllPictures";
            this.btnRemoveAllPictures.Size = new System.Drawing.Size(200, 25);
            this.btnRemoveAllPictures.TabIndex = 4;
            this.btnRemoveAllPictures.Text = "Remove all pictures";
            this.btnRemoveAllPictures.UseVisualStyleBackColor = true;
            this.btnRemoveAllPictures.Click += new System.EventHandler(this.btnRemoveAllPictures_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.space1,
            this.pictureName,
            this.space2,
            this.operationalMode});
            this.statusStrip.Location = new System.Drawing.Point(0, 489);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 5;
            // 
            // pictureName
            // 
            this.pictureName.Name = "pictureName";
            this.pictureName.Size = new System.Drawing.Size(0, 17);
            // 
            // space1
            // 
            this.space1.Name = "space1";
            this.space1.Size = new System.Drawing.Size(457, 17);
            this.space1.Text = "                                                  ";
            // 
            // operationalMode
            // 
            this.operationalMode.Name = "operationalMode";
            this.operationalMode.Size = new System.Drawing.Size(73, 17);
            this.operationalMode.Text = "Single mode";
            // 
            // operationalModes
            // 
            this.operationalModes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit,
            this.singleMode,
            this.multiPictureMode,
            this.slideshowMode});
            this.operationalModes.Name = "operationalModes";
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
            this.singleMode.Enabled = false;
            this.singleMode.Name = "singleMode";
            this.singleMode.Size = new System.Drawing.Size(153, 22);
            this.singleMode.Text = "Single mode";
            this.singleMode.Visible = false;
            this.singleMode.Click += new System.EventHandler(this.singleMode_Click);
            // 
            // multiPictureMode
            // 
            this.multiPictureMode.Enabled = false;
            this.multiPictureMode.Name = "multiPictureMode";
            this.multiPictureMode.Size = new System.Drawing.Size(153, 22);
            this.multiPictureMode.Text = "Multi-Picture mode";
            this.multiPictureMode.Click += new System.EventHandler(this.multiPictureMode_Click);
            // 
            // slideshowMode
            // 
            this.slideshowMode.Enabled = false;
            this.slideshowMode.Name = "slideshowMode";
            this.slideshowMode.Size = new System.Drawing.Size(153, 22);
            this.slideshowMode.Text = "Slideshow mode";
            this.slideshowMode.Click += new System.EventHandler(this.slideshowMode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::Picture_Viewer.Properties.Resources.Left_icon;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(218, 430);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 56);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::Picture_Viewer.Properties.Resources.Right_icon;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(697, 430);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 56);
            this.btnRight.TabIndex = 7;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(760, 474);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // space2
            // 
            this.space2.Name = "space2";
            this.space2.Size = new System.Drawing.Size(0, 17);
            this.space2.Text = "                                                                                 " +
    "                                                                     ";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Picture_Viewer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.ContextMenuStrip = this.operationalModes;
            this.Controls.Add(this.btnViewPictures);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnRemovePicture);
            this.Controls.Add(this.btnRemoveAllPictures);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Viewer";
            this.Text = "Picture Viewer";
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
        private System.Windows.Forms.ToolStripStatusLabel pictureName;
        private System.Windows.Forms.ToolStripStatusLabel operationalMode;
        private System.Windows.Forms.ContextMenuStrip operationalModes;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem singleMode;
        private System.Windows.Forms.ToolStripMenuItem multiPictureMode;
        private System.Windows.Forms.ToolStripMenuItem slideshowMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel space1;
        private System.Windows.Forms.ToolStripStatusLabel space2;
    }
}