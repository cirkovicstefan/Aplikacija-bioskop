using BusinessLayer;
using Common.Interface.Business;
using Common.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DesktopAplikacija.UserControls
{
    public partial class GledalacControla : UserControl
    {
        private IGledalacBusiness gledalacBusiness;
        public GledalacControla()
        {
            InitializeComponent();
            gledalacBusiness = new GledalacBusiness();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrorValidator())
                {
                    Gledalac gledalac = new Gledalac();
                    gledalac.Ime = txtIme.Text;
                    gledalac.Prezime = txtPrezime.Text;
                    gledalac.Email = txtEmail.Text;
                    if (gledalacBusiness.Dodaj(gledalac) == true)
                    {
                        MessageBox.Show("Uspesno ste uneli novog gledaoca");
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
            string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            if (!Regex.Match(txtEmail.Text, emailRegex).Success)
            {
                throw new Exception("Neispravan format email ili ga niste uneli, pokusajte ponovo !!!");
            }
            else if (txtIme.Text == string.Empty || txtPrezime.Text == string.Empty)
            {
                throw new Exception("Niste unesli ime ili prezime");
            }
            return true;
        }
        private void OsveziTabelu()
        {
            dataGridViewGledaoci.AutoGenerateColumns = false;
            dataGridViewGledaoci.Rows.Clear();
            foreach (var item in gledalacBusiness.SviGledaoci())
            {
                dataGridViewGledaoci.Rows.Add(item.IdGledaoca, item.Ime, item.Prezime, item.Email);
            }
            dataGridViewGledaoci.Columns[0].Visible = false;
        }
        private void SetInput()
        {
            txtEmail.Text = string.Empty;
            txtIme.Text = string.Empty;
            txtPrezime.Text = string.Empty;
        }

        private void GledalacControla_Load(object sender, EventArgs e)
        {
            OsveziTabelu();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrorValidator())
                {
                    Gledalac gledalac = new Gledalac();
                    int row = dataGridViewGledaoci.SelectedRows[0].Index;
                    gledalac.IdGledaoca = Convert.ToInt32(dataGridViewGledaoci[0, row].Value.ToString());
                    gledalac.Ime = txtIme.Text;
                    gledalac.Prezime = txtPrezime.Text;
                    gledalac.Email = txtEmail.Text;
                    if (gledalacBusiness.Izmeni(gledalac) == true)
                    {
                        MessageBox.Show("Uspesno ste izvrsili promenu ");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Greska !!!");
                    }
                }
            }
            catch
            {

            }
        }

        private void dataGridViewGledaoci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewGledaoci.SelectedRows[0].Index;
                txtIme.Text = dataGridViewGledaoci[1, row].Value.ToString();
                txtPrezime.Text = dataGridViewGledaoci[2, row].Value.ToString();
                txtEmail.Text = dataGridViewGledaoci[3, row].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Morate selektovati red !!!");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewGledaoci.SelectedRows[0].Index;
                int idGledalac = Convert.ToInt32(dataGridViewGledaoci[0, row].Value.ToString());

                if (gledalacBusiness.Obrisi(idGledalac) == true)
                {
                    MessageBox.Show("Uspesno ste obrisali podatak");
                    OsveziTabelu();
                    SetInput();
                }
                else
                {
                    MessageBox.Show("Gledaoca koga zelite  da obrisete vec se nalazi u drugim tablelama ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
