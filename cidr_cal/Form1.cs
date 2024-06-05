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

        private void txtOctBinaire_TextChanged(object sender, EventArgs e)// Transforme la valeur de l'IP de binaire à decimale et de decimal à bianaire
        {
            TextBox textDec = (TextBox)sender;
            TextBox textBinaire = (TextBox)textDec.Tag;

            GestionErreurIP(textDec);

            if (rdoDec.Checked)
            {   
                int val;
                if (int.TryParse(textDec.Text, out val))
                {
                    textBinaire.Text = new string(ConvertBinaire(val));
                }
                else
                {
                    textBinaire.Text = string.Empty;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(textDec.Text))
                {
                    textBinaire.Text = ConvertDecimal(textDec.Text).ToString();
                }
                else
                {
                    textBinaire.Text = string.Empty;
                }
            }


            if (!string.IsNullOrEmpty(txtOct1.Text) && !string.IsNullOrEmpty(txtOct2.Text) && !string.IsNullOrEmpty(txtOct3.Text) && !string.IsNullOrEmpty(txtOct4.Text))
            {
                txtCidr.Enabled = true;
                txtCidrOct1.Enabled = true;
                txtCidrOct2.Enabled = true;
                txtCidrOct3.Enabled = true;
                txtCidrOct4.Enabled = true;

            }
        }

        private bool checkIp() // Vérifie si l'adresse IP est valide et renvoie un booléen
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

        private bool checkCidr() // Vérifie si l'adresse CIDR est valide et renvoie un booléen
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

        public static string ConvertBinaire(int decimale) // Convertit un nombre entier en binaire et retourne un string
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

        public static string ConvertDecimal(string binaire) // Convertit un nombre binaire en décimal et retourne un string
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

        private void Radio_CheckedChanged(object sender, EventArgs e) // Appelle la fonction ClearAllTextBox en cliquant sur un les radio button
        {
            RadioButton rdoButton = (RadioButton)sender;
            if (rdoButton.Checked)
            {
                ClearAllTextBox();
            }
        }

        private void ClearAllTextBox() // Supprime toutes les valeur des textBox
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox textBox)
                    textBox.Clear();
            }
        }

        private void StyleError() // Change la police du texte lorqu'une erreur est détectée
        {
            txtCidr.Font = new Font(txtCidr.Font, FontStyle.Bold);

            lblErrorCidr.ForeColor = Color.Red;
            lblErrorCidr.Font = new Font(lblErrorCidr.Font, FontStyle.Italic);
        }

        private void ResetStyleError() // Reset le style lorsque l'erreur est corrigée
        {
            txtCidr.Font = new Font(txtCidr.Font, FontStyle.Regular);

            lblErrorCidr.ForeColor = Color.Black;
            lblErrorCidr.Font = new Font(lblErrorCidr.Font, FontStyle.Regular);
        }

        private void GestionErreurIP(TextBox textDec) // Corrige la valeur de l'IP si elle est incorrecte
        {
            try
            {         
                lblErrorIP.Hide();
                if (rdoDec.Checked)
                {
                    if (string.IsNullOrWhiteSpace(textDec.Text))
                    {
                        textDec.Text = "0";
                    }
                    if (int.Parse(textDec.Text) > 255)
                    {
                        textDec.Text = "255";
                        lblErrorIP.Text = "Doit être compris entre 0 et 255";
                        lblErrorIP.Show();
                    }
                    if (int.Parse(textDec.Text) < 0) 
                    {
                        textDec.Text = "0";
                        lblErrorIP.Text = "Doit être compris entre 0 et 255";
                        lblErrorIP.Show();
                    }
                }
                else
                {
                    string valBin = textDec.Text;
                    if (valBin.Length > 8)
                    {
                        textDec.Text = "11111111";
                    }

                    foreach (char bit in valBin)
                    {
                        if (bit != '0' && bit != '1')
                        {
                            lblErrorIP.Text = "Doit être composé de 0 et de 1";
                            lblErrorIP.Show();
                        }
                    }
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

        private void txtOctBinaire_Leave(object sender, EventArgs e) // Met la valeur par défaut si l'IP est incorrecte
        {
            TextBox textDec = (TextBox)sender;
            GestionErreurIP(textDec);
        }

        private void txtCidr_TextChanged(object sender, EventArgs e) // Transforme la valeur de CIDR de binaire à decimale
        {
            try
            {
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
                txtCidr.Text = string.Empty; // Vide la textBox du CIDR
            }
        }

        private async void txtCidr_Leave(object sender, EventArgs e) // Met la valeur par défaut du CIDR si elle est incorrecte (<0 ou >32)
        {
            try
            {
                if (int.Parse(txtCidr.Text) > 32 || int.Parse(txtCidr.Text) < 8)
                {
                    StyleError();
                    await Task.Delay(2000);
                    txtCidr.Text = "24";
                    ResetStyleError();
                }
            }
            catch
            {
                StyleError();
                await Task.Delay(2000);
                txtCidr.Text = "24";
                ResetStyleError();
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e) // Calcule la classe de l'adresse ip
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

        private void CalculateNetworkAndBroadcast() // Calcule le masque, le net, la première et dernière IP
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

            // Octet 1
            string valMasqueBi1 = ConvertBinaire(Convert.ToInt32(txtCidrOct1.Text));

            // Octet 2
            string valMasqueBi2 = ConvertBinaire(Convert.ToInt32(txtCidrOct2.Text));

            // Octet 3
            string valMasqueBi3 = ConvertBinaire(Convert.ToInt32(txtCidrOct3.Text));

            // Octet 4
            string valMasqueBi4 = ConvertBinaire(Convert.ToInt32(txtCidrOct4.Text));
            if (rdoDec.Checked)
            {
                // Resultat octet 1
                txtOctNet1.Text = ConvertDecimal(CalculateNet(valIpBi1, valMasqueBi1));
                txtOctBroad1.Text = ConvertDecimal(CalculateBroadcast(valIpBi1, valMasqueBi1));
                txtPreIp1.Text = txtOctNet1.Text;
                txtDerIp1.Text = txtOctBroad1.Text;

                // Resultat octet 2
                txtOctNet2.Text = ConvertDecimal(CalculateNet(valIpBi2, valMasqueBi2));
                txtOctBroad2.Text = ConvertDecimal(CalculateBroadcast(valIpBi2, valMasqueBi2));
                txtPreIp2.Text = txtOctNet2.Text;
                txtDerIp2.Text = txtOctBroad2.Text;

                // Resultat octet 3
                txtOctNet3.Text = ConvertDecimal(CalculateNet(valIpBi3, valMasqueBi3));
                txtOctBroad3.Text = ConvertDecimal(CalculateBroadcast(valIpBi3, valMasqueBi3));
                txtPreIp3.Text = txtOctNet3.Text;
                txtDerIp3.Text = txtOctBroad3.Text;

                // Resultat octet 4
                txtOctNet4.Text = ConvertDecimal(CalculateNet(valIpBi4, valMasqueBi4));
                txtOctBroad4.Text = ConvertDecimal(CalculateBroadcast(valIpBi4, valMasqueBi4));
                txtPreIp4.Text = (Convert.ToInt32(txtOctNet4.Text) + 1).ToString();
                txtDerIp4.Text = (Convert.ToInt32(txtOctBroad4.Text) - 1).ToString();
            }
            else
            {
                // Resultat octet 1
                txtOctNet1.Text = CalculateNet(valIpBi1, valMasqueBi1);
                txtOctBroad1.Text = CalculateBroadcast(valIpBi1, valMasqueBi1);
                txtPreIp1.Text = txtOctNet1.Text;
                txtDerIp1.Text = txtOctBroad1.Text;

                // Resultat octet 2
                txtOctNet2.Text = CalculateNet(valIpBi2, valMasqueBi2);
                txtOctBroad2.Text = CalculateBroadcast(valIpBi2, valMasqueBi2);
                txtPreIp2.Text = txtOctNet2.Text;
                txtDerIp2.Text = txtOctBroad2.Text;

                // Resultat octet 3
                txtOctNet3.Text = CalculateNet(valIpBi3, valMasqueBi3);
                txtOctBroad3.Text = CalculateBroadcast(valIpBi3, valMasqueBi3);
                txtPreIp3.Text = txtOctNet3.Text;
                txtDerIp3.Text = txtOctBroad3.Text;

                // Resultat octet 4
                txtOctNet4.Text = CalculateNet(valIpBi4, valMasqueBi4);
                txtOctBroad4.Text = CalculateBroadcast(valIpBi4, valMasqueBi4);
                string octNet4 = ConvertDecimal(CalculateNet(valIpBi4, valMasqueBi4));
                string octBroad4 = ConvertDecimal(CalculateBroadcast(valIpBi4, valMasqueBi4));

                txtPreIp4.Text = ConvertBinaire((Convert.ToInt32(octNet4) + 1));
                txtDerIp4.Text = ConvertBinaire((Convert.ToInt32(octBroad4) - 1));
            }
            
        }

        private void CalculateNumberOfIPs() // Calcule le nombre d'IP et de machines disponibles
        {
            int valCidr = Convert.ToInt32(txtCidr.Text);
            int nbIps = (int)Math.Pow(2, 32 - valCidr);
            txtNbIp.Text = nbIps.ToString();
            txtNbMachine.Text = (nbIps - 2).ToString();
        }

        public static string CalculateNet(string adrIp, string masque) // Calculer le net (ip ET masque)
        {
            string net = "";

            for (int i = 0; i < adrIp.Length; i++)
            {
                if (adrIp[i].Equals('1') && masque[i].Equals('1'))
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

        public static string CalculateBroadcast(string adrIp, string masque) // Calculer le broadcast (net OU non(masque)
        {
            string broadcast = "";

            string nonMasque = non(masque);

            for (int i = 0; i < adrIp.Length; i++)
            {
                if (adrIp[i].Equals('1') || nonMasque[i].Equals('1'))
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
