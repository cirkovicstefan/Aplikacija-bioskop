using DesktopAplikacija.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAplikacija
{
    public partial class Bioskop : Form
    {
        public Bioskop()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            FilmControla filmovi = new FilmControla();
            filmovi.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(filmovi);
        }

        private void btnGledalac_Click(object sender, EventArgs e)
        {
            GledalacControla gledalac = new GledalacControla();
            gledalac.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(gledalac);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleControl saleControl = new SaleControl();
            saleControl.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(saleControl);
        }

        private void btnKarta_Click(object sender, EventArgs e)
        {
            KartaControla kartaControla = new KartaControla();
            kartaControla.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(kartaControla);
        }

        private void btnPrikazivanjeFilma_Click(object sender, EventArgs e)
        {
            PrikazivanjeFilma prikazivanjeFilma = new PrikazivanjeFilma();
            prikazivanjeFilma.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(prikazivanjeFilma);
        }

        private void btnZarada_Click(object sender, EventArgs e)
        {
            ZaradaOdFilma zaradaOdFilma = new ZaradaOdFilma();
            zaradaOdFilma.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(zaradaOdFilma);
        }

        private void btnRadnik_Click(object sender, EventArgs e)
        {
            RadnikControla radnikControla = new RadnikControla();
            radnikControla.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(radnikControla);
        }
    }
}
