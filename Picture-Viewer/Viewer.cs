using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Picture_Viewer
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            this.InitializeComponent();

            this.pictures = new List<string>();
        }
        private void btnViewPictures_Click(object sender, EventArgs e)
        {
            try
            {
                var picturesFiles = new OpenFileDialog
                {
                    Title = "Select view pictures",
                    Filter = "Pictures files | *.jpg; *.jpeg; *.png",
                    Multiselect = true
                };

                if (picturesFiles.ShowDialog() == DialogResult.OK)
                {
                    this.pictures.AddRange(picturesFiles.FileNames);
                    this.listBox.Items.AddRange(picturesFiles.SafeFileNames);
                }

                this.listBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListBox_MouseClick(object sender, EventArgs e)
        {
            if (this.pictureBox1.Visible == false && this.panel.Visible == false)
            {
                return;
            }
            if (this.panel.Visible == false)
            {
                this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
                this.pictureName.Text = this.listBox.SelectedItem.ToString();
                return;
            }
            if (this.listBox.SelectedIndices.Count == 1)
            {
                this.panel.Controls.Clear();

                this.panel.Controls.Add(new PictureBox
                {
                    Name = "pictureBox0",
                    Top = 6,
                    Left = 6,
                    Width = 234,
                    Height = 234,
                    Visible = true,
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = this.pictures[this.listBox.SelectedIndex]
                });

                return;
            }

            this.panel.Controls.Clear();

            for (int i = 0; i < this.listBox.SelectedIndices.Count; i++)
            {
                this.panel.Controls.Add(new PictureBox
                {
                    Name = "pictureBox" + i,
                    Width = 234,
                    Height = 234,
                    Visible = true,
                    Top = 6 + (240 * (i / 2)),
                    Left = 6 + (240 * (i % 2)),
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = this.pictures[this.listBox.SelectedIndices[i]]
                });
            }
        }
        private void btnRemovePicture_Click(object sender, EventArgs e)
        {
            try
            {
                var index = listBox.SelectedIndex;
                this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;
                this.pictures.RemoveAt(index);
                this.listBox.Items.RemoveAt(index);
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any pictures", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemoveAllPictures_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count < 1)
            {
                MessageBox.Show("There isn't any pictures", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.listBox.Items.Clear();
            this.pictures.Clear();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void singleMode_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count < 1)
            {
                MessageBox.Show("Please select one or more picture to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.defaultMode.Visible = true;

            this.singleMode.Visible = false;
            this.slideshowMode.Visible = false;
            this.multiPictureMode.Visible = false;

            this.operationalMode.Text = "Single mode";

            this.listBox.Height = 394;

            this.pictureBox1.Visible = true;
            this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];

            this.pictureName.Visible = true;
            this.pictureName.Text = this.listBox.SelectedItem.ToString();

            this.btnLeft.Visible = true;
            this.btnRight.Visible = true;

            this.btnRemovePicture.Visible = false;
            this.btnRemoveAllPictures.Visible = false;
        }
        private void multiPictureMode_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count < 1)
            {
                MessageBox.Show("Please select one or more picture to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.defaultMode.Visible = true;

            this.singleMode.Visible = false;
            this.slideshowMode.Visible = false;
            this.multiPictureMode.Visible = false;

            this.operationalMode.Text = "Multi-Pictures mode";

            this.panel.Visible = true;

            this.listBox.Height = 394;
            this.listBox.SelectionMode = SelectionMode.MultiExtended;

            this.ListBox_MouseClick(sender, e);

            this.btnRemovePicture.Visible = false;
            this.btnRemoveAllPictures.Visible = false;
        }
        private void slideshowMode_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count < 1)
            {
                MessageBox.Show("Please select one or more picture to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.defaultMode.Visible = true;

            this.singleMode.Visible = false;
            this.slideshowMode.Visible = false;
            this.multiPictureMode.Visible = false;

            this.operationalMode.Text = "Slideshow mode";

            this.listBox.Visible = false;

            this.btnViewPictures.Visible = false;
            this.btnRemovePicture.Visible = false;
            this.btnRemoveAllPictures.Visible = false;

            this.pictureBox2.Visible = true;
            this.pictureBox2.ImageLocation = this.pictures[this.listBox.SelectedIndex];

            this.pictureName.Visible = true;
            this.pictureName.Text = this.listBox.SelectedItem.ToString();

            this.timer.Start();
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.listBox.SelectedIndex = this.listBox.SelectedIndex == 0 ? this.listBox.Items.Count - 1 : this.listBox.SelectedIndex - 1;
            
            this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
            this.pictureName.Text = this.listBox.SelectedItem.ToString();
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;
            
            this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
            this.pictureName.Text = this.listBox.SelectedItem.ToString();
        }
        private void defaultMode_Click(object sender, EventArgs e)
        {
            this.defaultMode.Visible = false;

            this.singleMode.Visible = true;
            this.slideshowMode.Visible = true;
            this.multiPictureMode.Visible = true;

            this.operationalMode.Text = "Default mode";

            this.listBox.Height = 329;
            this.listBox.Visible = true;
            this.listBox.SelectedIndex = 0;
            this.listBox.SelectionMode = SelectionMode.One;

            this.timer.Stop();
            this.panel.Controls.Clear();

            this.panel.Visible = false;
            this.btnLeft.Visible = false;
            this.btnRight.Visible = false;
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureName.Visible = false;

            this.btnViewPictures.Visible = true;
            this.btnRemovePicture.Visible = true;
            this.btnRemoveAllPictures.Visible = true;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;
            
            this.pictureBox2.ImageLocation = this.pictures[this.listBox.SelectedIndex];
            this.pictureName.Text = this.listBox.SelectedItem.ToString();
        }

        private List<string> pictures;
    }
}
