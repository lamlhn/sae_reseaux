namespace cidr_cal
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnCalcul = new Button();
            txtOct1 = new TextBox();
            label1 = new Label();
            txtCidr = new TextBox();
            txtOct2 = new TextBox();
            txtOct4 = new TextBox();
            txtOct3 = new TextBox();
            txtOctCp4 = new TextBox();
            txtOctCp3 = new TextBox();
            txtOctCp2 = new TextBox();
            txtOctCp1 = new TextBox();
            txtCidrOct4 = new TextBox();
            txtCidrOct3 = new TextBox();
            txtCidrOct2 = new TextBox();
            txtCidrOct1 = new TextBox();
            txtClass = new TextBox();
            txtOctNet1 = new TextBox();
            txtOctBroad1 = new TextBox();
            txtPreIp1 = new TextBox();
            txtDerIp1 = new TextBox();
            txtNbMachine = new TextBox();
            txtNbIp = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDerIp2 = new TextBox();
            txtPreIp2 = new TextBox();
            txtOctBroad2 = new TextBox();
            txtOctNet2 = new TextBox();
            txtDerIp3 = new TextBox();
            txtPreIp3 = new TextBox();
            txtOctBroad3 = new TextBox();
            txtOctNet3 = new TextBox();
            txtDerIp4 = new TextBox();
            txtPreIp4 = new TextBox();
            txtOctBroad4 = new TextBox();
            txtOctNet4 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(189, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 51);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(107, 7);
            radioButton2.MinimumSize = new Size(110, 40);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 40);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "BINAIRE";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(-1, 7);
            radioButton1.MinimumSize = new Size(110, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(110, 40);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "DECIMAL";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCalcul
            // 
            btnCalcul.Enabled = false;
            btnCalcul.Location = new Point(239, 305);
            btnCalcul.MinimumSize = new Size(110, 40);
            btnCalcul.Name = "btnCalcul";
            btnCalcul.Size = new Size(110, 40);
            btnCalcul.TabIndex = 17;
            btnCalcul.Text = "CALCULER";
            btnCalcul.UseVisualStyleBackColor = true;
            btnCalcul.Click += btnCalcul_Click;
            // 
            // txtOct1
            // 
            txtOct1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOct1.Location = new Point(28, 78);
            txtOct1.MinimumSize = new Size(110, 30);
            txtOct1.Name = "txtOct1";
            txtOct1.Size = new Size(110, 30);
            txtOct1.TabIndex = 1;
            txtOct1.TextAlign = HorizontalAlignment.Center;
            txtOct1.TextChanged += txtOctBinaire_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 168);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 9;
            label1.Text = "Masque d'Adresse";
            // 
            // txtCidr
            // 
            txtCidr.Enabled = false;
            txtCidr.Font = new Font("Segoe UI", 11.25F);
            txtCidr.Location = new Point(167, 204);
            txtCidr.MinimumSize = new Size(90, 30);
            txtCidr.Name = "txtCidr";
            txtCidr.Size = new Size(90, 30);
            txtCidr.TabIndex = 10;
            txtCidr.TextAlign = HorizontalAlignment.Center;
            txtCidr.TextChanged += txtCidr_TextChanged;
            // 
            // txtOct2
            // 
            txtOct2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOct2.Location = new Point(167, 78);
            txtOct2.MinimumSize = new Size(110, 30);
            txtOct2.Name = "txtOct2";
            txtOct2.Size = new Size(110, 30);
            txtOct2.TabIndex = 3;
            txtOct2.TextAlign = HorizontalAlignment.Center;
            txtOct2.TextChanged += txtOctBinaire_TextChanged;
            // 
            // txtOct4
            // 
            txtOct4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOct4.Location = new Point(448, 78);
            txtOct4.MinimumSize = new Size(110, 30);
            txtOct4.Name = "txtOct4";
            txtOct4.Size = new Size(110, 30);
            txtOct4.TabIndex = 7;
            txtOct4.TextAlign = HorizontalAlignment.Center;
            txtOct4.TextChanged += txtOctBinaire_TextChanged;
            // 
            // txtOct3
            // 
            txtOct3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOct3.Location = new Point(308, 78);
            txtOct3.MinimumSize = new Size(110, 30);
            txtOct3.Name = "txtOct3";
            txtOct3.Size = new Size(110, 30);
            txtOct3.TabIndex = 5;
            txtOct3.TextAlign = HorizontalAlignment.Center;
            txtOct3.TextChanged += txtOctBinaire_TextChanged;
            // 
            // txtOctCp4
            // 
            txtOctCp4.BackColor = SystemColors.ControlLight;
            txtOctCp4.Enabled = false;
            txtOctCp4.Font = new Font("Segoe UI", 11.25F);
            txtOctCp4.Location = new Point(448, 117);
            txtOctCp4.MinimumSize = new Size(110, 30);
            txtOctCp4.Name = "txtOctCp4";
            txtOctCp4.Size = new Size(110, 30);
            txtOctCp4.TabIndex = 8;
            txtOctCp4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctCp3
            // 
            txtOctCp3.BackColor = SystemColors.ControlLight;
            txtOctCp3.Enabled = false;
            txtOctCp3.Font = new Font("Segoe UI", 11.25F);
            txtOctCp3.Location = new Point(308, 117);
            txtOctCp3.MinimumSize = new Size(110, 30);
            txtOctCp3.Name = "txtOctCp3";
            txtOctCp3.Size = new Size(110, 30);
            txtOctCp3.TabIndex = 6;
            txtOctCp3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctCp2
            // 
            txtOctCp2.BackColor = SystemColors.ControlLight;
            txtOctCp2.Enabled = false;
            txtOctCp2.Font = new Font("Segoe UI", 11.25F);
            txtOctCp2.Location = new Point(167, 117);
            txtOctCp2.MinimumSize = new Size(110, 30);
            txtOctCp2.Name = "txtOctCp2";
            txtOctCp2.Size = new Size(110, 30);
            txtOctCp2.TabIndex = 4;
            txtOctCp2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctCp1
            // 
            txtOctCp1.BackColor = SystemColors.ControlLight;
            txtOctCp1.Enabled = false;
            txtOctCp1.Font = new Font("Segoe UI", 11.25F);
            txtOctCp1.Location = new Point(28, 117);
            txtOctCp1.MinimumSize = new Size(110, 30);
            txtOctCp1.Name = "txtOctCp1";
            txtOctCp1.Size = new Size(110, 30);
            txtOctCp1.TabIndex = 2;
            txtOctCp1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidrOct4
            // 
            txtCidrOct4.BackColor = SystemColors.ControlLight;
            txtCidrOct4.Enabled = false;
            txtCidrOct4.Font = new Font("Segoe UI", 11.25F);
            txtCidrOct4.Location = new Point(472, 244);
            txtCidrOct4.MinimumSize = new Size(90, 30);
            txtCidrOct4.Name = "txtCidrOct4";
            txtCidrOct4.ReadOnly = true;
            txtCidrOct4.Size = new Size(90, 30);
            txtCidrOct4.TabIndex = 16;
            txtCidrOct4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidrOct3
            // 
            txtCidrOct3.BackColor = SystemColors.ControlLight;
            txtCidrOct3.Enabled = false;
            txtCidrOct3.Font = new Font("Segoe UI", 11.25F);
            txtCidrOct3.Location = new Point(370, 244);
            txtCidrOct3.MinimumSize = new Size(90, 30);
            txtCidrOct3.Name = "txtCidrOct3";
            txtCidrOct3.ReadOnly = true;
            txtCidrOct3.Size = new Size(90, 30);
            txtCidrOct3.TabIndex = 15;
            txtCidrOct3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidrOct2
            // 
            txtCidrOct2.BackColor = SystemColors.ControlLight;
            txtCidrOct2.Enabled = false;
            txtCidrOct2.Font = new Font("Segoe UI", 11.25F);
            txtCidrOct2.Location = new Point(269, 244);
            txtCidrOct2.MinimumSize = new Size(90, 30);
            txtCidrOct2.Name = "txtCidrOct2";
            txtCidrOct2.ReadOnly = true;
            txtCidrOct2.Size = new Size(90, 30);
            txtCidrOct2.TabIndex = 14;
            txtCidrOct2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidrOct1
            // 
            txtCidrOct1.BackColor = SystemColors.ControlLight;
            txtCidrOct1.Enabled = false;
            txtCidrOct1.Font = new Font("Segoe UI", 11.25F);
            txtCidrOct1.Location = new Point(167, 244);
            txtCidrOct1.MinimumSize = new Size(90, 30);
            txtCidrOct1.Name = "txtCidrOct1";
            txtCidrOct1.ReadOnly = true;
            txtCidrOct1.Size = new Size(90, 30);
            txtCidrOct1.TabIndex = 13;
            txtCidrOct1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClass
            // 
            txtClass.BackColor = SystemColors.ControlLight;
            txtClass.Font = new Font("Segoe UI", 11.25F);
            txtClass.Location = new Point(167, 370);
            txtClass.MinimumSize = new Size(90, 30);
            txtClass.Name = "txtClass";
            txtClass.ReadOnly = true;
            txtClass.Size = new Size(90, 30);
            txtClass.TabIndex = 18;
            txtClass.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctNet1
            // 
            txtOctNet1.BackColor = SystemColors.GradientActiveCaption;
            txtOctNet1.Font = new Font("Segoe UI", 11.25F);
            txtOctNet1.Location = new Point(167, 407);
            txtOctNet1.MinimumSize = new Size(90, 30);
            txtOctNet1.Name = "txtOctNet1";
            txtOctNet1.ReadOnly = true;
            txtOctNet1.Size = new Size(90, 30);
            txtOctNet1.TabIndex = 21;
            txtOctNet1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctBroad1
            // 
            txtOctBroad1.BackColor = SystemColors.GradientActiveCaption;
            txtOctBroad1.Font = new Font("Segoe UI", 11.25F);
            txtOctBroad1.Location = new Point(167, 445);
            txtOctBroad1.MinimumSize = new Size(90, 30);
            txtOctBroad1.Name = "txtOctBroad1";
            txtOctBroad1.ReadOnly = true;
            txtOctBroad1.Size = new Size(90, 30);
            txtOctBroad1.TabIndex = 22;
            txtOctBroad1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPreIp1
            // 
            txtPreIp1.BackColor = Color.LightBlue;
            txtPreIp1.Font = new Font("Segoe UI", 11.25F);
            txtPreIp1.Location = new Point(167, 484);
            txtPreIp1.MinimumSize = new Size(90, 30);
            txtPreIp1.Name = "txtPreIp1";
            txtPreIp1.ReadOnly = true;
            txtPreIp1.Size = new Size(90, 30);
            txtPreIp1.TabIndex = 23;
            txtPreIp1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDerIp1
            // 
            txtDerIp1.BackColor = Color.LightBlue;
            txtDerIp1.Font = new Font("Segoe UI", 11.25F);
            txtDerIp1.Location = new Point(167, 522);
            txtDerIp1.MinimumSize = new Size(90, 30);
            txtDerIp1.Name = "txtDerIp1";
            txtDerIp1.ReadOnly = true;
            txtDerIp1.Size = new Size(90, 30);
            txtDerIp1.TabIndex = 24;
            txtDerIp1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNbMachine
            // 
            txtNbMachine.BackColor = SystemColors.ControlLight;
            txtNbMachine.Font = new Font("Segoe UI", 11.25F);
            txtNbMachine.Location = new Point(472, 563);
            txtNbMachine.MinimumSize = new Size(90, 30);
            txtNbMachine.Name = "txtNbMachine";
            txtNbMachine.ReadOnly = true;
            txtNbMachine.Size = new Size(90, 30);
            txtNbMachine.TabIndex = 38;
            txtNbMachine.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNbIp
            // 
            txtNbIp.BackColor = SystemColors.ControlLight;
            txtNbIp.Font = new Font("Segoe UI", 11.25F);
            txtNbIp.Location = new Point(167, 563);
            txtNbIp.MinimumSize = new Size(90, 30);
            txtNbIp.Name = "txtNbIp";
            txtNbIp.ReadOnly = true;
            txtNbIp.Size = new Size(90, 30);
            txtNbIp.TabIndex = 37;
            txtNbIp.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 214);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 11;
            label3.Text = "CIDR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 254);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 12;
            label2.Text = "Standard";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 380);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 19;
            label4.Text = "CLASSE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 417);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 20;
            label5.Text = "@ NET";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 455);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 39;
            label6.Text = "@ BROADCAST";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 494);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 40;
            label7.Text = "PREMIERE IP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 573);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 42;
            label8.Text = "NOMBRE IPs";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 532);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 41;
            label9.Text = "DERNIERE IP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(312, 573);
            label10.Name = "label10";
            label10.Size = new Size(156, 20);
            label10.TabIndex = 43;
            label10.Text = "NOMBRE MACHINES";
            // 
            // txtDerIp2
            // 
            txtDerIp2.BackColor = Color.LightBlue;
            txtDerIp2.Font = new Font("Segoe UI", 11.25F);
            txtDerIp2.Location = new Point(269, 522);
            txtDerIp2.MinimumSize = new Size(90, 30);
            txtDerIp2.Name = "txtDerIp2";
            txtDerIp2.ReadOnly = true;
            txtDerIp2.Size = new Size(90, 30);
            txtDerIp2.TabIndex = 28;
            txtDerIp2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPreIp2
            // 
            txtPreIp2.BackColor = Color.LightBlue;
            txtPreIp2.Font = new Font("Segoe UI", 11.25F);
            txtPreIp2.Location = new Point(269, 484);
            txtPreIp2.MinimumSize = new Size(90, 30);
            txtPreIp2.Name = "txtPreIp2";
            txtPreIp2.ReadOnly = true;
            txtPreIp2.Size = new Size(90, 30);
            txtPreIp2.TabIndex = 27;
            txtPreIp2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctBroad2
            // 
            txtOctBroad2.BackColor = SystemColors.GradientActiveCaption;
            txtOctBroad2.Font = new Font("Segoe UI", 11.25F);
            txtOctBroad2.Location = new Point(269, 445);
            txtOctBroad2.MinimumSize = new Size(90, 30);
            txtOctBroad2.Name = "txtOctBroad2";
            txtOctBroad2.ReadOnly = true;
            txtOctBroad2.Size = new Size(90, 30);
            txtOctBroad2.TabIndex = 26;
            txtOctBroad2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctNet2
            // 
            txtOctNet2.BackColor = SystemColors.GradientActiveCaption;
            txtOctNet2.Font = new Font("Segoe UI", 11.25F);
            txtOctNet2.Location = new Point(269, 407);
            txtOctNet2.MinimumSize = new Size(90, 30);
            txtOctNet2.Name = "txtOctNet2";
            txtOctNet2.ReadOnly = true;
            txtOctNet2.Size = new Size(90, 30);
            txtOctNet2.TabIndex = 25;
            txtOctNet2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDerIp3
            // 
            txtDerIp3.BackColor = Color.LightBlue;
            txtDerIp3.Font = new Font("Segoe UI", 11.25F);
            txtDerIp3.Location = new Point(370, 522);
            txtDerIp3.MinimumSize = new Size(90, 30);
            txtDerIp3.Name = "txtDerIp3";
            txtDerIp3.ReadOnly = true;
            txtDerIp3.Size = new Size(90, 30);
            txtDerIp3.TabIndex = 32;
            txtDerIp3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPreIp3
            // 
            txtPreIp3.BackColor = Color.LightBlue;
            txtPreIp3.Font = new Font("Segoe UI", 11.25F);
            txtPreIp3.Location = new Point(370, 484);
            txtPreIp3.MinimumSize = new Size(90, 30);
            txtPreIp3.Name = "txtPreIp3";
            txtPreIp3.ReadOnly = true;
            txtPreIp3.Size = new Size(90, 30);
            txtPreIp3.TabIndex = 31;
            txtPreIp3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctBroad3
            // 
            txtOctBroad3.BackColor = SystemColors.GradientActiveCaption;
            txtOctBroad3.Font = new Font("Segoe UI", 11.25F);
            txtOctBroad3.Location = new Point(370, 445);
            txtOctBroad3.MinimumSize = new Size(90, 30);
            txtOctBroad3.Name = "txtOctBroad3";
            txtOctBroad3.ReadOnly = true;
            txtOctBroad3.Size = new Size(90, 30);
            txtOctBroad3.TabIndex = 30;
            txtOctBroad3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctNet3
            // 
            txtOctNet3.BackColor = SystemColors.GradientActiveCaption;
            txtOctNet3.Font = new Font("Segoe UI", 11.25F);
            txtOctNet3.Location = new Point(370, 407);
            txtOctNet3.MinimumSize = new Size(90, 30);
            txtOctNet3.Name = "txtOctNet3";
            txtOctNet3.ReadOnly = true;
            txtOctNet3.Size = new Size(90, 30);
            txtOctNet3.TabIndex = 29;
            txtOctNet3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDerIp4
            // 
            txtDerIp4.BackColor = Color.LightBlue;
            txtDerIp4.Font = new Font("Segoe UI", 11.25F);
            txtDerIp4.Location = new Point(472, 522);
            txtDerIp4.MinimumSize = new Size(90, 30);
            txtDerIp4.Name = "txtDerIp4";
            txtDerIp4.ReadOnly = true;
            txtDerIp4.Size = new Size(90, 30);
            txtDerIp4.TabIndex = 36;
            txtDerIp4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPreIp4
            // 
            txtPreIp4.BackColor = Color.LightBlue;
            txtPreIp4.Font = new Font("Segoe UI", 11.25F);
            txtPreIp4.Location = new Point(472, 484);
            txtPreIp4.MinimumSize = new Size(90, 30);
            txtPreIp4.Name = "txtPreIp4";
            txtPreIp4.ReadOnly = true;
            txtPreIp4.Size = new Size(90, 30);
            txtPreIp4.TabIndex = 35;
            txtPreIp4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctBroad4
            // 
            txtOctBroad4.BackColor = SystemColors.GradientActiveCaption;
            txtOctBroad4.Font = new Font("Segoe UI", 11.25F);
            txtOctBroad4.Location = new Point(472, 445);
            txtOctBroad4.MinimumSize = new Size(90, 30);
            txtOctBroad4.Name = "txtOctBroad4";
            txtOctBroad4.ReadOnly = true;
            txtOctBroad4.Size = new Size(90, 30);
            txtOctBroad4.TabIndex = 34;
            txtOctBroad4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOctNet4
            // 
            txtOctNet4.BackColor = SystemColors.GradientActiveCaption;
            txtOctNet4.Font = new Font("Segoe UI", 11.25F);
            txtOctNet4.Location = new Point(472, 407);
            txtOctNet4.MinimumSize = new Size(90, 30);
            txtOctNet4.Name = "txtOctNet4";
            txtOctNet4.ReadOnly = true;
            txtOctNet4.Size = new Size(90, 30);
            txtOctNet4.TabIndex = 33;
            txtOctNet4.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 633);
            Controls.Add(txtDerIp4);
            Controls.Add(txtPreIp4);
            Controls.Add(txtOctBroad4);
            Controls.Add(txtOctNet4);
            Controls.Add(txtDerIp3);
            Controls.Add(txtPreIp3);
            Controls.Add(txtOctBroad3);
            Controls.Add(txtOctNet3);
            Controls.Add(txtDerIp2);
            Controls.Add(txtPreIp2);
            Controls.Add(txtOctBroad2);
            Controls.Add(txtOctNet2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtNbMachine);
            Controls.Add(txtNbIp);
            Controls.Add(txtDerIp1);
            Controls.Add(txtPreIp1);
            Controls.Add(txtOctBroad1);
            Controls.Add(txtOctNet1);
            Controls.Add(txtClass);
            Controls.Add(txtCidrOct4);
            Controls.Add(txtCidrOct3);
            Controls.Add(txtCidrOct2);
            Controls.Add(txtCidrOct1);
            Controls.Add(txtOctCp4);
            Controls.Add(txtOctCp3);
            Controls.Add(txtOctCp2);
            Controls.Add(txtOctCp1);
            Controls.Add(txtOct4);
            Controls.Add(txtOct3);
            Controls.Add(txtOct2);
            Controls.Add(txtCidr);
            Controls.Add(label1);
            Controls.Add(txtOct1);
            Controls.Add(btnCalcul);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Button btnCalcul;
        private TextBox txtOct1;
        private Label label1;
        private RadioButton radioButton2;
        private TextBox txtCidr;
        private TextBox txtOct2;
        private TextBox txtOct4;
        private TextBox txtOct3;
        private TextBox txtOctCp4;
        private TextBox txtOctCp3;
        private TextBox txtOctCp2;
        private TextBox txtOctCp1;
        private TextBox txtCidrOct4;
        private TextBox txtCidrOct3;
        private TextBox txtCidrOct2;
        private TextBox txtCidrOct1;
        private TextBox txtClass;
        private TextBox txtOctNet1;
        private TextBox txtOctBroad1;
        private TextBox txtPreIp1;
        private TextBox txtDerIp1;
        private TextBox txtNbMachine;
        private TextBox txtNbIp;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDerIp2;
        private TextBox txtPreIp2;
        private TextBox txtOctBroad2;
        private TextBox txtOctNet2;
        private TextBox txtDerIp3;
        private TextBox txtPreIp3;
        private TextBox txtOctBroad3;
        private TextBox txtOctNet3;
        private TextBox txtDerIp4;
        private TextBox txtPreIp4;
        private TextBox txtOctBroad4;
        private TextBox txtOctNet4;
    }
}
