using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
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
            TextBox textDec = (TextBox)sender;
            TextBox textBinaire = (TextBox)textDec.Tag;

            if (rdoDec.Checked)
            {
                int val;
                if (int.TryParse(textDec.Text, out val))
                    textBinaire.Text = new string(ConvertBinaire(val));
                else
                    textBinaire.Text = string.Empty;
            }
            else
            {
                if (!string.IsNullOrEmpty(textDec.Text))
                    textBinaire.Text = ConvertDecimal(textDec.Text).ToString();
                else
                    textBinaire.Text = string.Empty;
            }


            if (!string.IsNullOrEmpty(txtOct1.Text) && !string.IsNullOrEmpty(txtOct2.Text) && !string.IsNullOrEmpty(txtOct3.Text) && !string.IsNullOrEmpty(txtOct4.Text))
            {
                txtCidr.Enabled = true;
            }
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoButton = (RadioButton)sender;
            if (rdoButton.Checked)
            {
                ClearAllTextBox();
            }
        }

        private void ClearAllTextBox()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox textBox)
                    textBox.Clear();
            }
        }

        private void StyleError()
        {
            txtCidr.Font = new Font(txtCidr.Font, FontStyle.Bold);

            lblErrorCidr.ForeColor = Color.Red;
            lblErrorCidr.Font = new Font(lblErrorCidr.Font, FontStyle.Italic);
        }

        private void ResetStyleError()
        {
            txtCidr.Font = new Font(txtCidr.Font, FontStyle.Regular);

            lblErrorCidr.ForeColor = Color.Black;
            lblErrorCidr.Font = new Font(lblErrorCidr.Font, FontStyle.Regular);
        }

        private void GestionErreurIP(TextBox textDec)
        {
            try
            {
                if (rdoDec.Checked)
                {
                    if (int.Parse(textDec.Text) > 255)
                        textDec.Text = "255";
                    if (int.Parse(textDec.Text) < 0)
                        textDec.Text = "0";
                }
                else
                {
                    string valBin = textDec.Text;
                    for (int i = 0; i < valBin.Length; i++)
                        if (valBin[i] != '0' && valBin[i] != '1')
                            textDec.Text = "11111111";
                }
            }
            catch
            {
                if (rdoDec.Checked)
                    textDec.Text = "255";
                else
                    textDec.Text = "11111111";
            }
        }

        private void txtOctBinaire_Leave(object sender, EventArgs e)
        {
            TextBox textDec = (TextBox)sender;
            GestionErreurIP(textDec);
        }

        private void txtCidr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //lblErrorCidr.Hide();
                int val = Convert.ToInt32(txtCidr.Text);

                if (val >= 8 && val <= 32)
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
                }
            }
            catch (Exception)
            {
                //lblErrorCidr.Show();
                txtCidr.Text = string.Empty;
            }
        }

        private void txtCidr_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtCidr.Text) > 32 || int.Parse(txtCidr.Text) < 8)
                {
                    txtCidr.Text = "24";
                    StyleError();
                    Task.Delay(2000);
                    ResetStyleError();
                }
            }
            catch
            {
                txtCidr.Text = "24";
                StyleError();
                Task.Delay(2000);
                ResetStyleError();
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            if (checkIp() && checkCidr())
            {
                int valClass;
                if (rdoDec.Checked)
                    valClass = Convert.ToInt32(txtOct1.Text);
                else
                    valClass = Convert.ToInt32(ConvertDecimal(txtOct1.Text));

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

        private bool checkIp()
        {
            int Oct1;
            int Oct2;
            int Oct3;
            int Oct4;

            if (rdoDec.Checked)
            {
                Oct1 = Convert.ToInt32(txtOct1.Text);
                Oct2 = Convert.ToInt32(txtOct2.Text);
                Oct3 = Convert.ToInt32(txtOct3.Text);
                Oct4 = Convert.ToInt32(txtOct4.Text);
            }
            else
            {
                Oct1 = Convert.ToInt32(ConvertDecimal(txtOct1.Text));
                Oct2 = Convert.ToInt32(ConvertDecimal(txtOct2.Text));
                Oct3 = Convert.ToInt32(ConvertDecimal(txtOct3.Text));
                Oct4 = Convert.ToInt32(ConvertDecimal(txtOct4.Text));
            }

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
            int Oct1;

            if (rdoDec.Checked)
                Oct1 = Convert.ToInt32(txtOct1.Text);
            else
                Oct1 = Convert.ToInt32(ConvertDecimal(txtOct1.Text));

            int valClass = Convert.ToInt32(txtCidr.Text);

            if (Oct1 < 128 && valClass >= 8)
                return true;
            else if (Oct1 < 192 && valClass >= 16)
                return true;
            else if (Oct1 < 224 && valClass >= 24)
                return true;
            return false;
        }

        public static string ConvertBinaire(int decimale) // Convertit un nombre entier en binaire de type string
        {
            string binaire = "";

            for (int i = 0; i < 8; i++)
            {
                if (decimale % 2 == 0)
                {
                    binaire = "0" + binaire;
                }
                else
                {
                    binaire = "1" + binaire;
                }
                decimale = decimale / 2;
            }

            return binaire;
        }

        public static string ConvertDecimal(string binaire) // Convertit un nombre binaire en décimal
        {
            int decimale = 0;

            for (int i = 0; i < binaire.Length; i++)
            {
                if (binaire[i] == '1')
                {
                    decimale += Convert.ToInt32(Math.Pow(2, binaire.Length - 1 - i));
                }
            }

            return decimale.ToString();
        }

        private void CalculateNetworkAndBroadcast()
        {
            string valIpBi1; 
            string valIpBi2; 
            string valIpBi3;
            string valIpBi4;

            if (rdoDec.Checked)
            {
                valIpBi1 = txtOctCp1.Text;
                valIpBi2 = txtOctCp2.Text;
                valIpBi3 = txtOctCp3.Text;
                valIpBi4 = txtOctCp4.Text;
            }
            else
            {
                valIpBi1 = txtOct1.Text;
                valIpBi2 = txtOct2.Text;
                valIpBi3 = txtOct3.Text;
                valIpBi4 = txtOct4.Text;
            }

            // octet 1
            //int valMasque1 = Convert.ToInt32(txtCidrOct1.Text);
            string valMasqueBi1 = ConvertBinaire(Convert.ToInt32(txtCidrOct1.Text));

            // octet 2
            //int valMasque2 = Convert.ToInt32(txtCidrOct2.Text);
            string valMasqueBi2 = ConvertBinaire(Convert.ToInt32(txtCidrOct2.Text));

            // octet 3
            //int valMasque3 = Convert.ToInt32(txtCidrOct3.Text);
            string valMasqueBi3 = ConvertBinaire(Convert.ToInt32(txtCidrOct3.Text));

            // octet 4
            //int valMasque4 = Convert.ToInt32(txtCidrOct4.Text);
            string valMasqueBi4 = ConvertBinaire(Convert.ToInt32(txtCidrOct4.Text));

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

        public static string CalculateNet(string ip, string masque) // Calculer le net (ip ET masque)
        {
            string net = "";

            for (int i = 0; i < ip.Length; i++)
            {
                if (ip[i].Equals('1') && masque[i].Equals('1'))
                {
                    net += "1";
                }
                else
                {
                    net += "0";
                }
            }

            return net;
        }

        public static string non(string binaire) // Retourne le complément à 1 du binaire
        {
            string nonBinaire = "";

            for (int i = 0; i < binaire.Length; i++)
            {
                if (binaire[i].Equals('0'))
                {
                    nonBinaire += "1";
                }
                else
                {
                    nonBinaire += "0";
                }
            }

            return nonBinaire;
        }

        public static string CalculateBroadcast(string net, string masque) // Calculer le broadcast (net OU non(masque))
        {
            string broadcast = "";

            string nonMasque = non(masque);

            for (int i = 0; i < net.Length; i++)
            {
                if (net[i].Equals('1') || nonMasque[i].Equals('1'))
                {
                    broadcast += "1";
                }
                else
                {
                    broadcast += "0";
                }
            }

            return broadcast;
        }
    }
}
