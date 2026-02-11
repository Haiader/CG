global using System.Drawing;
namespace Karbala
{
    public partial class Form_Task1 : Form
    {
        public Form_Task1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(400, 400);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void butDrawPixel_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(400, 400);

            int x = 10, y = 10;
            int a = 0, b = 0;

            for (int i = 0; i < 100; i = i + 2)
                bmp.SetPixel(x + i, y, Color.Red);

            for (int i = 0; i < 100; i++)
                bmp.SetPixel(x, y + i, Color.Green);

            for (int i = 0; i < 100; i++)
                bmp.SetPixel(x + i, y + i, Color.Blue);

            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 50; j++)
                    bmp.SetPixel(x + 100 + i, y + 100 + j, Color.Aquamarine);

            for (int i = 0; i < 400; i++)
            {
                bmp.SetPixel(a + i, b, Color.Black);// Right Line
                bmp.SetPixel(a + i, b + 399, Color.Black);
                bmp.SetPixel(a, b + i, Color.Black); // 
                bmp.SetPixel(a + 399, b + i, Color.Black);

            }

            pictureBox1.Image = bmp;
        }

        private void butDrawPixel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If a dashboard instance is already open, bring it to front and close this form.
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
