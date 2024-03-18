
namespace Parking_Monitoring_System
{
    partial class MainMenuForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            panel1 = new Panel();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tmrTimer = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label5 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 815);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(16, 674);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 7;
            label4.Text = "TRANSACTION HISTORY";
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(12, 534);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(186, 138);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(67, 435);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 5;
            label3.Text = "PARKING";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 295);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(186, 138);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(9, 159);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 3;
            label2.Text = "TIME";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(8, 64);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 2;
            label1.Text = "DATE";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 17F);
            textBox2.Location = new Point(9, 183);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 38);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 17F);
            textBox1.Location = new Point(9, 89);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 38);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tmrTimer
            // 
            tmrTimer.Interval = 1000;
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Location = new Point(412, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 245);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Location = new Point(358, 198);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 11);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(508, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 245);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Yellow;
            panel5.Location = new Point(697, 89);
            panel5.Name = "panel5";
            panel5.Size = new Size(11, 245);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Location = new Point(788, 89);
            panel6.Name = "panel6";
            panel6.Size = new Size(11, 245);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Yellow;
            panel7.Location = new Point(885, 89);
            panel7.Name = "panel7";
            panel7.Size = new Size(11, 245);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Yellow;
            panel8.Location = new Point(605, 89);
            panel8.Name = "panel8";
            panel8.Size = new Size(11, 245);
            panel8.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(249, 47);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 5;
            label5.Text = "FLOOR 1";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Yellow;
            panel9.Location = new Point(605, 502);
            panel9.Name = "panel9";
            panel9.Size = new Size(11, 245);
            panel9.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Yellow;
            panel10.Location = new Point(885, 502);
            panel10.Name = "panel10";
            panel10.Size = new Size(11, 245);
            panel10.TabIndex = 7;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Yellow;
            panel11.Location = new Point(788, 502);
            panel11.Name = "panel11";
            panel11.Size = new Size(11, 245);
            panel11.TabIndex = 8;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Yellow;
            panel12.Location = new Point(697, 502);
            panel12.Name = "panel12";
            panel12.Size = new Size(11, 245);
            panel12.TabIndex = 9;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Yellow;
            panel13.Location = new Point(508, 502);
            panel13.Name = "panel13";
            panel13.Size = new Size(11, 245);
            panel13.TabIndex = 10;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Yellow;
            panel14.Location = new Point(358, 611);
            panel14.Name = "panel14";
            panel14.Size = new Size(590, 11);
            panel14.TabIndex = 11;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Yellow;
            panel15.Location = new Point(412, 502);
            panel15.Name = "panel15";
            panel15.Size = new Size(11, 245);
            panel15.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(249, 454);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 12;
            label6.Text = "FLOOR 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(447, 176);
            label7.Name = "label7";
            label7.Size = new Size(41, 19);
            label7.TabIndex = 13;
            label7.Text = "Lot 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(544, 176);
            label8.Name = "label8";
            label8.Size = new Size(41, 19);
            label8.TabIndex = 14;
            label8.Text = "Lot 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(637, 176);
            label9.Name = "label9";
            label9.Size = new Size(41, 19);
            label9.TabIndex = 15;
            label9.Text = "Lot 3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(729, 176);
            label10.Name = "label10";
            label10.Size = new Size(41, 19);
            label10.TabIndex = 16;
            label10.Text = "Lot 4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(823, 176);
            label11.Name = "label11";
            label11.Size = new Size(41, 19);
            label11.TabIndex = 17;
            label11.Text = "Lot 5";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(820, 212);
            label12.Name = "label12";
            label12.Size = new Size(49, 19);
            label12.TabIndex = 22;
            label12.Text = "Lot 10";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(729, 212);
            label13.Name = "label13";
            label13.Size = new Size(41, 19);
            label13.TabIndex = 21;
            label13.Text = "Lot 9";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(637, 212);
            label14.Name = "label14";
            label14.Size = new Size(41, 19);
            label14.TabIndex = 20;
            label14.Text = "Lot 8";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(544, 212);
            label15.Name = "label15";
            label15.Size = new Size(41, 19);
            label15.TabIndex = 19;
            label15.Text = "Lot 7";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(447, 212);
            label16.Name = "label16";
            label16.Size = new Size(41, 19);
            label16.TabIndex = 18;
            label16.Text = "Lot 6";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F);
            label17.Location = new Point(819, 625);
            label17.Name = "label17";
            label17.Size = new Size(49, 19);
            label17.TabIndex = 32;
            label17.Text = "Lot 10";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F);
            label18.Location = new Point(729, 625);
            label18.Name = "label18";
            label18.Size = new Size(41, 19);
            label18.TabIndex = 31;
            label18.Text = "Lot 9";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F);
            label19.Location = new Point(637, 625);
            label19.Name = "label19";
            label19.Size = new Size(41, 19);
            label19.TabIndex = 30;
            label19.Text = "Lot 8";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.Location = new Point(544, 625);
            label20.Name = "label20";
            label20.Size = new Size(41, 19);
            label20.TabIndex = 29;
            label20.Text = "Lot 7";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(447, 625);
            label21.Name = "label21";
            label21.Size = new Size(41, 19);
            label21.TabIndex = 28;
            label21.Text = "Lot 6";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F);
            label22.Location = new Point(823, 589);
            label22.Name = "label22";
            label22.Size = new Size(41, 19);
            label22.TabIndex = 27;
            label22.Text = "Lot 5";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F);
            label23.Location = new Point(729, 589);
            label23.Name = "label23";
            label23.Size = new Size(41, 19);
            label23.TabIndex = 26;
            label23.Text = "Lot 4";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F);
            label24.Location = new Point(637, 589);
            label24.Name = "label24";
            label24.Size = new Size(41, 19);
            label24.TabIndex = 25;
            label24.Text = "Lot 3";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10F);
            label25.Location = new Point(544, 589);
            label25.Name = "label25";
            label25.Size = new Size(41, 19);
            label25.TabIndex = 24;
            label25.Text = "Lot 2";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F);
            label26.Location = new Point(447, 589);
            label26.Name = "label26";
            label26.Size = new Size(41, 19);
            label26.TabIndex = 23;
            label26.Text = "Lot 1";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1116, 815);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel9);
            Controls.Add(label5);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel11);
            Controls.Add(panel7);
            Controls.Add(panel12);
            Controls.Add(panel6);
            Controls.Add(panel13);
            Controls.Add(panel5);
            Controls.Add(panel14);
            Controls.Add(panel15);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            Load += MainMenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private System.Windows.Forms.Timer tmrTimer;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label5;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
    }
}
