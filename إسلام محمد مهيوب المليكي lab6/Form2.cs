using System;
using System.Drawing;
using System.Windows.Forms;

namespace إسلام_محمد_مهيوب_المليكي_lab6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            textBoxPath.Focus();
        }

        private void BtnViewImage_Click(object sender, EventArgs e)
        {
            if (textBoxPath.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء إدخال مسار الصورة المراد عرضها ", "Error");
                textBoxPath.Focus();
                return;
            }
            try
            {
                //String path = textBoxPath.Text.Trim();
                //Bitmap obimage = new Bitmap(path);
                //pictureBox1.Image = obimage;
                pictureBox1.Image = Image.FromFile(@textBoxPath.Text.Trim());
                textBoxPath.ReadOnly = true;
            }
            catch (Exception ex)
            {
                // عرض رسالة خطأ في حال لم يتم العثور على الصورة
                MessageBox.Show(ex.Message+" : خطأ الصورة غير موجودة في هذا المسار " ,"Error");
                textBoxPath.Text = "";
                textBoxPath.Focus();
            }
        }

        private void ClearImageBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBoxPath.ReadOnly = false;
            textBoxPath.Text = "";
            textBoxPath.Focus();
        }

    }
}
