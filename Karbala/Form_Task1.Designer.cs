namespace Karbala
{
    partial class Form_Task1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            butDrawPixel = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            but_Exit = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(838, 604);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // butDrawPixel
            // 
            butDrawPixel.Dock = DockStyle.Fill;
            butDrawPixel.Location = new Point(0, 0);
            butDrawPixel.Name = "butDrawPixel";
            butDrawPixel.Size = new Size(179, 50);
            butDrawPixel.TabIndex = 1;
            butDrawPixel.Text = "Draw Pixel";
            butDrawPixel.UseVisualStyleBackColor = true;
            butDrawPixel.Click += butDrawPixel_Click;
            butDrawPixel.MouseMove += butDrawPixel_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 62);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "MouseMove:";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 604);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(but_Exit);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(659, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 604);
            panel2.TabIndex = 1;
            // 
            // but_Exit
            // 
            but_Exit.Location = new Point(69, 439);
            but_Exit.Name = "but_Exit";
            but_Exit.Size = new Size(75, 23);
            but_Exit.TabIndex = 1;
            but_Exit.Text = "Exit";
            but_Exit.UseVisualStyleBackColor = true;
            but_Exit.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(butDrawPixel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 50);
            panel3.TabIndex = 4;
            // 
            // Form_Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 604);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_Task1";
            Text = "Task 1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button butDrawPixel;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button but_Exit;
    }
}
