namespace cidr_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtOctCp1_TextChanged(object sender, EventArgs e)
        {
            int val = int.Parse(txtOctCp1.Text);
            string binaire = Convert.ToString(val, 2).PadLeft(8, '0');
            txtOctCp1.Text = binaire;
        }
    }
}
