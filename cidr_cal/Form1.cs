using System.Runtime.Intrinsics.X86;

namespace cidr_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtOct1.Tag = txtOctCp1;
            txtOct2.Tag = txtOctCp2;
            txtOct3.Tag = txtOctCp3;
            txtOct4.Tag = txtOctCp4;
        }

        private void txtOctBinaire_TextChanged(object sender, EventArgs e)
        {
            TextBox textHexa = (TextBox)sender;

            TextBox textBinaire = (TextBox)textHexa.Tag;

            int val = Convert.ToInt32(textHexa.Text);

            textBinaire.Text = new string(ConvertBinaire(val));

            if (!string.IsNullOrEmpty(txtOct1.Text))
            {
                txtCidr.Enabled = true;
            }

            if(val > 255 || val < 0)
            {
                MessageBox.Show("Invalid Input");
                textHexa.Text = "0";
            } 
        }

        private bool checkIp()
        {
            int Oct1 = Convert.ToInt32(txtOct1.Text);
            int Oct2 = Convert.ToInt32(txtOct2.Text);
            int Oct3 = Convert.ToInt32(txtOct3.Text);
            int Oct4 = Convert.ToInt32(txtOct4.Text);

            if (Oct1 == 0 || Oct1 == 10 || Oct1 == 127 || Oct1 >= 224)
                return false;
            else if (Oct1 == 100 && Oct2 >= 64 && Oct2 <= 127)
                return false;
            else if (Oct1 == 169 && Oct2 == 254)
                return false;
            else if (Oct1 == 172 && Oct2 >= 16 && Oct2 <= 31)
                return false;
            else if (Oct1 == 192 && Oct2 == 0 && (Oct3 == 2 || Oct3 == 0))
                return false;
            else if (Oct1 == 198 && (Oct2 == 18 || Oct2 == 19))
                return false;
            else if (Oct1 == 203 && Oct2 == 0 && Oct3 == 113)
                return false;
            return true;
        }

        private bool checkCidr()
        {
            int Oct1 = Convert.ToInt32(txtOct1.Text);
            int valClass = Convert.ToInt32(txtCidr.Text);

            if (Oct1 < 128 && valClass >= 8)
                return true;
            else if (Oct1 < 192 && valClass >= 16)
                return true;
            else if (Oct1 < 224 && valClass >= 24)
                return true;
            return false;
        }

        public char[] ConvertBinaire(int val)
        {
            char[] binaire = ['0', '0', '0', '0', '0', '0', '0', '0'];
            for (int i = 0; i < binaire.Length; i++)
            {
                if (val % 2 == 1)
                {
                    binaire[binaire.Length - 1 - i] = '1';
                }
                else
                {
                    binaire[binaire.Length - 1 - i] = '0';
                }
                val /= 2;
                if (val == 0) break;
            }
            return binaire;
        }

        private void txtCidr_TextChanged(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(txtCidr.Text);

            if (val > 8)
            {
                string[] hexa = ["0", "0", "0", "0"];

                int i = 0;
                while (val > 0)
                {
                    if (val >= 8)
                    {
                        hexa[i] = (Math.Pow(2, 8) - 1).ToString();
                        val -= 8;
                }
                    else
                    {
                        int val2 = 0;
                        for (int j = 7; j >= 8 - val; j--)
                        {
                            val2 += (int)Math.Pow(2, j);
                        }
                        hexa[i] = val2.ToString();
                        val = 0;
                    }
                    i++;
                }
                txtCidrOct1.Text = hexa[0];
                txtCidrOct2.Text = hexa[1];
                txtCidrOct3.Text = hexa[2];
                txtCidrOct4.Text = hexa[3];
            }
            if (!string.IsNullOrEmpty(txtCidr.Text))
            {
                btnCalcul.Enabled = true;

                //them border cho button
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (checkIp() && checkCidr())
            {
                int valClass = Convert.ToInt32(txtOct1.Text);
                if (valClass >= 240 && valClass <= 255)
                    txtClass.Text = "E";
                else if (valClass >= 224)
                    txtClass.Text = "D";
                else if (valClass >= 192)
                    txtClass.Text = "C";
                else if (valClass >= 128)
                    txtClass.Text = "B";
                else if (valClass >= 0)
                    txtClass.Text = "A";

                CalculateNetworkAndBroadcast();
                CalculateNumberOfIPs();
            }
            else if (!checkIp() && !checkCidr())
                MessageBox.Show("Invalid Adresse IP et CIDR");
            else if (!checkIp())
                MessageBox.Show("Invalid Adresse IP");
            else
                MessageBox.Show("Invalid CIDR");
        }

        private void CalculateNetworkAndBroadcast()
        {
            // octet 1
            int valIp1 = Convert.ToInt32(txtOct1.Text);
            char[] valIpBi1 = ConvertBinaire(valIp1);
            int valMasque1 = Convert.ToInt32(txtCidrOct1.Text);
            char[] valMasqueBi1 = ConvertBinaire(valMasque1);

            // octet 2
            int valIp2 = Convert.ToInt32(txtOct2.Text);
            char[] valIpBi2 = ConvertBinaire(valIp2);
            int valMasque2 = Convert.ToInt32(txtCidrOct2.Text);
            char[] valMasqueBi2 = ConvertBinaire(valMasque2);

            // octet 3
            int valIp3 = Convert.ToInt32(txtOct3.Text);
            char[] valIpBi3 = ConvertBinaire(valIp3);
            int valMasque3 = Convert.ToInt32(txtCidrOct3.Text);
            char[] valMasqueBi3 = ConvertBinaire(valMasque3);

            // octet 4
            int valIp4 = Convert.ToInt32(txtOct4.Text);
            char[] valIpBi4 = ConvertBinaire(valIp4);
            int valMasque4 = Convert.ToInt32(txtCidrOct4.Text);
            char[] valMasqueBi4 = ConvertBinaire(valMasque4);

            // result octet 1
            txtOctNet1.Text = ConvertDecimal(CalculateNet(valIpBi1, valMasqueBi1));
            txtOctBroad1.Text = ConvertDecimal(CalculateBroadcast(valIpBi1, valMasqueBi1));
            txtPreIp1.Text = txtOctNet1.Text;
            txtDerIp1.Text = txtOctBroad1.Text;

            // result octet 2
            txtOctNet2.Text = ConvertDecimal(CalculateNet(valIpBi2, valMasqueBi2));
            txtOctBroad2.Text = ConvertDecimal(CalculateBroadcast(valIpBi2, valMasqueBi2));
            txtPreIp2.Text = txtOctNet2.Text;
            txtDerIp2.Text = txtOctBroad2.Text;

            // result octet 3
            txtOctNet3.Text = ConvertDecimal(CalculateNet(valIpBi3, valMasqueBi3));
            txtOctBroad3.Text = ConvertDecimal(CalculateBroadcast(valIpBi3, valMasqueBi3));
            txtPreIp3.Text = txtOctNet3.Text;
            txtDerIp3.Text = txtOctBroad3.Text;

            // result octet 4
            txtOctNet4.Text = ConvertDecimal(CalculateNet(valIpBi4, valMasqueBi4));
            txtOctBroad4.Text = ConvertDecimal(CalculateBroadcast(valIpBi4, valMasqueBi4));
            txtPreIp4.Text = (Convert.ToInt32(txtOctNet4.Text) + 1).ToString();
            txtDerIp4.Text = (Convert.ToInt32(txtOctBroad4.Text) - 1).ToString();


        }

        private void CalculateNumberOfIPs()
        {
            int valCidr = Convert.ToInt32(txtCidr.Text);
            int nbIps = (int)Math.Pow(2, 32 - valCidr);
            txtNbIp.Text = nbIps.ToString();
            txtNbMachine.Text = (nbIps - 2).ToString();
        }

        public char[] CalculateNet(char[] ip, char[] mask)
        {
            char[] result = new char[ip.Length];
            for (int i = 0; i < ip.Length; i++)
            {
                result[i] = (ip[i] == '1' && mask[i] == '1') ? '1' : '0';
            }
            return result;
        }

        public char[] CalculateBroadcast(char[] ip, char[] mask)
        {
            char[] result = new char[ip.Length];
            for (int i = 0; i < 8; i++)
            {
                result[i] = (mask[i] == '0') ? '1' : ip[i];
            }
            return result;
        }

        public string ConvertDecimal(char[] binary)
        {
            int val = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    val += (int)Math.Pow(2, 7 - i);
                }
            }
            return val.ToString();
        }
    }
}
