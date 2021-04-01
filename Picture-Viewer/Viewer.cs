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
            this.multiPicturePictures = new List<PictureBox>();
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

                    this.listBox.Enabled = true;
                    this.btnLeft.Enabled = true;
                    this.btnRight.Enabled = true;
                    this.singleMode.Enabled = true;
                    this.slideshowMode.Enabled = true;
                    this.multiPictureMode.Enabled = true;
                    this.pictureBox1.Enabled = true;
                    this.btnRemovePicture.Enabled = true;
                    this.btnRemoveAllPictures.Enabled = true;

                    if (!this.singleMode.Visible)
                    {
                        this.listBox.SelectedIndex = 0;
                    }

                    this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
                    this.pictureName.Text = this.listBox.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListBox_MouseClick(object sender, EventArgs e)
        {
            if (this.pictureBox1.Visible)
            {
                this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
                this.pictureName.Text = this.listBox.SelectedItem.ToString();

                return;
            }

            if (this.listBox.SelectedIndices.Count == 1)
            {
                for (int i = 0; i < this.multiPicturePictures.Count; i++)
                {
                    this.Controls.Remove(multiPicturePictures[i]);
                }
                this.multiPicturePictures.Clear();

                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Location = new Point(218, 12),
                    Width = 174,
                    Height = 214,
                    Visible = true,
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = this.pictures[this.listBox.SelectedIndex]
                };

                this.Controls.Add(picture);
                this.multiPicturePictures.Add(picture);

                return;
            }

            for (int i = 0; i < this.multiPicturePictures.Count; i++)
            {
                this.Controls.Remove(multiPicturePictures[i]);
            }
            this.multiPicturePictures.Clear();

            for (int i = 0; i < this.listBox.SelectedIndices.Count; i++)
            {
                var picture = new PictureBox
                {
                    Name = "pictureBox",
                    Width = 174,
                    Height = 214,
                    Visible = true,
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = this.pictures[this.listBox.SelectedIndices[i]],
                    Location = new Point(218 + (180 * (i % 3)), 12 + (220 * (i / 3)))
                };

                this.Controls.Add(picture);
                this.multiPicturePictures.Add(picture);
            }
        }
        private void btnRemovePicture_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listBox.Items.Count == 1)
                {
                    this.pictures.Clear();
                    this.listBox.Items.Clear();
                    this.pictureName.Text = "";
                    this.pictureBox1.ImageLocation = null;

                    this.listBox.Enabled = false;
                    this.btnLeft.Enabled = false;
                    this.btnRight.Enabled = false;
                    this.pictureBox1.Enabled = false;
                    this.btnRemovePicture.Enabled = false;
                    this.btnRemoveAllPictures.Enabled = false;

                    this.singleMode.Enabled = false;
                    this.slideshowMode.Enabled = false;
                    this.multiPictureMode.Enabled = false;

                    return;
                }

                var index = listBox.SelectedIndex;

                this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;
                
                this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
                this.pictureName.Text = this.listBox.SelectedItem.ToString();

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

            this.pictures.Clear();
            this.listBox.Items.Clear();
            this.pictureName.Text = "";
            this.pictureBox1.ImageLocation = null;

            this.listBox.Enabled = false;
            this.btnLeft.Enabled = false;
            this.btnRight.Enabled = false;
            this.pictureBox1.Enabled = false;
            this.btnRemovePicture.Enabled = false;
            this.btnRemoveAllPictures.Enabled = false;

            this.singleMode.Enabled = false;
            this.slideshowMode.Enabled = false;
            this.multiPictureMode.Enabled = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void singleMode_Click(object sender, EventArgs e)
        {
            this.operationalMode.Text = "Single mode";
            this.singleMode.Visible = false;

            this.slideshowMode.Visible = true;
            this.multiPictureMode.Visible = true;

            this.timer.Stop();
            this.pictureBox2.Visible = false;

            for (int i = 0; i < this.multiPicturePictures.Count; i++)
            {
                this.Controls.Remove(multiPicturePictures[i]);
            }
            this.multiPicturePictures.Clear();

            this.btnLeft.Visible = true;
            this.btnRight.Visible = true;
            this.btnViewPictures.Visible = true;
            this.btnRemovePicture.Visible = true;
            this.btnRemoveAllPictures.Visible = true;

            this.listBox.Height = 381;
            this.listBox.Visible = true;
            this.listBox.SelectedIndex = 0;
            this.listBox.SelectionMode = SelectionMode.One;

            this.pictureBox1.Visible = true;
            this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];

            this.pictureName.Visible = true;
            this.pictureName.Text = this.listBox.SelectedItem.ToString();
        }
        private void multiPictureMode_Click(object sender, EventArgs e)
        {
            this.operationalMode.Text = "Multi-Pictures mode";
            this.multiPictureMode.Visible = false;

            this.singleMode.Visible = true;
            this.slideshowMode.Visible = true;

            this.btnViewPictures.Visible = true;

            this.timer.Stop();
            this.pictureBox2.Visible = false;

            this.btnLeft.Visible = false;
            this.btnRight.Visible = false;
            this.pictureBox1.Visible = false;
            this.pictureName.Visible = false;
            this.btnRemovePicture.Visible = false;
            this.btnRemoveAllPictures.Visible = false;

            for (int i = 0; i < this.multiPicturePictures.Count; i++)
            {
                this.Controls.Remove(multiPicturePictures[i]);
            }
            this.multiPicturePictures.Clear();

            this.listBox.Height = 446;
            this.listBox.Visible = true;
            this.listBox.SelectedIndex = 0;
            this.listBox.SelectionMode = SelectionMode.MultiExtended;

            this.ListBox_MouseClick(sender, e);
        }
        private void slideshowMode_Click(object sender, EventArgs e)
        {
            this.operationalMode.Text = "Slideshow mode";
            this.slideshowMode.Visible = false;

            this.singleMode.Visible = true;
            this.multiPictureMode.Visible = true;

            for (int i = 0; i < this.multiPicturePictures.Count; i++)
            {
                this.Controls.Remove(multiPicturePictures[i]);
            }
            this.multiPicturePictures.Clear();

            this.listBox.Visible = false;
            this.btnLeft.Visible = false;
            this.btnRight.Visible = false;
            this.pictureBox1.Visible = false;
            this.btnViewPictures.Visible = false;
            this.btnRemovePicture.Visible = false;
            this.btnRemoveAllPictures.Visible = false;


            this.listBox.SelectedIndex = 0;
            this.listBox.SelectionMode = SelectionMode.One;

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
        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.listBox.SelectedIndex + 1 == this.listBox.Items.Count)
            {
                this.timer.Stop();
            }

            this.pictureBox2.ImageLocation = this.pictures[++this.listBox.SelectedIndex];
            this.pictureName.Text = this.listBox.SelectedItem.ToString();
        }

        private List<string> pictures;
        private List<PictureBox> multiPicturePictures;
    }
}
