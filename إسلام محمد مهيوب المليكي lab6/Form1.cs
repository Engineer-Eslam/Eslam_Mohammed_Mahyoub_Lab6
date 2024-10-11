using System;
using System.Drawing;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height = 300;
            ClearImageBtn.Top = pictureBox1.Top + pictureBox1.Height + 10;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.Red; 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Image.FromFile(@"../../images1.jpg");
            pictureBox1.BackgroundImage = Image.FromFile(@"../../images2.jpeg");
            toolTip1.SetToolTip(pictureBox1, " صورةجامعة اب");
            this.AutoSize = true;
        }

        private void ClearImageBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
