using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintainProducts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maintainProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductMaintenance productForm = new frmProductMaintenance();
            productForm.MdiParent = this;
            productForm.Show();
        }

        private void maintainCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerMaintenance customerForm = new frmCustomerMaintenance();
            customerForm.MdiParent = this;
            customerForm.Show();
        }
    }
}
