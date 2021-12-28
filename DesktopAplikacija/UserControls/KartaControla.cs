using BusinessLayer;
using Common.Interface.Business;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopAplikacija.UserControls
{
    public partial class KartaControla : UserControl
    {
        private readonly IGledalacBusiness businessGledalac;
        private readonly IFilmBusiness filmBusiness;
        private readonly ISalaBusiness salaBusiness;
        private readonly ISeIgraUSaliBusiness seIgraUSaliBusiness;
        private readonly IKartaBusiness kartaBusiness;

        public KartaControla()
        {
            InitializeComponent();
            businessGledalac = new GledalacBusiness();
            filmBusiness = new FilmBusiness();
            salaBusiness = new SalaBusiness();
            seIgraUSaliBusiness = new IgraSeUSaliBusiness();
            kartaBusiness = new KartaBusiness();
        }

        private List<string> ListEmail()
        {
            List<string> list = new List<string>();
            foreach (var item in businessGledalac.SviGledaoci())
            {
                list.Add(item.Email);
            }
            return list;
        }
        private List<string> ListNazivFilma()
        {
            List<string> list = new List<string>();
            foreach (var item in filmBusiness.SviFilmovi())
            {
                list.Add(item.Naziv);
            }
            return list;
        }
        private List<string> ListNazivSale()
        {
            List<string> list = new List<string>();
            foreach (var item in salaBusiness.SveSale())
            {
                list.Add(item.NazivSale);
            }
            return list;
        }
        private List<string> ListDatumOdrzavanja()
        {
            List<string> list = new List<string>();
            foreach (var item in seIgraUSaliBusiness.SviSeIgraUSali())
            {
                list.Add(item.DatumOdrzavanja);
            }
            return list;

        }
        private int GetIdFilma(string naziv)
        {
            int idFilma = 0;
            foreach (var item in filmBusiness.SviFilmovi())
            {
                if (item.Naziv.Equals(naziv))
                {
                    idFilma = item.IdFilma;
                    break;
                }
            }
            return idFilma;
        }
        private int GetIdGledaoca(string email)
        {
            int idGledaoca = 0;
            foreach (var item in businessGledalac.SviGledaoci())
            {
                if (item.Email.Equals(email))
                {
                    idGledaoca = item.IdGledaoca;
                    break;
                }
            }
            return idGledaoca;
        }
        private int GetIdSale(string naziv)
        {
            int IdSale = 0;
            foreach (var item in salaBusiness.SveSale())
            {
                if (item.NazivSale.Equals(naziv))
                {
                    IdSale = item.IdSale;
                    break;
                }
            }
            return IdSale;
        }

        private void KartaControla_Load(object sender, EventArgs e)
        {
            comboBoxEmailGledaoca.DataSource = ListEmail();
            comboBoxNazivFilma.DataSource = ListNazivFilma();
            comboBoxNazivSale.DataSource = ListNazivSale();
            comboBoxDatumOdrzavanja.DataSource = ListDatumOdrzavanja();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {


            try
            {
                Karta karta = new Karta();
                karta.BrojSedista = Convert.ToInt32(txtBrojSedista.Text);
                karta.IdFilma = GetIdFilma(comboBoxNazivFilma.Text);
                karta.IdSale = GetIdSale(comboBoxNazivSale.Text);
                karta.IdGledaoca = GetIdGledaoca(comboBoxEmailGledaoca.Text);
                karta.DatumOdrzavanja = comboBoxDatumOdrzavanja.Text;
                karta.Cena = decimal.Parse(txtCena.Text);
                if (kartaBusiness.Dodaj(karta) == true)
                {
                    MessageBox.Show("Uspešno ste prodali kartu ");
                }
                else
                {
                    MessageBox.Show("Ne možete da prodate kartu uneli ste neispravne podatke");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



    }
}
