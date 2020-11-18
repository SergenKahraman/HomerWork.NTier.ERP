using HomeWork.NTier.ERP.Service.Products;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HomeWork.NTier.ERP.App.Products
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
            Service = new ProductListService();
            Limit = 15;
            btnPrevious.Enabled = false;
        }

        public ProductListService Service { get; set; }

        public int PageIndex { get; set; }

        public int Limit { get; set; }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            RunQuery();
        }

        private void RunQuery()
        {
            var data = Service.GetPagedProducts(PageIndex, Limit);
            btnNext.Enabled = data.Count() >= Limit;
            btnPrevious.Enabled = PageIndex != 0;
            dgvProducts.DataSource = data;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void PreviousPage()
        {
            PageIndex--;
            if (PageIndex < 0)
            {
                PageIndex = 0;
            }
            RunQuery();
        }

        private void NextPage()
        {
            PageIndex++;
            RunQuery();
        }
    }
}