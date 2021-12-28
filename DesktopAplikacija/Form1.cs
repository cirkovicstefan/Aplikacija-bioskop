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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            Filmovi filmovi = new Filmovi();
            filmovi.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(filmovi);
        }
    }
}
