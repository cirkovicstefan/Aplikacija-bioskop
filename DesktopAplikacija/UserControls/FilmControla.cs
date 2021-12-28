using BusinessLayer;
using Common.Interface.Business;
using Common.Model;
using System;
using System.Windows.Forms;

namespace DesktopAplikacija.UserControls
{
    public partial class FilmControla : UserControl
    {
        private readonly IFilmBusiness filmBusiness;
        public FilmControla()
        {
            InitializeComponent();
            filmBusiness = new FilmBusiness();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrorValidator())
                {
                    Film film = new Film();
                    film.Naziv = txtNaziv.Text;
                    film.Trajanje = txtTrajanje.Text;
                    film.Zanr = txtZanr.Text;
                    if (filmBusiness.Dodaj(film) == true)
                    {
                        MessageBox.Show("Uspesno ste dodali novi film");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Greska !!!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool ErrorValidator()
        {
            if (txtZanr.Text == "" || txtTrajanje.Text == "" || txtNaziv.Text == "")
                throw new Exception("Morate popuniti sva polja !!!");
            return true;
        }

        private void OsveziTabelu()
        {
            dataGridViewFilm.Rows.Clear();
            foreach (var item in filmBusiness.SviFilmovi())
            {
                dataGridViewFilm.Rows.Add(item.IdFilma, item.Naziv, item.Trajanje, item.Zanr);
            }
            dataGridViewFilm.Columns[0].Visible = false;
        }

        private void FilmControla_Load(object sender, EventArgs e)
        {
            OsveziTabelu();
        }
        private void SetInput()
        {
            txtNaziv.Text = "";
            txtTrajanje.Text = "";
            txtZanr.Text = "";
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrorValidator())
                {
                    int row = dataGridViewFilm.SelectedRows[0].Index;
                    int idFilma = Convert.ToInt32(dataGridViewFilm[0, row].Value.ToString());
                    Film film = new Film();
                    film.IdFilma = idFilma;
                    film.Naziv = txtNaziv.Text;
                    film.Trajanje = txtTrajanje.Text;
                    film.Zanr = txtZanr.Text;
                    if (filmBusiness.Izmeni(film) == true)
                    {
                        MessageBox.Show("Uspesno ste izmenili podatke za film");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Greska!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewFilm.SelectedRows[0].Index;
                txtNaziv.Text = dataGridViewFilm[1, row].Value.ToString();
                txtTrajanje.Text = dataGridViewFilm[2, row].Value.ToString();
                txtZanr.Text = dataGridViewFilm[3, row].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Morate selektovat red !!!");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewFilm.SelectedRows[0].Index;
                int idFilma = Convert.ToInt32(dataGridViewFilm[0, row].Value.ToString());
                if (filmBusiness.Obrisi(idFilma) == true)
                {
                    MessageBox.Show("Uspesno ste obrisali film ");
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
    }
}
