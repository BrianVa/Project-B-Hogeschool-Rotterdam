namespace TicketApp
{
    partial class Orders
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
            this.OrdersTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filmtitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stoelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Annuleer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.KlantOrderPanel = new System.Windows.Forms.Panel();
            this.AdminOrderPanel = new System.Windows.Forms.Panel();
            this.OrdertableAdmin = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).BeginInit();
            this.KlantOrderPanel.SuspendLayout();
            this.AdminOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdertableAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersTable
            // 
            this.OrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Filmtitel,
            this.Datum,
            this.Tijd,
            this.Zaal,
            this.Stoelnummer,
            this.Annuleer});
            this.OrdersTable.Location = new System.Drawing.Point(12, 12);
            this.OrdersTable.Name = "OrdersTable";
            this.OrdersTable.RowHeadersWidth = 82;
            this.OrdersTable.Size = new System.Drawing.Size(1552, 574);
            this.OrdersTable.TabIndex = 0;
            this.OrdersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Filmtitel
            // 
            this.Filmtitel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Filmtitel.HeaderText = "Film";
            this.Filmtitel.Name = "Filmtitel";
            this.Filmtitel.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Tijd
            // 
            this.Tijd.HeaderText = "Tijd";
            this.Tijd.Name = "Tijd";
            this.Tijd.ReadOnly = true;
            // 
            // Zaal
            // 
            this.Zaal.HeaderText = "Zaal";
            this.Zaal.Name = "Zaal";
            this.Zaal.ReadOnly = true;
            // 
            // Stoelnummer
            // 
            this.Stoelnummer.HeaderText = "Stoelnummer";
            this.Stoelnummer.Name = "Stoelnummer";
            this.Stoelnummer.ReadOnly = true;
            // 
            // Annuleer
            // 
            this.Annuleer.HeaderText = "Annuleer";
            this.Annuleer.MinimumWidth = 10;
            this.Annuleer.Name = "Annuleer";
            this.Annuleer.ReadOnly = true;
            this.Annuleer.Text = "";
            this.Annuleer.Width = 200;
            // 
            // KlantOrderPanel
            // 
            this.KlantOrderPanel.Controls.Add(this.OrdersTable);
            this.KlantOrderPanel.Location = new System.Drawing.Point(2, 2);
            this.KlantOrderPanel.Name = "KlantOrderPanel";
            this.KlantOrderPanel.Size = new System.Drawing.Size(1575, 594);
            this.KlantOrderPanel.TabIndex = 1;
            // 
            // AdminOrderPanel
            // 
            this.AdminOrderPanel.Controls.Add(this.OrdertableAdmin);
            this.AdminOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminOrderPanel.Name = "AdminOrderPanel";
            this.AdminOrderPanel.Size = new System.Drawing.Size(1569, 591);
            this.AdminOrderPanel.TabIndex = 1;
            // 
            // OrdertableAdmin
            // 
            this.OrdertableAdmin.AllowUserToAddRows = false;
            this.OrdertableAdmin.AllowUserToDeleteRows = false;
            this.OrdertableAdmin.AllowUserToResizeColumns = false;
            this.OrdertableAdmin.AllowUserToResizeRows = false;
            this.OrdertableAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdertableAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn1});
            this.OrdertableAdmin.Location = new System.Drawing.Point(8, 8);
            this.OrdertableAdmin.Name = "OrdertableAdmin";
            this.OrdertableAdmin.RowHeadersWidth = 82;
            this.OrdertableAdmin.Size = new System.Drawing.Size(1552, 574);
            this.OrdertableAdmin.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Film";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Gebruiker";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tijd";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Zaal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Stoelnummer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Annuleer";
            this.dataGridViewButtonColumn1.MinimumWidth = 10;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "";
            this.dataGridViewButtonColumn1.Width = 200;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 598);
            this.Controls.Add(this.AdminOrderPanel);
            this.Controls.Add(this.KlantOrderPanel);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).EndInit();
            this.KlantOrderPanel.ResumeLayout(false);
            this.AdminOrderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdertableAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filmtitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stoelnummer;
        private System.Windows.Forms.DataGridViewButtonColumn Annuleer;
        private System.Windows.Forms.Panel KlantOrderPanel;
        private System.Windows.Forms.Panel AdminOrderPanel;
        private System.Windows.Forms.DataGridView OrdertableAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}