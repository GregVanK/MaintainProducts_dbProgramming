using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 *File: frmProductMaintenance
 *Author: Greg VanKampen
 */
namespace MaintainProducts
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }
        
        /**
        * Saves current form to database
        */
        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.techSupportDataSet2A);
        }
        /**
         * Loads data from dataset into form
         */
        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
           
            try
            {
                this.productsTableAdapter.Fill(this.techSupportDataSet2A.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server Error #" + ex.Number + ";" + ex.Message);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
