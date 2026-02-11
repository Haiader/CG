using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Karbala
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void task1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // If a Form_Task1 instance is already open, activate it instead of opening a new one.
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is Form_Task1 existing)
                {
                    if (existing.WindowState == FormWindowState.Minimized)
                        existing.WindowState = FormWindowState.Normal;

                    existing.BringToFront();
                    existing.Activate();
                    return;
                }
            }

            // Otherwise create and show a new instance (non-modal).
            var task1 = new Form_Task1();
            task1.Show();
        }

        private void TSM_Tasks_Average_Task1_Click(object sender, EventArgs e)
        {
            // If a Form_Task1 instance is already open, activate it instead of opening a new one.
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is Form_Task1 existing)
                {
                    if (existing.WindowState == FormWindowState.Minimized)
                        existing.WindowState = FormWindowState.Normal;

                    existing.BringToFront();
                    existing.Activate();
                    return;
                }
            }

            // Otherwise create and show a new instance (non-modal).
            var task1 = new Form_Task1();
            task1.Show();
        }
    }
}
