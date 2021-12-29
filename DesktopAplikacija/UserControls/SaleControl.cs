using BusinessLayer;
using Common.Interface.Business;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopAplikacija.UserControls
{
    public partial class SaleControl : UserControl
    {
        private readonly ISalaBusiness salaBusiness;
        enum PretragaPo { NAZIV, KAPACITET };
        public SaleControl()
        {
            InitializeComponent();
            salaBusiness = new SalaBusiness();
            comboBoxKriterijum.DataSource = Enum.GetValues(typeof(PretragaPo));
            btnIzmeni.Enabled = false;
            btnObrisi.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    Sala sala = new Sala();
                    sala.NazivSale = txtNaziv.Text;
                    sala.Kapacitet = Convert.ToInt32(txtKapacitet.Text);
                    if (salaBusiness.Dodaj(sala))
                    {
                        MessageBox.Show("Uspesno ste uneli novu salu ");
                        OsveziTabelu();
                        SetInput();
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
        private void SetInput()
        {
            txtKapacitet.Text = "";
            txtNaziv.Text = "";
        }

        private void OsveziTabelu()
        {
            dataGridViewSale.Rows.Clear();
            foreach (var item in salaBusiness.SveSale())
            {
                dataGridViewSale.Rows.Add(item.IdSale, item.NazivSale, item.Kapacitet);
            }
        }

        private bool Validacija()
        {
            int k;
            if (txtNaziv.Text == string.Empty || !int.TryParse(txtKapacitet.Text, out k))
                throw new Exception("Morte popuniti sva polja !!!");
            return true;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    int row = dataGridViewSale.SelectedRows[0].Index;
                    int idSale = Convert.ToInt32(dataGridViewSale[0, row].Value.ToString());
                    Sala sala = new Sala();
                    sala.IdSale = idSale;
                    sala.NazivSale = txtNaziv.Text;
                    sala.Kapacitet = Convert.ToInt32(txtKapacitet.Text);
                    if (salaBusiness.Izmeni(sala))
                    {
                        MessageBox.Show("Uspesno ste izvrsili promenu");
                        OsveziTabelu();
                        SetInput();
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

        private void SaleControl_Load(object sender, EventArgs e)
        {
            OsveziTabelu();
        }

        private void dataGridViewSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewSale.SelectedRows[0].Index;
                txtNaziv.Text = dataGridViewSale[1, row].Value.ToString();
                txtKapacitet.Text = dataGridViewSale[2, row].Value.ToString();
                btnObrisi.Enabled = true;
                btnIzmeni.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Morate selektovati red ");
            }

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewSale.SelectedRows[0].Index;
                int idSale = Convert.ToInt32(dataGridViewSale[0, row].Value.ToString());
                if (salaBusiness.Obrisi(idSale))
                {
                    MessageBox.Show("Uspesno ste obrisali podatke o sali ");
                    OsveziTabelu();
                    SetInput();
                }
                else
                {
                    MessageBox.Show("Podatak koji zelite da obrisate povezan je sa drugim tabelama");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            Sala sala = new Sala();
            List<Sala> list = new List<Sala>();
            string by = comboBoxKriterijum.SelectedItem.ToString();
            if (by == "NAZIV")
            {
                sala.NazivSale = txtPretraga.Text;
                list = salaBusiness.Pretraga(by, sala);
            }
           
            dataGridViewSale.Rows.Clear();
            foreach(var item in list)
            {
                dataGridViewSale.Rows.Add(item.IdSale, item.NazivSale, item.Kapacitet);
            }
        }
    }
}
