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
            btnIzmeni.Enabled = false;
            btnObrisi.Enabled = false;
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
            OsveziTabelu();
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
                    OsveziTabelu();
                    SetInput();
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
        private void SetInput()
        {
            txtBrojSedista.Text = string.Empty;
            txtCena.Text = string.Empty;
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                Karta karta = new Karta();
                int row = dataGridViewKarte.SelectedRows[0].Index;
                int IdKarte = Convert.ToInt32(dataGridViewKarte[0, row].Value.ToString());
                karta.IdKarte = IdKarte;
                karta.BrojSedista = Convert.ToInt32(txtBrojSedista.Text);
                karta.Cena = decimal.Parse(txtCena.Text);
                karta.IdFilma = GetIdFilma(comboBoxNazivFilma.SelectedItem.ToString());
                karta.IdSale = GetIdSale(comboBoxNazivSale.SelectedItem.ToString());
                karta.IdGledaoca = GetIdGledaoca(comboBoxEmailGledaoca.SelectedItem.ToString());
                karta.DatumOdrzavanja = comboBoxDatumOdrzavanja.SelectedItem.ToString();
                if (kartaBusiness.Izmeni(karta))
                {
                    MessageBox.Show("Uspesno ste izvrsili promenu ");
                    OsveziTabelu();
                    SetInput();
                }
                else
                {
                    MessageBox.Show("Greska!!!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewKarte.SelectedRows[0].Index;
                int IdKarte = Convert.ToInt32(dataGridViewKarte[0, row].Value.ToString());
                Karta karta = new Karta();
                karta.IdKarte = IdKarte;
                if (kartaBusiness.Obrisi(karta))
                {
                    MessageBox.Show("Uspesno ste ponistili kartu ");
                }
                else
                {
                    MessageBox.Show("Podatak koji zelite da obrisate je povezan u drugim tabelama");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OsveziTabelu()
        {
            dataGridViewKarte.AutoGenerateColumns = false;
            dataGridViewKarte.Rows.Clear();

            foreach (var item1 in kartaBusiness.SveKarte())
            {
                foreach (var item2 in item1.ListFilmova)
                {
                    foreach (var item3 in item1.ListGledaoci)
                    {
                        foreach (var item4 in item1.ListSala)
                        {
                            if (item1.IdFilma == item2.IdFilma && item1.IdGledaoca == item3.IdGledaoca && item1.IdSale == item4.IdSale)
                            {
                                dataGridViewKarte.Rows.Add(
                                    item1.IdKarte, item1.BrojSedista, item2.Naziv, item4.NazivSale,
                                    item3.Ime, item3.Prezime, item3.Email, item1.Cena, item1.DatumOdrzavanja, item2.Trajanje

                                    );
                            }
                        }
                    }
                }
            }

        }

        private void dataGridViewKarte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewKarte.SelectedRows[0].Index;
                txtBrojSedista.Text = dataGridViewKarte[1, row].Value.ToString();
                comboBoxNazivFilma.SelectedItem = dataGridViewKarte[2, row].Value.ToString();
                comboBoxNazivSale.SelectedItem = dataGridViewKarte[3, row].Value.ToString();
                comboBoxEmailGledaoca.SelectedItem = dataGridViewKarte[6, row].Value.ToString();
                txtCena.Text = dataGridViewKarte[7, row].Value.ToString();
                comboBoxDatumOdrzavanja.SelectedItem = dataGridViewKarte[8, row].Value.ToString();
                btnObrisi.Enabled = true;
                btnIzmeni.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Morate selektovati red u tabeli ");
            }
        }
    }
}
