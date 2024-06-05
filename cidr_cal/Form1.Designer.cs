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
            btnCalcul = new Button();
            txtOct1 = new TextBox();
            lblTitreMasque = new Label();
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
            lblCidr = new Label();
            lblStd = new Label();
            lblClasse = new Label();
            lblNet = new Label();
            lblBroadcast = new Label();
            lblPreIp = new Label();
            lblNbIps = new Label();
            lblDerIp = new Label();
            lblNbMachine = new Label();
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
            lblErrorCidr = new Label();
            rdoBin = new RadioButton();
            rdoDec = new RadioButton();
            groupBox1 = new GroupBox();
            pnlCidrStd = new Panel();
            groupBox1.SuspendLayout();
            pnlCidrStd.SuspendLayout();
            SuspendLayout();
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
            txtOct1.Leave += txtOctBinaire_Leave;
            // 
            // lblTitreMasque
            // 
            lblTitreMasque.AutoSize = true;
            lblTitreMasque.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitreMasque.Location = new Point(220, 168);
            lblTitreMasque.Name = "lblTitreMasque";
            lblTitreMasque.Size = new Size(174, 25);
            lblTitreMasque.TabIndex = 9;
            lblTitreMasque.Text = "Masque d'Adresse";
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
            txtCidr.Enter += txtCidr_Enter;
            txtCidr.Leave += txtCidr_Leave;
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
            txtOct2.Leave += txtOctBinaire_Leave;
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
            txtOct4.Leave += txtOctBinaire_Leave;
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
            txtOct3.Leave += txtOctBinaire_Leave;
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
            txtOctCp4.Leave += txtOctBinaire_Leave;
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
            txtOctCp3.Leave += txtOctBinaire_Leave;
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
            txtOctCp2.Leave += txtOctBinaire_Leave;
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
            txtOctCp1.Leave += txtOctBinaire_Leave;
            // 
            // txtCidrOct4
            // 
            txtCidrOct4.BackColor = SystemColors.Window;
            txtCidrOct4.Enabled = false;
            txtCidrOct4.Font = new Font("Segoe UI", 11.25F);
            txtCidrOct4.Location = new Point(305, 0);
            txtCidrOct4.MinimumSize = new Size(90, 30);
            txtCidrOct4.Name = "txtCidrOct4";
            txtCidrOct4.Size = new Size(90, 30);
            txtCidrOct4.TabIndex = 16;
            txtCidrOct4.TextAlign = HorizontalAlignment.Center;
            txtCidrOct4.TextChanged += txtCidrOct_TextChanged;
            txtCidrOct4.Enter += txtCidrOct_Enter;
            // 
            // txtCidrOct3
            // 
            txtCidrOct3.BackColor = SystemColors.Window;
            txtCidrOct3.Enabled = false;
            txtCidrOct3.Font = new Font("Segoe UI", 11.25F);
            txtCidrOct3.Location = new Point(203, 0);
            txtCidrOct3.MinimumSize = new Size(90, 30);
            txtCidrOct3.Name = "txtCidrOct3";
            txtCidrOct3.Size = new Size(90, 30);
            txtCidrOct3.TabIndex = 15;
            txtCidrOct3.TextAlign = HorizontalAlignment.Center;
            txtCidrOct3.TextChanged += txtCidrOct_TextChanged;
            txtCidrOct3.Enter += txtCidrOct_Enter;
            // 
            // txtCidrOct2
            // 
            txtCidrOct2.BackColor = SystemColors.Window;
            txtCidrOct2.Enabled = false;
            txtCidrOct2.Font = new Font("Segoe UI", 11.25F);
            txtCidrOct2.Location = new Point(102, 0);
            txtCidrOct2.MinimumSize = new Size(90, 30);
            txtCidrOct2.Name = "txtCidrOct2";
            txtCidrOct2.Size = new Size(90, 30);
            txtCidrOct2.TabIndex = 14;
            txtCidrOct2.TextAlign = HorizontalAlignment.Center;
            txtCidrOct2.TextChanged += txtCidrOct_TextChanged;
            txtCidrOct2.Enter += txtCidrOct_Enter;
            // 
            // txtCidrOct1
            // 
            txtCidrOct1.BackColor = SystemColors.Window;
            txtCidrOct1.Enabled = false;
            txtCidrOct1.Font = new Font("Segoe UI", 11.25F);
            txtCidrOct1.Location = new Point(0, 0);
            txtCidrOct1.MinimumSize = new Size(90, 30);
            txtCidrOct1.Name = "txtCidrOct1";
            txtCidrOct1.Size = new Size(90, 30);
            txtCidrOct1.TabIndex = 13;
            txtCidrOct1.TextAlign = HorizontalAlignment.Center;
            txtCidrOct1.TextChanged += txtCidrOct_TextChanged;
            txtCidrOct1.Enter += txtCidrOct_Enter;
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
            // lblCidr
            // 
            lblCidr.AutoSize = true;
            lblCidr.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCidr.Location = new Point(32, 210);
            lblCidr.Name = "lblCidr";
            lblCidr.Size = new Size(44, 20);
            lblCidr.TabIndex = 11;
            lblCidr.Text = "CIDR";
            // 
            // lblStd
            // 
            lblStd.AutoSize = true;
            lblStd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStd.Location = new Point(32, 250);
            lblStd.Name = "lblStd";
            lblStd.Size = new Size(72, 20);
            lblStd.TabIndex = 12;
            lblStd.Text = "Standard";
            // 
            // lblClasse
            // 
            lblClasse.AutoSize = true;
            lblClasse.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClasse.Location = new Point(32, 376);
            lblClasse.Name = "lblClasse";
            lblClasse.Size = new Size(61, 20);
            lblClasse.TabIndex = 19;
            lblClasse.Text = "CLASSE";
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNet.Location = new Point(32, 413);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(56, 20);
            lblNet.TabIndex = 20;
            lblNet.Text = "@ NET";
            // 
            // lblBroadcast
            // 
            lblBroadcast.AutoSize = true;
            lblBroadcast.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBroadcast.Location = new Point(32, 451);
            lblBroadcast.Name = "lblBroadcast";
            lblBroadcast.Size = new Size(117, 20);
            lblBroadcast.TabIndex = 39;
            lblBroadcast.Text = "@ BROADCAST";
            // 
            // lblPreIp
            // 
            lblPreIp.AutoSize = true;
            lblPreIp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreIp.Location = new Point(32, 490);
            lblPreIp.Name = "lblPreIp";
            lblPreIp.Size = new Size(99, 20);
            lblPreIp.TabIndex = 40;
            lblPreIp.Text = "PREMIERE IP";
            // 
            // lblNbIps
            // 
            lblNbIps.AutoSize = true;
            lblNbIps.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNbIps.Location = new Point(32, 569);
            lblNbIps.Name = "lblNbIps";
            lblNbIps.Size = new Size(99, 20);
            lblNbIps.TabIndex = 42;
            lblNbIps.Text = "NOMBRE IPs";
            // 
            // lblDerIp
            // 
            lblDerIp.AutoSize = true;
            lblDerIp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDerIp.Location = new Point(32, 528);
            lblDerIp.Name = "lblDerIp";
            lblDerIp.Size = new Size(99, 20);
            lblDerIp.TabIndex = 41;
            lblDerIp.Text = "DERNIERE IP";
            // 
            // lblNbMachine
            // 
            lblNbMachine.AutoSize = true;
            lblNbMachine.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNbMachine.Location = new Point(312, 569);
            lblNbMachine.Name = "lblNbMachine";
            lblNbMachine.Size = new Size(156, 20);
            lblNbMachine.TabIndex = 43;
            lblNbMachine.Text = "NOMBRE MACHINES";
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
            txtOctNet4.Location = new Point(466, 407);
            txtOctNet4.MinimumSize = new Size(90, 30);
            txtOctNet4.Name = "txtOctNet4";
            txtOctNet4.ReadOnly = true;
            txtOctNet4.Size = new Size(90, 30);
            txtOctNet4.TabIndex = 33;
            txtOctNet4.TextAlign = HorizontalAlignment.Center;
            // 
            // lblErrorCidr
            // 
            lblErrorCidr.AutoSize = true;
            lblErrorCidr.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorCidr.Location = new Point(269, 210);
            lblErrorCidr.Name = "lblErrorCidr";
            lblErrorCidr.Size = new Size(137, 17);
            lblErrorCidr.TabIndex = 44;
            lblErrorCidr.Text = "Doit etre entre 8 et 32";
            // 
            // rdoBin
            // 
            rdoBin.Appearance = Appearance.Button;
            rdoBin.AutoSize = true;
            rdoBin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoBin.Location = new Point(135, 7);
            rdoBin.MinimumSize = new Size(110, 40);
            rdoBin.Name = "rdoBin";
            rdoBin.Size = new Size(110, 40);
            rdoBin.TabIndex = 1;
            rdoBin.TabStop = true;
            rdoBin.Text = "BINAIRE";
            rdoBin.TextAlign = ContentAlignment.MiddleCenter;
            rdoBin.UseVisualStyleBackColor = true;
            rdoBin.CheckedChanged += Radio_CheckedChanged;
            // 
            // rdoDec
            // 
            rdoDec.Appearance = Appearance.Button;
            rdoDec.AutoSize = true;
            rdoDec.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoDec.Location = new Point(6, 7);
            rdoDec.MinimumSize = new Size(110, 40);
            rdoDec.Name = "rdoDec";
            rdoDec.Size = new Size(110, 40);
            rdoDec.TabIndex = 0;
            rdoDec.TabStop = true;
            rdoDec.Text = "DECIMAL";
            rdoDec.TextAlign = ContentAlignment.MiddleCenter;
            rdoDec.UseVisualStyleBackColor = true;
            rdoDec.CheckedChanged += Radio_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoDec);
            groupBox1.Controls.Add(rdoBin);
            groupBox1.Location = new Point(172, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 48);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pnlCidrStd
            // 
            pnlCidrStd.Controls.Add(txtCidrOct1);
            pnlCidrStd.Controls.Add(txtCidrOct2);
            pnlCidrStd.Controls.Add(txtCidrOct3);
            pnlCidrStd.Controls.Add(txtCidrOct4);
            pnlCidrStd.Location = new Point(167, 246);
            pnlCidrStd.Name = "pnlCidrStd";
            pnlCidrStd.Size = new Size(395, 31);
            pnlCidrStd.TabIndex = 45;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 633);
            Controls.Add(pnlCidrStd);
            Controls.Add(lblErrorCidr);
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
            Controls.Add(lblNbMachine);
            Controls.Add(lblDerIp);
            Controls.Add(lblNbIps);
            Controls.Add(lblPreIp);
            Controls.Add(lblBroadcast);
            Controls.Add(lblNet);
            Controls.Add(lblClasse);
            Controls.Add(lblStd);
            Controls.Add(lblCidr);
            Controls.Add(txtNbMachine);
            Controls.Add(txtNbIp);
            Controls.Add(txtDerIp1);
            Controls.Add(txtPreIp1);
            Controls.Add(txtOctBroad1);
            Controls.Add(txtOctNet1);
            Controls.Add(txtClass);
            Controls.Add(txtOctCp4);
            Controls.Add(txtOctCp3);
            Controls.Add(txtOctCp2);
            Controls.Add(txtOctCp1);
            Controls.Add(txtOct4);
            Controls.Add(txtOct3);
            Controls.Add(txtOct2);
            Controls.Add(txtCidr);
            Controls.Add(lblTitreMasque);
            Controls.Add(txtOct1);
            Controls.Add(btnCalcul);
            Controls.Add(groupBox1);
            MaximumSize = new Size(611, 672);
            MinimumSize = new Size(611, 672);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlCidrStd.ResumeLayout(false);
            pnlCidrStd.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalcul;
        private TextBox txtOct1;
        private Label lblTitreMasque;
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
        private Label lblCidr;
        private Label lblStd;
        private Label lblClasse;
        private Label lblNet;
        private Label lblBroadcast;
        private Label lblPreIp;
        private Label lblNbIps;
        private Label lblDerIp;
        private Label lblNbMachine;
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
        private Label lblErrorCidr;
        private RadioButton rdoBin;
        private RadioButton rdoDec;
        private GroupBox groupBox1;
        private Panel pnlCidrStd;
    }
}
