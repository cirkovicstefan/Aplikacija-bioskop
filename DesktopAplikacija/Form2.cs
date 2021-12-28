using BusinessLayer;
using Common.Interface.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopAplikacija
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        IGledalacBusiness gledalacBusiness = new GledalacBusiness();

        private void Form2_Load(object sender, EventArgs e)
        {

            comboBox1.DataSource = rt();
        }

        private List<string>rt()
        {
            List<string> list = new List<string>();
            foreach (var item in gledalacBusiness.SviGledaoci())
            {
                list.Add(item.Email);
            }
            return list;
        }
    }
}
