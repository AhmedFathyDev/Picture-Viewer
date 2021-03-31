using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                this.btnViewPictures.Enabled = false;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.btnViewPictures.Enabled = true;
            }
        }
        private void btnRemovePicture_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnRemovePicture.Enabled = false;
                var index = listBox.SelectedIndex;
                this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;
                this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
                this.toolStripStatus.Text = this.listBox.SelectedItem.ToString();
                this.listBox.Items.RemoveAt(index);
                this.pictures.RemoveAt(index);

                if (this.listBox.Items.Count < 1)
                {
                    this.defaultMode_Click(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There isn't any pictures", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.defaultMode_Click(sender, e);
            }
            finally
            {
                this.btnRemovePicture.Enabled = true;
            }
        }
        private void btnRemoveAllPictures_Click(object sender, EventArgs e)
        {
            this.btnRemoveAllPictures.Enabled = false;
            this.defaultMode_Click(sender, e);
            this.listBox.Items.Clear();
            this.pictures.Clear();
            this.btnRemoveAllPictures.Enabled = true;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.listBox.SelectedIndex = this.listBox.SelectedIndex == 0 ? this.listBox.Items.Count - 1 : this.listBox.SelectedIndex - 1;
            this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
            this.toolStripStatus.Text = this.listBox.SelectedItem.ToString();
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;
            this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
            this.toolStripStatus.Text = this.listBox.SelectedItem.ToString();
        }
        private void defaultMode_Click(object sender, EventArgs e)
        {
            this.listBox.SelectionMode = SelectionMode.None;

            this.defaultMode.Visible = false;

            this.singleMode.Visible = true;
            this.slideshowMode.Visible = true;
            this.multiPictureMode.Visible = true;

            this.toolStripStatus.Visible = false;

            this.timer.Stop();
            this.panel.Controls.Clear();

            this.panel.Visible = false;
            this.btnLeft.Visible = false;
            this.btnRight.Visible = false;
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;

            this.listBox.Visible = true;
            this.btnViewPictures.Visible = true;
            this.btnRemovePicture.Visible = true;
            this.btnRemoveAllPictures.Visible = true;
        }
        private void singleMode_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count < 1)
            {
                MessageBox.Show("Please select one or more picture to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.listBox.SelectionMode = SelectionMode.One;
            this.listBox.SelectedIndex = 0;

            this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];

            this.toolStripStatus.Visible = true;
            this.toolStripStatus.Text = this.listBox.SelectedItem.ToString();

            this.singleMode.Visible = false;
            this.slideshowMode.Visible = false;
            this.multiPictureMode.Visible = false;

            this.btnLeft.Visible = true;
            this.btnRight.Visible = true;
            this.pictureBox1.Visible = true;
            this.defaultMode.Visible = true;
        }
        private void multiPictureMode_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count < 1)
            {
                MessageBox.Show("Please select one or more picture to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.panel.Visible = true;

            this.listBox.SelectionMode = SelectionMode.MultiExtended;

            this.defaultMode.Visible = true;

            this.singleMode.Visible = false;
            this.slideshowMode.Visible = false;
            this.multiPictureMode.Visible = false;

            this.toolStripStatus.Visible = false;
        }
        private void slideshowMode_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count < 1)
            {
                MessageBox.Show("Please select one or more picture to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.listBox.SelectionMode = SelectionMode.One;
            this.listBox.SelectedIndex = 0;

            this.pictureBox2.ImageLocation = this.pictures[this.listBox.SelectedIndex];

            this.toolStripStatus.Visible = true;
            this.toolStripStatus.Text = this.listBox.SelectedItem.ToString();

            this.defaultMode.Visible = true;
            this.pictureBox2.Visible = true;

            this.singleMode.Visible = false;
            this.slideshowMode.Visible = false;
            this.multiPictureMode.Visible = false;

            this.listBox.Visible = false;
            this.btnViewPictures.Visible = false;
            this.btnRemovePicture.Visible = false;
            this.btnRemoveAllPictures.Visible = false;

            this.timer.Start();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ListBox_MouseClick(object sender, EventArgs e)
        {
            if (this.pictureBox1.Visible)
            {
                this.pictureBox1.ImageLocation = this.pictures[this.listBox.SelectedIndex];
                this.toolStripStatus.Text = this.listBox.SelectedItem.ToString();
                return;
            }
            if (this.listBox.SelectedIndices.Count == 1)
            {
                this.panel.Controls.Clear();

                this.panel.Controls.Add(new PictureBox
                {
                    BackColor = Color.Transparent,
                    Top = 6,
                    Left = 6,
                    Width = 244,
                    Height = 244,
                    Name = "pictureBox0",
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Visible = true,
                    ImageLocation = this.pictures[this.listBox.SelectedIndex]
                });
                return;
            }

            this.panel.Controls.Clear();

            for (int i = 0; i < this.listBox.SelectedIndices.Count; i++)
            {
                this.panel.Controls.Add(new PictureBox
                {
                    BackColor = Color.Transparent,
                    Top = 6 + (250 * (i / 2)),
                    Left = 6 + (250 * (i % 2)),
                    Width = 244,
                    Height = 244,
                    Name = "pictureBox" + i,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Visible = true,
                    ImageLocation = this.pictures[this.listBox.SelectedIndices[i]]
                });
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;
            this.pictureBox2.ImageLocation = this.pictures[this.listBox.SelectedIndex];
            this.toolStripStatus.Text = this.listBox.SelectedItem.ToString();
        }

        private List<string> pictures;
    }
}
