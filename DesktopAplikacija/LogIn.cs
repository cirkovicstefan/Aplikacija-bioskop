using BusinessLayer;
using Common.Interface.Repository;
using Common.Model;
using System;
using System.Windows.Forms;

namespace DesktopAplikacija
{
    public partial class LogIn : Form
    {
        private readonly ILogInBusiness loginBusiness;
        public LogIn()
        {
            InitializeComponent();
            loginBusiness = new LoginBusiness();
            this.CenterToScreen();
        }

        private void SetInput()
        {
            txtKorisnickoIme.Text = string.Empty;
            txtLozinka.Text = string.Empty;
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {

            try
            {
                Login login = new Login();
                login.KorisnickoIme = txtKorisnickoIme.Text;
                login.Lozinka = txtLozinka.Text;
                string ime_BE = string.Empty;
                bool l = loginBusiness.LoginUser(login, out ime_BE);
                if (l)
                {
                    MessageBox.Show("Uspesno ste se prijavili na sistem");
                    SetInput();
                    string korisnicko_ime = ime_BE;
                    Bioskop bioskop = new Bioskop(korisnicko_ime);
                    bioskop.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Korisnicko ime i lozinka nisu tacni pokusajte ponovo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
