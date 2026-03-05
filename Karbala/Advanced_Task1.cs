using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karbala
{
    public partial class Advanced_Task1 : Form
    {
        Color selectedColor = Color.Red;
        bool isDrawing = false;

        // Tracks previous mouse point for continuous line drawing
        private Point previousPoint;
        private bool hasPreviousPoint = false;

        public Advanced_Task1()
        {
            InitializeComponent();

            // Make PictureBox fill the form smoothly and show a clear border
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BackColor = Color.White;
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

            // Make the form start maximized and reduce flicker
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            // Ensure initial bitmap matches the PictureBox size
            if (pictureBox1.Width > 0 && pictureBox1.Height > 0 && pictureBox1.Image == null)
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Handle resizing to grow the bitmap smoothly and keep existing drawing
            this.Resize += Advanced_Task1_Resize;
        }

        // When the form (or pictureBox) resizes, create a larger bitmap and copy existing content.
        private void Advanced_Task1_Resize(object? sender, EventArgs e)
        {
            if (pictureBox1.Width <= 0 || pictureBox1.Height <= 0) return;

            var oldBmp = pictureBox1.Image as Bitmap;
            // If no existing bitmap, just create a new one sized to the pictureBox
            if (oldBmp == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                return;
            }

            // If size didn't change to larger, no need to replace (keeps existing resolution)
            if (oldBmp.Width >= pictureBox1.Width && oldBmp.Height >= pictureBox1.Height)
                return;

            var newBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(newBmp))
            {
                g.Clear(Color.White);
                // Draw existing content at top-left (preserves drawing). Use high quality for smooth scaling if needed.
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImageUnscaled(oldBmp, 0, 0);
            }

            // Replace image and dispose old bitmap to free memory
            pictureBox1.Image = newBmp;
            oldBmp.Dispose();
        }

        // ✅ Draw triangle button (example)
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Triangle like /|  (right angle at bottom-right)
            int Ax = 250, Ay = 300;    // top-right
            int Bx = 250, By = 200;   // bottom-right
            int Cx = 150, Cy = 200;   // bottom-left

            RunDDA(Ax, Ay, Bx, By, Color.Green, bmp); // |
            RunDDA(Cx, Cy, Bx, By, Color.Green, bmp); // _
            RunDDA(Cx, Cy, Ax, Ay, Color.Green, bmp); // /

            pictureBox1.Image = bmp;
        }

        // ✅ DDA Line with optional thickness
        void RunDDA(int x1, int y1, int x2, int y2, Color color, Bitmap bmp, int thickness = 1)
        {
            float dx = x2 - x1;
            float dy = y2 - y1;

            float steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            if (steps == 0)
            {
                // draw single pixel with thickness
                DrawThickPixel(bmp, x1, y1, color, thickness);
                return;
            }

            float xInc = dx / steps;
            float yInc = dy / steps;

            float x = x1;
            float y = y1;

            for (int i = 0; i <= steps; i++)
            {
                int px = (int)Math.Round(x);
                int py = (int)Math.Round(y);

                // حماية من الخروج عن حدود الصورة
                if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                    DrawThickPixel(bmp, px, py, color, thickness);

                x += xInc;
                y += yInc;
            }
        }

        // Helper to draw a square brush centered at (x,y)
        private void DrawThickPixel(Bitmap bmp, int x, int y, Color color, int thickness)
        {
            int half = thickness / 2;
            for (int ix = -half; ix <= half; ix++)
            {
                for (int iy = -half; iy <= half; iy++)
                {
                    int tx = x + ix;
                    int ty = y + iy;
                    if (tx >= 0 && tx < bmp.Width && ty >= 0 && ty < bmp.Height)
                        bmp.SetPixel(tx, ty, color);
                }
            }
        }

        // ✅ Mouse move drawing using RunDDA for continuous lines
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Txt_Xposition.Text = e.X.ToString();
            Txt_Yposition.Text = e.Y.ToString();

            if (!isDrawing) return;

            // Ensure we have a bitmap to draw on
            Bitmap bmp = (Bitmap)pictureBox1.Image ?? new Bitmap(pictureBox1.Width, pictureBox1.Height);

            if (hasPreviousPoint)
            {
                // Use RunDDA to draw a line between previousPoint and current mouse point.
                // thickness here controls brush size (1 = single pixel, 3 = 3x3, etc.)
                RunDDA(previousPoint.X, previousPoint.Y, e.X, e.Y, selectedColor, bmp, thickness: 3);
            }
            else
            {
                // No previous point: draw a small dot so drawing starts immediately
                DrawThickPixel(bmp, e.X, e.Y, selectedColor, thickness: 3);
            }

            pictureBox1.Image = bmp;

            // Update previous point for next segment
            previousPoint = e.Location;
            hasPreviousPoint = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
            hasPreviousPoint = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            hasPreviousPoint = false;
        }

        // ✅ Clear
        private void But_Clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        // ✅ Select Color
        private void Btn_SelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                selectedColor = colorDialog1.Color;
        }

        // ✅ Save
        private async void But_Save_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("لا يوجد رسم لحفظه.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = $"Drawing_{DateTime.Now:yyyyMMdd_HHmmss}.png";
            await Task.Run(() => pictureBox1.Image.Save(filePath));

            MessageBox.Show($"تم حفظ الرسم في: {filePath}", "حفظ الرسم", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // ✅ Exit
        private void But_Exit_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var result = MessageBox.Show(
                    "هل أنت متأكد أنك تريد الخروج؟ سيتم فقدان أي رسم غير محفوظ.",
                    "تأكيد الخروج",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes) return;
            }

            // رجوع للداشبورد
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

            var dashboard = new Form_Dashboard();
            dashboard.Show();
            Close();
        }
    }
}
