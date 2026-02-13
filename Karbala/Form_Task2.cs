using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks; // Add this at the top if not already present
using System.Windows.Forms;

namespace Karbala
{
    public partial class Form_Task2 : Form
    {
        Color selectedColor = Color.Red; // اللون الافتراضي
        bool isDrawing = false;




        public Form_Task2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // بدلاً من رقم ثابت مثل 400
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            int x = 10, y = 10;

            for (int i = 0; i < 100; i = i + 2)
                bmp.SetPixel(x + i, y, Color.Red);

            for (int i = 0; i < 100; i++)
                bmp.SetPixel(x, y + i, Color.Green);

            for (int i = 0; i < 100; i++)
                bmp.SetPixel(x + i, y + i, Color.Blue);

            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 50; j++)
                    bmp.SetPixel(x + 100 + i, y + 100 + j, Color.Aquamarine);

            for (int i = 0; i < bmp.Width; i++)
            {
                bmp.SetPixel(i, 0, Color.Black);                // الضلع العلوي
                bmp.SetPixel(i, bmp.Height - 1, Color.Black);
            }

            for (int i = 0; i < bmp.Height; i++)
            {
                bmp.SetPixel(0, i, Color.Black);                // الضلع الأيسر
                bmp.SetPixel(bmp.Width - 1, i, Color.Black);
            }

            pictureBox1.Image = bmp;

        }

        private void But_Exit_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var result = MessageBox.Show("هل أنت متأكد أنك تريد الخروج؟ سيتم فقدان أي رسم غير محفوظ.", "تأكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foreach (Form openForm in Application.OpenForms)
                    {
                        if (openForm is Form_Dashboard existingDashboard)
                        {
                            if (existingDashboard.WindowState == FormWindowState.Minimized)
                                existingDashboard.WindowState = FormWindowState.Normal;
                            existingDashboard.BringToFront();
                            existingDashboard.Activate();
                            Close();
                            return;
                        }
                    }
                    // No existing dashboard found — create one and close this form.
                    var dashboard = new Form_Dashboard();
                    dashboard.Show();
                    Close();
                }

            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Txt_Xposition.Text = e.X.ToString();
            Txt_Yposition.Text = e.Y.ToString();

            // الرسم المستمر فقط إذا كان المستخدم ضاغطاً على الماوس
            if (isDrawing)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image ?? new Bitmap(pictureBox1.Width, pictureBox1.Height);

                // حجم الفرشاة (3x3 بكسل) لزيادة الوضوح [cite: 74]
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        int drawX = e.X + i;
                        int drawY = e.Y + j;

                        // حماية من الخطأ الذي واجهته سابقاً (ArgumentOutOfRangeException)
                        if (drawX >= 0 && drawX < bmp.Width && drawY >= 0 && drawY < bmp.Height)
                        {
                            bmp.SetPixel(drawX, drawY, selectedColor); // الرسم باللون المختار [cite: 11, 51]
                        }
                    }
                }
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void But_Clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Refresh(); // Refresh the PictureBox to ensure it updates visually
            pictureBox1.Invalidate(); // Force the PictureBox to repaint and clear the image


        }

        private void Btn_SelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private async void But_Save_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                string filePath = $"Drawing_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                await Task.Run(() => pictureBox1.Image.Save(filePath));
                MessageBox.Show($"تم حفظ الرسم في: {filePath}", "حفظ الرسم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لا يوجد رسم لحفظه.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
