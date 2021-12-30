using BusinessLayer;
using Common.Interface.Business;
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
    public partial class ZaradaOdFilma : UserControl
    {
        private readonly IKartaBusiness kartaBusiness;
        public ZaradaOdFilma()
        {
            InitializeComponent();
            kartaBusiness = new KartaBusiness();
        }

        private void ZaradaOdFilma_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();
            foreach(var item in kartaBusiness.ZaradaFilmova())
            {
                dataGridView1.Rows.Add(item);
            }
        }
    }
}
