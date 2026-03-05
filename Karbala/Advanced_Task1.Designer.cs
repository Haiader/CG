namespace Karbala
{
    partial class Advanced_Task1
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
            panel1 = new Panel();
            panel5 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Txt_Xposition = new TextBox();
            Lab_Xposition = new Label();
            Lab_Yposition = new Label();
            Txt_Yposition = new TextBox();
            Btn_SelectColor = new Button();
            But_Clear = new Button();
            panel4 = new Panel();
            But_Save = new Button();
            But_Exit = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 250);
            panel5.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(Txt_Xposition, 1, 0);
            tableLayoutPanel1.Controls.Add(Lab_Xposition, 0, 0);
            tableLayoutPanel1.Controls.Add(Lab_Yposition, 3, 0);
            tableLayoutPanel1.Controls.Add(Txt_Yposition, 4, 0);
            tableLayoutPanel1.Controls.Add(Btn_SelectColor, 0, 1);
            tableLayoutPanel1.Controls.Add(But_Clear, 4, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2588654F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.91038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.83076F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 250);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Txt_Xposition
            // 
            Txt_Xposition.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(Txt_Xposition, 2);
            Txt_Xposition.Location = new Point(36, 5);
            Txt_Xposition.Name = "Txt_Xposition";
            Txt_Xposition.ReadOnly = true;
            Txt_Xposition.RightToLeft = RightToLeft.No;
            Txt_Xposition.Size = new Size(60, 23);
            Txt_Xposition.TabIndex = 5;
            // 
            // Lab_Xposition
            // 
            Lab_Xposition.Anchor = AnchorStyles.None;
            Lab_Xposition.AutoSize = true;
            Lab_Xposition.Location = new Point(9, 9);
            Lab_Xposition.Name = "Lab_Xposition";
            Lab_Xposition.Size = new Size(14, 15);
            Lab_Xposition.TabIndex = 0;
            Lab_Xposition.Text = "X";
            Lab_Xposition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lab_Yposition
            // 
            Lab_Yposition.Anchor = AnchorStyles.None;
            Lab_Yposition.AutoSize = true;
            Lab_Yposition.Location = new Point(108, 9);
            Lab_Yposition.Name = "Lab_Yposition";
            Lab_Yposition.Size = new Size(14, 15);
            Lab_Yposition.TabIndex = 2;
            Lab_Yposition.Text = "Y";
            Lab_Yposition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Yposition
            // 
            Txt_Yposition.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(Txt_Yposition, 2);
            Txt_Yposition.Location = new Point(135, 5);
            Txt_Yposition.Name = "Txt_Yposition";
            Txt_Yposition.ReadOnly = true;
            Txt_Yposition.RightToLeft = RightToLeft.No;
            Txt_Yposition.Size = new Size(62, 23);
            Txt_Yposition.TabIndex = 3;
            // 
            // Btn_SelectColor
            // 
            tableLayoutPanel1.SetColumnSpan(Btn_SelectColor, 3);
            Btn_SelectColor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_SelectColor.Location = new Point(3, 36);
            Btn_SelectColor.Name = "Btn_SelectColor";
            Btn_SelectColor.Padding = new Padding(2);
            Btn_SelectColor.Size = new Size(93, 31);
            Btn_SelectColor.TabIndex = 7;
            Btn_SelectColor.Tag = "1";
            Btn_SelectColor.Text = "Select Color";
            Btn_SelectColor.UseVisualStyleBackColor = true;
            Btn_SelectColor.Click += Btn_SelectColor_Click;
            // 
            // But_Clear
            // 
            tableLayoutPanel1.SetColumnSpan(But_Clear, 2);
            But_Clear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            But_Clear.Location = new Point(135, 210);
            But_Clear.Name = "But_Clear";
            But_Clear.Padding = new Padding(2);
            But_Clear.Size = new Size(60, 31);
            But_Clear.TabIndex = 6;
            But_Clear.Tag = "1";
            But_Clear.Text = "Clear";
            But_Clear.UseVisualStyleBackColor = true;
            But_Clear.Click += But_Clear_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 350);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 0;
            // 
            // But_Save
            // 
            But_Save.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            But_Save.Location = new Point(478, 15);
            But_Save.Name = "But_Save";
            But_Save.Padding = new Padding(2);
            But_Save.Size = new Size(93, 31);
            But_Save.TabIndex = 8;
            But_Save.Tag = "1";
            But_Save.Text = "Save";
            But_Save.UseVisualStyleBackColor = true;
            But_Save.Click += But_Save_Click;
            // 
            // But_Exit
            // 
            But_Exit.Anchor = AnchorStyles.None;
            But_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            But_Exit.Location = new Point(412, 15);
            But_Exit.Name = "But_Exit";
            But_Exit.Padding = new Padding(2);
            But_Exit.Size = new Size(60, 31);
            But_Exit.TabIndex = 4;
            But_Exit.Tag = "1";
            But_Exit.Text = "Exit";
            But_Exit.UseVisualStyleBackColor = true;
            But_Exit.Click += But_Exit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.InactiveCaption;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(200, 100);
            button1.TabIndex = 5;
            button1.Tag = "1";
            button1.Text = "Draw Pixel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 450);
            panel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(But_Save);
            panel7.Controls.Add(But_Exit);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 350);
            panel7.Name = "panel7";
            panel7.Size = new Size(600, 100);
            panel7.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(600, 350);
            panel6.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Advanced_Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Advanced_Task1";
            Tag = "main";
            Text = "Advanced Task1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel7;
        private Panel panel6;
        private Label Lab_Xposition;
        private Label Lab_Yposition;
        private TextBox Txt_Yposition;
        private Button But_Exit;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox Txt_Xposition;
        private Button But_Clear;
        private ColorDialog colorDialog1;
        private Button Btn_SelectColor;
        private Button But_Save;
    }
}