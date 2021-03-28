
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnViewPictures = new System.Windows.Forms.Button();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.btnRemoveAllPictures = new System.Windows.Forms.Button();
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
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnViewPictures);
            this.Controls.Add(this.btnRemovePicture);
            this.Controls.Add(this.btnRemoveAllPictures);
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

        private System.Windows.Forms.ContextMenuStrip operationalModes;
        private System.Windows.Forms.ToolStripMenuItem singleMode;
        private System.Windows.Forms.ToolStripMenuItem slideshowMode;
        private System.Windows.Forms.ToolStripMenuItem multiPictureMode;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnViewPictures;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.Button btnRemoveAllPictures;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Timer timer;
    }
}