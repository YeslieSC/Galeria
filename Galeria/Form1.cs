using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageGallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(file),
                        Width = 100,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Tag = file // Guardar la ruta de la imagen en la propiedad Tag
                    };
                    pictureBox.Click += PictureBox_Click; // Añadir evento de clic
                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
            }
        }
        private void btnAddImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(file),
                        Width = 100,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Tag = file // Guardar la ruta de la imagen en la propiedad Tag
                    };
                    pictureBox.Click += PictureBox_Click; // Añadir evento de clic
                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string filePath = pictureBox.Tag as string;

            Form imageForm = new Form
            {
                Text = Path.GetFileName(filePath),
                Width = 800,
                Height = 600
            };

            PictureBox largePictureBox = new PictureBox
            {
                Image = Image.FromFile(filePath),
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            imageForm.Controls.Add(largePictureBox);
            imageForm.ShowDialog();
        }
    }
}