namespace NotUygulamasi_devamsizlikli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegerlendir_Click(object sender, EventArgs e)
        {
            string OgrVize = txtVize.Text;
            string OgrFinal = txtFinal.Text;

            int vize, final;
            if (!int.TryParse(OgrVize, out vize) || !int.TryParse(OgrFinal, out final) || vize < 0 || vize > 100 || final < 0 || final > 100)
            {
                lblDurum.Text = "LUTFEN GECERLI BIR SAYI GIRINIZ!";
                return;
            }
            double ortalama = (double)vize * 0.4 + (double)final * 0.6;
            if (chkDevam.Checked)
            {
               
                if(ortalama < 50)
                {
                    lblOrtalama.Text = ortalama.ToString();
                    lblDurum.Text = "KALDI.";
                    btnDegerlendir.Enabled = false;
                }
                else
                {
                    lblOrtalama.Text = ortalama.ToString();
                    lblDurum.Text = "GECTI.";
                    btnDegerlendir.Enabled = false;
                }
            }
            else
            {
                lblDurum.Text = "DEVAMSIZLIKTAN KALDI";
                lblOrtalama.Text = lblOrtalama.ToString();

            }
        }
    }
}
