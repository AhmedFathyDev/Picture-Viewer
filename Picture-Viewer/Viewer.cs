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
            this.pictures = new List<string>();
            InitializeComponent();
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

                    this.listBox.Items.Clear();
                    this.listBox.Items.AddRange(picturesFiles.SafeFileNames);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.listBox.SelectedIndex = 0;
                this.btnViewPictures.Enabled = true;
            }
        }

        private void btnRemovePicture_Click(object sender, EventArgs e)
        {
            try
            {
                var index = listBox.SelectedIndex;
                this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;
                this.listBox.Items.RemoveAt(index);
                this.pictures.RemoveAt(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveAllPictures_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            this.pictures.Clear();
        }

        private void defaultMode_Click(object sender, EventArgs e)
        {
            this.defaultMode.Visible = false;

            this.singleMode.Visible = true;
            this.slideshowMode.Visible = true;
            this.multiPictureMode.Visible = true;

            this.btnLeft.Visible = false;
            this.btnRight.Visible = false;
            this.pictureBox.Visible = false;
        }

        private void singleMode_Click(object sender, EventArgs e)
        {
            if (this.listBox.Items.Count < 1)
            {
                MessageBox.Show("Please select one or more pictures to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            this.listBox.SelectionMode = SelectionMode.One;

            if (this.listBox.SelectedIndex == -1)
            {
                this.listBox.SelectedIndex = 0;
            }

            this.singleMode.Visible = false;
            this.slideshowMode.Visible = false;
            this.multiPictureMode.Visible = false;

            this.defaultMode = new ToolStripMenuItem
            {
                Name = "defaultMode",
                Size = new Size(155, 22),
                Text = "Default Mode"
            };
            this.defaultMode.Click += new EventHandler(this.defaultMode_Click);
            this.operationalModes.Items.Add(this.defaultMode);

            this.pictureBox = new PictureBox
            {
                BackColor = Color.Transparent,
                BackgroundImageLayout = ImageLayout.Stretch,
                Location = new Point(198, 12),
                Name = "pictureBox",
                Size = new Size(468, 368),
                SizeMode = PictureBoxSizeMode.Zoom,
                TabIndex = 3,
                TabStop = false,
                Visible = true,
                ImageLocation = this.pictures[this.listBox.SelectedIndex]
            };
            this.Controls.Add(this.pictureBox);

            this.btnLeft = new Button
            {
                BackgroundImage = Properties.Resources.Left_icon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Location = new Point(198, 386),
                Name = "btnLeft",
                Size = new Size(75, 52),
                TabIndex = 2,
                Visible = true
            };
            this.btnLeft.Click += new EventHandler(this.btnLeft_Click);
            this.Controls.Add(this.btnLeft);

            this.btnRight = new Button
            {
                BackgroundImage = Properties.Resources.Right_icon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Location = new Point(591, 386),
                Name = "btnRight",
                Size = new Size(75, 52),
                TabIndex = 1,
                Visible = true
            };
            this.btnRight.Click += new EventHandler(this.btnRight_Click);
            this.Controls.Add(this.btnRight);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.listBox.SelectedIndex = this.listBox.SelectedIndex == 0 ? this.listBox.Items.Count - 1 : this.listBox.SelectedIndex - 1;

            this.pictureBox.ImageLocation = this.pictures[this.listBox.SelectedIndex];
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.listBox.SelectedIndex = this.listBox.SelectedIndex + 1 == this.listBox.Items.Count ? 0 : this.listBox.SelectedIndex + 1;

            this.pictureBox.ImageLocation = this.pictures[this.listBox.SelectedIndex];
        }

        private void ViewPictures(List<string> pictures)
        {
            if (this.pictureBox == null || this.pictureBox.Visible == false)
            {
                MessageBox.Show("Please select operational mode to view", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pictures.Count == 1)
            {
                this.pictureBox.ImageLocation = this.pictures[this.listBox.SelectedIndex];
                return;
            }

        }

        private List<string> GetSelectedPictures()
        {
            var selectedPictures = new List<string>();

            foreach (int index in listBox.SelectedIndices)
            {
                selectedPictures.Add(pictures[index]);
            }

            return selectedPictures;
        }

        private void ListBox_MouseClick(object sender, EventArgs e)
        {
            ViewPictures(GetSelectedPictures());
        }

        private List<string> pictures;

        private Button btnLeft;
        private Button btnRight;

        private PictureBox pictureBox;

        private ToolStripMenuItem defaultMode;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
