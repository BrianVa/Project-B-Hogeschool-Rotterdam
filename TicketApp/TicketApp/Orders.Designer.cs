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
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).BeginInit();
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
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 598);
            this.Controls.Add(this.OrdersTable);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).EndInit();
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
    }
}