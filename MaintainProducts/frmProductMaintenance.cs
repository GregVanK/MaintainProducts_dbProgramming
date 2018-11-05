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
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupportDataSet2A);

        }

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet2A.Products' table. You can move, or remove it, as needed.
            try
            {
                this.productsTableAdapter.Fill(this.techSupportDataSet2A.Products);
            }catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
