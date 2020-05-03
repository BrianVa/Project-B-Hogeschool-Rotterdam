namespace TicketApp
{
    partial class signup
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
            this.components = new System.ComponentModel.Container();
            this.voornaam_field = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.email_field = new System.Windows.Forms.TextBox();
            this.achternaam_field = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password_r_field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aanmeld_button = new System.Windows.Forms.Button();
            this.Agefield = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voornaam_field
            // 
            this.voornaam_field.Location = new System.Drawing.Point(116, 46);
            this.voornaam_field.Name = "voornaam_field";
            this.voornaam_field.Size = new System.Drawing.Size(193, 20);
            this.voornaam_field.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // email_field
            // 
            this.email_field.Location = new System.Drawing.Point(116, 154);
            this.email_field.Name = "email_field";
            this.email_field.Size = new System.Drawing.Size(193, 20);
            this.email_field.TabIndex = 2;
            // 
            // achternaam_field
            // 
            this.achternaam_field.Location = new System.Drawing.Point(116, 98);
            this.achternaam_field.Name = "achternaam_field";
            this.achternaam_field.Size = new System.Drawing.Size(193, 20);
            this.achternaam_field.TabIndex = 3;
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(116, 265);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(193, 20);
            this.password_field.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wachtwoord";
            // 
            // password_r_field
            // 
            this.password_r_field.Location = new System.Drawing.Point(116, 320);
            this.password_r_field.Name = "password_r_field";
            this.password_r_field.PasswordChar = '*';
            this.password_r_field.Size = new System.Drawing.Size(193, 20);
            this.password_r_field.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Herhaal wachtwoord";
            // 
            // aanmeld_button
            // 
            this.aanmeld_button.Location = new System.Drawing.Point(369, 385);
            this.aanmeld_button.Name = "aanmeld_button";
            this.aanmeld_button.Size = new System.Drawing.Size(75, 23);
            this.aanmeld_button.TabIndex = 11;
            this.aanmeld_button.Text = "aanmelden";
            this.aanmeld_button.UseVisualStyleBackColor = true;
            this.aanmeld_button.Click += new System.EventHandler(this.aanmeld_Click);
            // 
            // Agefield
            // 
            this.Agefield.ContextMenuStrip = this.contextMenuStrip1;
            this.Agefield.CustomFormat = "dd/MM/yyyy";
            this.Agefield.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Agefield.Location = new System.Drawing.Point(116, 212);
            this.Agefield.MaxDate = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.Agefield.Name = "Agefield";
            this.Agefield.Size = new System.Drawing.Size(200, 20);
            this.Agefield.TabIndex = 12;
            this.Agefield.Value = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Geboorte Datum";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 420);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Agefield);
            this.Controls.Add(this.aanmeld_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_r_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.achternaam_field);
            this.Controls.Add(this.email_field);
            this.Controls.Add(this.voornaam_field);
            this.Name = "signup";
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox voornaam_field;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox email_field;
        private System.Windows.Forms.TextBox achternaam_field;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_r_field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button aanmeld_button;
        private System.Windows.Forms.DateTimePicker Agefield;
        private System.Windows.Forms.Label label6;
    }
}