namespace TicketApp
{
    partial class BitFilm
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Login_button = new System.Windows.Forms.ToolStripMenuItem();
            this.aanmelden_button = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_button = new System.Windows.Forms.ToolStripMenuItem();
            this.search_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1442, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_button});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Exit_button
            // 
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(93, 22);
            this.Exit_button.Text = "Exit";
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login_button,
            this.aanmelden_button});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // Login_button
            // 
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(180, 22);
            this.Login_button.Text = "Login";
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // aanmelden_button
            // 
            this.aanmelden_button.Name = "aanmelden_button";
            this.aanmelden_button.Size = new System.Drawing.Size(180, 22);
            this.aanmelden_button.Text = "Aanmelden";
            this.aanmelden_button.Click += new System.EventHandler(this.aanmelden_button_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info_button});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // info_button
            // 
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(180, 22);
            this.info_button.Text = "Informatie";
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // search_box
            // 
            this.search_box.AcceptsReturn = true;
            this.search_box.Location = new System.Drawing.Point(1071, 50);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(278, 20);
            this.search_box.TabIndex = 2;
            this.search_box.Text = "Browse Movies.......";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1355, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BitFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1442, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "BitFilm";
            this.Text = "BitFilm";
            this.Load += new System.EventHandler(this.BitFilm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_button;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Login_button;
        private System.Windows.Forms.ToolStripMenuItem aanmelden_button;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem info_button;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button button1;
    }
}



