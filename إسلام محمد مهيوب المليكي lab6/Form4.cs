using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Bitmap picBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Bitmap formBitmap = new Bitmap(this.Width, this.Height);
            int squareSize = 100; // حجم المربع    
            int PicX = (pictureBox1.Width - squareSize) / 2, PicY = (pictureBox1.Height - squareSize) / 2; // نقطة البداية للمربع الخاص بأداة pictureBox1
            int formX = pictureBox1.Left + pictureBox1.Width + 50, formY = (pictureBox1.Top + PicY); // نقطة البداية للمربع الخاص ب Form
            
                         //  طريقة أخرى 
                         //رسم المربع على pictureBox1
            //for (int x = PicX; x < PicX + squareSize; x++)
            //{
            //    for (int y = PicY; y < PicY + squareSize; y++)
            //    {
            //        if (x == PicX || x == PicX + squareSize - 1 || y == PicY || y == PicY + squareSize - 1)
            //        {
            //            picBitmap.SetPixel(x, y, Color.Red);
            //        }
            //    }
            //}
            //            //رسم المربع على form
            //for (int x = formX; x < formX + squareSize; x++)
            //{
            //    for (int y = formY; y < formY + squareSize; y++)
            //    {
            //        if (x == formX || x == formX + squareSize - 1 || y == formY || y == formY + squareSize - 1)
            //        {
            //            formBitmap.SetPixel(x, y, Color.Red); 
            //        }
            //    }
            //}
 
            for (int i = 0; i < squareSize; i++)
            {
                          // رسم المربع على pictureBox1
                picBitmap.SetPixel(i + PicX, PicY, Color.Red); //الحد الأعلى
                picBitmap.SetPixel(PicX, i + PicY, Color.Red); //الحد الشمال
                picBitmap.SetPixel(i + PicX, PicY + squareSize, Color.Red); //الحد الأسفل
                picBitmap.SetPixel(PicX + squareSize, i + PicY, Color.Red); //الحد اليمين
                          // رسم المربع على form
                formBitmap.SetPixel(i + formX, formY, Color.Red); //الحد الأعلى
                formBitmap.SetPixel(formX, i + formY, Color.Red); //الحد الشمال
                formBitmap.SetPixel(i + formX, formY + squareSize, Color.Red); //الحد الأسفل
                formBitmap.SetPixel(formX + squareSize, i + formY, Color.Red); //الحد اليمين
            }

            pictureBox1.Image = picBitmap;  //رسم المربع على pictureBox1
            this.BackgroundImage = formBitmap;  //رسم المربع على form
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
