using BusinessLayer;
using Common.Interface.Business;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DesktopAplikacija.UserControls
{
    public partial class PrikazivanjeFilma : UserControl
    {
        string regexDate = "^[0-3]?[0-9].[0-3]?[0-9].(?:[0-9]{2})?[0-9]{2}$";
        private readonly ISeIgraUSaliBusiness seIgraUSaliBusiness;
        private readonly IFilmBusiness filmBusiness;
        private readonly ISalaBusiness salaBusiness;
        public PrikazivanjeFilma()
        {
            InitializeComponent();
            seIgraUSaliBusiness = new IgraSeUSaliBusiness();
            filmBusiness = new FilmBusiness();
            salaBusiness = new SalaBusiness();
            btnIzmeni.Enabled = false;
            btnObrisi.Enabled = false;
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

        private int GetIdSale(string naziv)
        {
            int idSale = 0;
            foreach (var item in salaBusiness.SveSale())
            {
                if (item.NazivSale.Equals(naziv))
                {
                    idSale = item.IdSale;
                    break;
                }
            }
            return idSale;
        }

        private int GetIdFilm(string naziv)
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    SeIgraUSali seIgraUSali = new SeIgraUSali();
                    seIgraUSali.IdFilma = GetIdFilm(comboBoxNazivFilma.SelectedItem.ToString());
                    seIgraUSali.IdSale = GetIdSale(comboBoxNazivSale.SelectedItem.ToString());
                    seIgraUSali.BrojProdatihKarata = Convert.ToInt32(txtBrojProdatih.Text);
                    seIgraUSali.DatumOdrzavanja = txtDatumOdrzavanja.Text;
                    seIgraUSali.VremeOdrzavanja = txtVreme.Text;
                    if (seIgraUSaliBusiness.Dodaj(seIgraUSali))
                    {
                        MessageBox.Show("Uspesno ste dodali podatak ");
                        OsveziTabelu();

                    }
                    else
                    {
                        MessageBox.Show("Greska");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    int row = dataGridViewKarte.SelectedRows[0].Index;
                   
                    SeIgraUSali seIgraUSali = new SeIgraUSali();
                    seIgraUSali.IdFilma = GetIdFilm(comboBoxNazivFilma.SelectedItem.ToString());
                    seIgraUSali.IdSale = GetIdSale(comboBoxNazivSale.SelectedItem.ToString());
                    seIgraUSali.DatumOdrzavanja = txtDatumOdrzavanja.Text;
                    seIgraUSali.VremeOdrzavanja = txtVreme.Text;
                    seIgraUSali.BrojProdatihKarata = Convert.ToInt32(txtBrojProdatih.Text);
                    if (seIgraUSaliBusiness.Izmeni(seIgraUSali))
                    {
                        MessageBox.Show("Uspesno ste promenili podatke");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Greska !!!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    SeIgraUSali seIgraUSali = new SeIgraUSali();
                    int row = dataGridViewKarte.SelectedRows[0].Index;
                    seIgraUSali.IdFilma = GetIdFilm(comboBoxNazivFilma.SelectedItem.ToString());
                    seIgraUSali.IdSale = GetIdSale(comboBoxNazivSale.SelectedItem.ToString());
                    seIgraUSali.DatumOdrzavanja = txtDatumOdrzavanja.Text;
                    if (seIgraUSaliBusiness.Obrisi(seIgraUSali))
                    {
                        MessageBox.Show("Uspesno ste obrisali podatak");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Podatak u tabeli je povezan sa ostalim podacima !!!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrikazivanjeFilma_Load(object sender, EventArgs e)
        {
            comboBoxNazivFilma.DataSource = ListNazivFilma();
            comboBoxNazivSale.DataSource = ListNazivSale();
            OsveziTabelu();
        }
        private void SetInput()
        {
            txtBrojProdatih.Text = "";
            txtDatumOdrzavanja.Text = "";
            txtVreme.Text = "";
        }

        private bool Validacija()
        {
            int v;
            if (!int.TryParse(txtBrojProdatih.Text, out v) || txtVreme.Text == string.Empty || txtDatumOdrzavanja.Text==string.Empty ||
                !Regex.Match(txtDatumOdrzavanja.Text, regexDate).Success)
                throw new Exception("Morate popuniti sva polja ili ste uneli neispravan format datuma");
            return true;
        }

        private void OsveziTabelu()
        {
            dataGridViewKarte.Rows.Clear();
            foreach (var item1 in seIgraUSaliBusiness.SviSeIgraUSali())
            {
                foreach (var item2 in item1.ListFilmova)
                {
                    foreach (var item3 in item1.ListSala)
                    {
                        if (item1.IdFilma == item2.IdFilma && item1.IdSale == item3.IdSale)
                        {
                            dataGridViewKarte.Rows.Add(
                                item2.Naziv, item3.NazivSale, item1.DatumOdrzavanja, item1.VremeOdrzavanja,
                                item1.BrojProdatihKarata, item3.Kapacitet
                                );
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
                comboBoxNazivFilma.SelectedItem = dataGridViewKarte[0, row].Value.ToString();
                comboBoxNazivSale.SelectedItem = dataGridViewKarte[1, row].Value.ToString();
                txtVreme.Text = dataGridViewKarte[3, row].Value.ToString();
                txtBrojProdatih.Text = dataGridViewKarte[4, row].Value.ToString();
                txtDatumOdrzavanja.Text = dataGridViewKarte[2, row].Value.ToString();
                btnIzmeni.Enabled = !false;
                btnObrisi.Enabled = !false;

            }
            catch
            {
                MessageBox.Show("Morate selektovati red");
            }
        }
    }
}
