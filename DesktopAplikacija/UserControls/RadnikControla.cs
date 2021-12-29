using BusinessLayer;
using Common.Interface.Repository;
using Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAplikacija.UserControls
{
    public partial class RadnikControla : UserControl
    {
        private readonly ILogInBusiness logInBusiness;
        public RadnikControla()
        {
            InitializeComponent();
            logInBusiness = new LoginBusiness();
        }

        

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    Login login = new Login();
                    login.KorisnickoIme = txtKorisnickoIme.Text;
                    login.Lozinka = txtLozinka.Text;
                    if (logInBusiness.Dodaj(login))
                    {
                        MessageBox.Show("Uspesno ste uneli novog readnika");
                        OsveziListBox();
                        txtKorisnickoIme.Text = string.Empty;
                        txtLozinka.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Greska!!!");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool Validacija()
        {
            if (txtKorisnickoIme.Text == string.Empty || txtLozinka.Text == string.Empty)
                throw new Exception("Morate uneti sva polja");
            return true;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
               
                    Login login = new Login();
                    login.KorisnickoIme = txtKorisnickoIme.Text;
                    if (logInBusiness.Obrisi(login))
                    {
                        MessageBox.Show("Uspesno ste obrisali radnika");
                    }
                    else
                    {
                        MessageBox.Show("Greska");
                    }
                    OsveziListBox();
                    txtKorisnickoIme.Text = string.Empty;
                    txtLozinka.Text = string.Empty;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OsveziListBox()
        {
            listBoxRadnik.Items.Clear();
            foreach(var item in logInBusiness.SviRadnici())
            {
                listBoxRadnik.Items.Add(item.KorisnickoIme);
            }
        }

        private void listBoxRadnik_SelectedValueChanged(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = listBoxRadnik.SelectedItem.ToString();
        }

        private void RadnikControla_Load(object sender, EventArgs e)
        {
            OsveziListBox();
        }
    }
}
