
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
            this.operationalModes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.singleMode = new System.Windows.Forms.ToolStripMenuItem();
            this.multiPictureMode = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshowMode = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnViewPictures = new System.Windows.Forms.Button();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.btnRemoveAllPictures = new System.Windows.Forms.Button();
            this.operationalModes.SuspendLayout();
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
            // 
            // slideshowMode
            // 
            this.slideshowMode.Name = "slideshowMode";
            this.slideshowMode.Size = new System.Drawing.Size(153, 22);
            this.slideshowMode.Text = "Slideshow mode";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 51);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(180, 329);
            this.listBox.TabIndex = 1;
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            // 
            // btnViewPictures
            // 
            this.btnViewPictures.Location = new System.Drawing.Point(12, 12);
            this.btnViewPictures.Name = "btnViewPictures";
            this.btnViewPictures.Size = new System.Drawing.Size(180, 33);
            this.btnViewPictures.TabIndex = 5;
            this.btnViewPictures.Text = "View pictures";
            this.btnViewPictures.UseVisualStyleBackColor = true;
            this.btnViewPictures.Click += new System.EventHandler(this.btnViewPictures_Click);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Location = new System.Drawing.Point(12, 386);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(180, 23);
            this.btnRemovePicture.TabIndex = 6;
            this.btnRemovePicture.Text = "Remove picture";
            this.btnRemovePicture.UseVisualStyleBackColor = true;
            this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // btnRemoveAllPictures
            // 
            this.btnRemoveAllPictures.Location = new System.Drawing.Point(12, 415);
            this.btnRemoveAllPictures.Name = "btnRemoveAllPictures";
            this.btnRemoveAllPictures.Size = new System.Drawing.Size(180, 23);
            this.btnRemoveAllPictures.TabIndex = 7;
            this.btnRemoveAllPictures.Text = "Remove all pictures";
            this.btnRemoveAllPictures.UseVisualStyleBackColor = true;
            this.btnRemoveAllPictures.Click += new System.EventHandler(this.btnRemoveAllPictures_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Picture_Viewer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.ContextMenuStrip = this.operationalModes;
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnViewPictures);
            this.Controls.Add(this.btnRemovePicture);
            this.Controls.Add(this.btnRemoveAllPictures);
            this.Name = "Viewer";
            this.Text = "Picture Viewer";
            this.operationalModes.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}