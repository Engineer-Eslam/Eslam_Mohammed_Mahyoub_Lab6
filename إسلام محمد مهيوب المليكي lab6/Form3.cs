using System;
using System.Drawing;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;  
            openFileDialog1.Filter = "Image Files|*.jpg;*.png";  
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                PathLabel.Text = openFileDialog1.FileName;
                //طريقه أخرى
                //string filePath = openFileDialog1.FileName;  
                //PathLabel.Text = filePath;  
                //Bitmap bitmap = new Bitmap(filePath); 
                //pictureBox1.Image = bitmap;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Close();
        }

    }
}
