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
    public partial class frmCustomerMaintenance : Form
    {
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerMaintenanceDataset);

        }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerMaintenanceDataset.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.customerMaintenanceDataset.States);
            // TODO: This line of code loads data into the 'customerMaintenanceDataset.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customerMaintenanceDataset.Customers);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.CancelEdit();
        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillByCustomerID(this.customerMaintenanceDataset.Customers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
