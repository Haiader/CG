namespace Karbala
{
    partial class Form_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tasksToolStripMenuItem = new ToolStripMenuItem();
            TSM_Tasks_Average = new ToolStripMenuItem();
            TSM_Tasks_Average_Task1 = new ToolStripMenuItem();
            TSM_Tasks_Advanced = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tasksToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tasksToolStripMenuItem
            // 
            tasksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TSM_Tasks_Average, TSM_Tasks_Advanced });
            tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            tasksToolStripMenuItem.Size = new Size(46, 20);
            tasksToolStripMenuItem.Text = "Tasks";
            // 
            // TSM_Tasks_Average
            // 
            TSM_Tasks_Average.DropDownItems.AddRange(new ToolStripItem[] { TSM_Tasks_Average_Task1 });
            TSM_Tasks_Average.Name = "TSM_Tasks_Average";
            TSM_Tasks_Average.Size = new Size(180, 22);
            TSM_Tasks_Average.Text = "Average";
            // 
            // TSM_Tasks_Average_Task1
            // 
            TSM_Tasks_Average_Task1.Name = "TSM_Tasks_Average_Task1";
            TSM_Tasks_Average_Task1.Size = new Size(180, 22);
            TSM_Tasks_Average_Task1.Text = "Task 1";
            TSM_Tasks_Average_Task1.Click += TSM_Tasks_Average_Task1_Click;
            // 
            // TSM_Tasks_Advanced
            // 
            TSM_Tasks_Advanced.Name = "TSM_Tasks_Advanced";
            TSM_Tasks_Advanced.Size = new Size(180, 22);
            TSM_Tasks_Advanced.Text = "Advanced";
            // 
            // Form_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tasksToolStripMenuItem;
        private ToolStripMenuItem task1ToolStripMenuItem;
        private ToolStripMenuItem task1ToolStripMenuItem1;
        private ToolStripMenuItem TSM_Tasks_Average;
        private ToolStripMenuItem TSM_Tasks_Average_Task1;
        private ToolStripMenuItem TSM_Tasks_Advanced;
    }
}