using HomeWork.NTier.ERP.App.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork.NTier.ERP.App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void msbApp_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Northwind Mağazacılık", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void msbProduct_list_Click(object sender, EventArgs e)
        {
            var f = new frmProducts();
            f.MdiParent = this;
            f.Show();
        }

        private void msbEmployee_List_Click(object sender, EventArgs e)
        {
            //TODO : şimdi herşeyi Employee için yap
        }
    }
}
