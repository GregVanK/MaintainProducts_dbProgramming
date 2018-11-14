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
 *File: frmCustomerMaintenance
 *Author: Greg VanKampen
 */
namespace MaintainProducts
{
    public partial class frmCustomerMaintenance : Form
    {
        
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }
        /**
         * Saves current form to database
         */
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerMaintenanceDataset);

        }
        /**
         * Loads data from dataset into form
         */
        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            Binding b = zipCodeTextBox.DataBindings["Text"];
            b.Format += FormatZipCode;
            b.Parse += UnFormatZipCode;
            try
            {
                this.statesTableAdapter.Fill(this.customerMaintenanceDataset.States);
                this.customersTableAdapter.Fill(this.customerMaintenanceDataset.Customers);
                
            }
            catch (SqlException ex)
            {

                MessageBox.Show("SQL Server Error #" + ex.Number + ";" + ex.Message);
            }
        }
        /**
         * Resets form to datasets origin values
         */
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
            catch(SqlException ex)
            {
                MessageBox.Show("SQL Server Error #" + ex.Number + ";" + ex.Message);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        /**
         * Formats Zip code with '-' after 5th number
         */
        private void FormatZipCode(object sender, ConvertEventArgs e) {
            String modifiedZip = "";
            if (e.Value.GetType().ToString() == "System.String")
            {
                modifiedZip = e.Value.ToString();
                if (modifiedZip.Length > 5)
                {
                    modifiedZip = modifiedZip.Substring(0, 5) + "-" + modifiedZip.Substring(5);
                    e.Value = modifiedZip;
                }
            }
        }
        /**
         * Removes zip code formatting
         */
        private void UnFormatZipCode(object sender, ConvertEventArgs e)
        {
            String modifiedZip = "";
            if (e.Value.GetType().ToString() == "System.String")
            {
                modifiedZip = e.Value.ToString();
                //for (int i = 0; i < modifiedZip.Length; i++)
                //{
                //    if (modifiedZip[i] == '-')
                //    {
                //        modifiedZip = modifiedZip.Substring(0, i) + modifiedZip.Substring(i + 1);
                //        i--;
                //    }
                //}
                modifiedZip.Replace("-", "");
                e.Value = modifiedZip;
            }
            
        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
