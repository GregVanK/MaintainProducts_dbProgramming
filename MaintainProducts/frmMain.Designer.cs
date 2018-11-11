namespace MaintainProducts
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTechnicianIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainTechniciansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayCustomersByProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayIncidentsByProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOpenIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOpenIncidentsByTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMailingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayIncidentsByCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.incidentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTechnicianIncidentsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportTechnicianIncidentsToolStripMenuItem
            // 
            this.exportTechnicianIncidentsToolStripMenuItem.Name = "exportTechnicianIncidentsToolStripMenuItem";
            this.exportTechnicianIncidentsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exportTechnicianIncidentsToolStripMenuItem.Text = "ExportTechnician Incidents";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainProductsToolStripMenuItem,
            this.maintainCustomersToolStripMenuItem,
            this.maintainTechniciansToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // maintainProductsToolStripMenuItem
            // 
            this.maintainProductsToolStripMenuItem.Name = "maintainProductsToolStripMenuItem";
            this.maintainProductsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.maintainProductsToolStripMenuItem.Text = "Maintain Products";
            this.maintainProductsToolStripMenuItem.Click += new System.EventHandler(this.maintainProductsToolStripMenuItem_Click);
            // 
            // maintainCustomersToolStripMenuItem
            // 
            this.maintainCustomersToolStripMenuItem.Name = "maintainCustomersToolStripMenuItem";
            this.maintainCustomersToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.maintainCustomersToolStripMenuItem.Text = "Maintain Customers";
            this.maintainCustomersToolStripMenuItem.Click += new System.EventHandler(this.maintainCustomersToolStripMenuItem_Click);
            // 
            // maintainTechniciansToolStripMenuItem
            // 
            this.maintainTechniciansToolStripMenuItem.Name = "maintainTechniciansToolStripMenuItem";
            this.maintainTechniciansToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.maintainTechniciansToolStripMenuItem.Text = "Maintain Technicians";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayCustomersByProductToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // displayCustomersByProductToolStripMenuItem
            // 
            this.displayCustomersByProductToolStripMenuItem.Name = "displayCustomersByProductToolStripMenuItem";
            this.displayCustomersByProductToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.displayCustomersByProductToolStripMenuItem.Text = "Display Customers by Product";
            // 
            // incidentsToolStripMenuItem
            // 
            this.incidentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayIncidentsByProductToolStripMenuItem,
            this.displayOpenIncidentsToolStripMenuItem,
            this.createIncidentToolStripMenuItem,
            this.updateIncidentToolStripMenuItem,
            this.displayOpenIncidentsByTechnicianToolStripMenuItem,
            this.createMailingListToolStripMenuItem,
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem,
            this.displayIncidentsByCustomerToolStripMenuItem});
            this.incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            this.incidentsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.incidentsToolStripMenuItem.Text = "Incidents";
            // 
            // displayIncidentsByProductToolStripMenuItem
            // 
            this.displayIncidentsByProductToolStripMenuItem.Name = "displayIncidentsByProductToolStripMenuItem";
            this.displayIncidentsByProductToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.displayIncidentsByProductToolStripMenuItem.Text = "Display Incidents by Product";
            // 
            // displayOpenIncidentsToolStripMenuItem
            // 
            this.displayOpenIncidentsToolStripMenuItem.Name = "displayOpenIncidentsToolStripMenuItem";
            this.displayOpenIncidentsToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.displayOpenIncidentsToolStripMenuItem.Text = "Display Open Incidents";
            // 
            // createIncidentToolStripMenuItem
            // 
            this.createIncidentToolStripMenuItem.Name = "createIncidentToolStripMenuItem";
            this.createIncidentToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.createIncidentToolStripMenuItem.Text = "Create Incident";
            // 
            // updateIncidentToolStripMenuItem
            // 
            this.updateIncidentToolStripMenuItem.Name = "updateIncidentToolStripMenuItem";
            this.updateIncidentToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.updateIncidentToolStripMenuItem.Text = "Update Incident";
            // 
            // displayOpenIncidentsByTechnicianToolStripMenuItem
            // 
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Name = "displayOpenIncidentsByTechnicianToolStripMenuItem";
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Text = "Display Open Incidents by Technician";
            // 
            // createMailingListToolStripMenuItem
            // 
            this.createMailingListToolStripMenuItem.Name = "createMailingListToolStripMenuItem";
            this.createMailingListToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.createMailingListToolStripMenuItem.Text = "Create Mailing List";
            // 
            // displayIncidentsByProductAndTechnicianToolStripMenuItem
            // 
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem.Name = "displayIncidentsByProductAndTechnicianToolStripMenuItem";
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.displayIncidentsByProductAndTechnicianToolStripMenuItem.Text = "Display Incidents by Product and Technician";
            // 
            // displayIncidentsByCustomerToolStripMenuItem
            // 
            this.displayIncidentsByCustomerToolStripMenuItem.Name = "displayIncidentsByCustomerToolStripMenuItem";
            this.displayIncidentsByCustomerToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.displayIncidentsByCustomerToolStripMenuItem.Text = "Display Incidents by Customer";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "Greg VanKampen";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 382);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "SportsPro System";
            this.Load += new System.EventHandler(this.frmProductMaintenance_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTechnicianIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainTechniciansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayCustomersByProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayIncidentsByProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOpenIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOpenIncidentsByTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMailingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayIncidentsByProductAndTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayIncidentsByCustomerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}