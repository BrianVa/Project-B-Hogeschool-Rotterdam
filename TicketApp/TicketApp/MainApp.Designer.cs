namespace TicketApp
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.search_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggen_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.login_button = new System.Windows.Forms.ToolStripMenuItem();
            this.aanmeld_button = new System.Windows.Forms.ToolStripMenuItem();
            this.about_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.info_button = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.featured_5 = new System.Windows.Forms.PictureBox();
            this.featured_4 = new System.Windows.Forms.PictureBox();
            this.featured_1 = new System.Windows.Forms.PictureBox();
            this.featured_2 = new System.Windows.Forms.PictureBox();
            this.featured_3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.show_film_panel = new System.Windows.Forms.Panel();
            this.film_desc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.searched_movie = new System.Windows.Forms.PictureBox();
            this.film_age = new System.Windows.Forms.Label();
            this.film_speelduur_title = new System.Windows.Forms.Label();
            this.film_genre_title = new System.Windows.Forms.Label();
            this.film_name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.film_genre = new System.Windows.Forms.Label();
            this.film_speelduur = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featured_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_3)).BeginInit();
            this.Main_panel.SuspendLayout();
            this.show_film_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searched_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.Location = new System.Drawing.Point(1015, 18);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(130, 20);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Browse Movies";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.loggen_menu,
            this.about_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_button});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exit_button
            // 
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(93, 22);
            this.exit_button.Text = "Exit";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // loggen_menu
            // 
            this.loggen_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login_button,
            this.aanmeld_button});
            this.loggen_menu.Name = "loggen_menu";
            this.loggen_menu.Size = new System.Drawing.Size(64, 20);
            this.loggen_menu.Text = "Account";
            // 
            // login_button
            // 
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(180, 22);
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // aanmeld_button
            // 
            this.aanmeld_button.Name = "aanmeld_button";
            this.aanmeld_button.Size = new System.Drawing.Size(180, 22);
            this.aanmeld_button.Text = "Aanmelden";
            this.aanmeld_button.Click += new System.EventHandler(this.aanmeld_button_Click);
            // 
            // about_menu
            // 
            this.about_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info_button});
            this.about_menu.Name = "about_menu";
            this.about_menu.Size = new System.Drawing.Size(52, 20);
            this.about_menu.Text = "About";
            // 
            // info_button
            // 
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(95, 22);
            this.info_button.Text = "Info";
            this.info_button.Click += new System.EventHandler(this.info_button_click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.info_button_click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(779, 18);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(230, 20);
            this.SearchBox.TabIndex = 10;
            // 
            // featured_5
            // 
            this.featured_5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featured_5.Image = ((System.Drawing.Image)(resources.GetObject("featured_5.Image")));
            this.featured_5.Location = new System.Drawing.Point(954, 113);
            this.featured_5.Name = "featured_5";
            this.featured_5.Size = new System.Drawing.Size(182, 256);
            this.featured_5.TabIndex = 9;
            this.featured_5.TabStop = false;
            this.featured_5.Click += new System.EventHandler(this.featured_5_Click);
            // 
            // featured_4
            // 
            this.featured_4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featured_4.Image = ((System.Drawing.Image)(resources.GetObject("featured_4.Image")));
            this.featured_4.Location = new System.Drawing.Point(730, 112);
            this.featured_4.Name = "featured_4";
            this.featured_4.Size = new System.Drawing.Size(176, 255);
            this.featured_4.TabIndex = 8;
            this.featured_4.TabStop = false;
            this.featured_4.Click += new System.EventHandler(this.featured_4_Click);
            // 
            // featured_1
            // 
            this.featured_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featured_1.Image = ((System.Drawing.Image)(resources.GetObject("featured_1.Image")));
            this.featured_1.Location = new System.Drawing.Point(61, 111);
            this.featured_1.Name = "featured_1";
            this.featured_1.Size = new System.Drawing.Size(181, 256);
            this.featured_1.TabIndex = 7;
            this.featured_1.TabStop = false;
            this.featured_1.Click += new System.EventHandler(this.featured_1_Click);
            // 
            // featured_2
            // 
            this.featured_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featured_2.Image = ((System.Drawing.Image)(resources.GetObject("featured_2.Image")));
            this.featured_2.Location = new System.Drawing.Point(294, 113);
            this.featured_2.Name = "featured_2";
            this.featured_2.Size = new System.Drawing.Size(181, 255);
            this.featured_2.TabIndex = 6;
            this.featured_2.TabStop = false;
            this.featured_2.Click += new System.EventHandler(this.featured_2_Click);
            // 
            // featured_3
            // 
            this.featured_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featured_3.Image = ((System.Drawing.Image)(resources.GetObject("featured_3.Image")));
            this.featured_3.Location = new System.Drawing.Point(522, 111);
            this.featured_3.Name = "featured_3";
            this.featured_3.Size = new System.Drawing.Size(177, 256);
            this.featured_3.TabIndex = 5;
            this.featured_3.TabStop = false;
            this.featured_3.Click += new System.EventHandler(this.featured_3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(735, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "No time to die";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bad Boys for life";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1015, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sonic";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(272, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "The boy brahm\'s curse";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(533, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Birds of prey";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_panel
            // 
            this.Main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_panel.Controls.Add(this.featured_3);
            this.Main_panel.Controls.Add(this.featured_2);
            this.Main_panel.Controls.Add(this.search_button);
            this.Main_panel.Controls.Add(this.SearchBox);
            this.Main_panel.Controls.Add(this.label5);
            this.Main_panel.Controls.Add(this.featured_1);
            this.Main_panel.Controls.Add(this.label4);
            this.Main_panel.Controls.Add(this.featured_4);
            this.Main_panel.Controls.Add(this.label3);
            this.Main_panel.Controls.Add(this.featured_5);
            this.Main_panel.Controls.Add(this.label2);
            this.Main_panel.Controls.Add(this.label1);
            this.Main_panel.Location = new System.Drawing.Point(12, 36);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(1155, 543);
            this.Main_panel.TabIndex = 16;
            // 
            // show_film_panel
            // 
            this.show_film_panel.Controls.Add(this.film_speelduur);
            this.show_film_panel.Controls.Add(this.film_genre);
            this.show_film_panel.Controls.Add(this.film_desc);
            this.show_film_panel.Controls.Add(this.button1);
            this.show_film_panel.Controls.Add(this.Back_button);
            this.show_film_panel.Controls.Add(this.searched_movie);
            this.show_film_panel.Controls.Add(this.film_age);
            this.show_film_panel.Controls.Add(this.film_speelduur_title);
            this.show_film_panel.Controls.Add(this.film_genre_title);
            this.show_film_panel.Controls.Add(this.film_name);
            this.show_film_panel.Location = new System.Drawing.Point(0, 27);
            this.show_film_panel.Name = "show_film_panel";
            this.show_film_panel.Size = new System.Drawing.Size(1174, 564);
            this.show_film_panel.TabIndex = 16;
            // 
            // film_desc
            // 
            this.film_desc.BackColor = System.Drawing.Color.Maroon;
            this.film_desc.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.film_desc.Location = new System.Drawing.Point(318, 104);
            this.film_desc.Name = "film_desc";
            this.film_desc.Size = new System.Drawing.Size(297, 216);
            this.film_desc.TabIndex = 9;
            this.film_desc.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1027, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Bekijk Tickets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(41, 507);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(94, 30);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // searched_movie
            // 
            this.searched_movie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searched_movie.Image = ((System.Drawing.Image)(resources.GetObject("searched_movie.Image")));
            this.searched_movie.Location = new System.Drawing.Point(15, 55);
            this.searched_movie.Name = "searched_movie";
            this.searched_movie.Size = new System.Drawing.Size(180, 256);
            this.searched_movie.TabIndex = 6;
            this.searched_movie.TabStop = false;
            // 
            // film_age
            // 
            this.film_age.AutoSize = true;
            this.film_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.film_age.ForeColor = System.Drawing.Color.White;
            this.film_age.Location = new System.Drawing.Point(313, 471);
            this.film_age.Name = "film_age";
            this.film_age.Size = new System.Drawing.Size(85, 25);
            this.film_age.TabIndex = 3;
            this.film_age.Text = "Leeftijd: ";
            // 
            // film_speelduur_title
            // 
            this.film_speelduur_title.AutoSize = true;
            this.film_speelduur_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.film_speelduur_title.ForeColor = System.Drawing.Color.White;
            this.film_speelduur_title.Location = new System.Drawing.Point(313, 403);
            this.film_speelduur_title.Name = "film_speelduur_title";
            this.film_speelduur_title.Size = new System.Drawing.Size(65, 25);
            this.film_speelduur_title.TabIndex = 2;
            this.film_speelduur_title.Text = "Duur: ";
            // 
            // film_genre_title
            // 
            this.film_genre_title.AutoSize = true;
            this.film_genre_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.film_genre_title.ForeColor = System.Drawing.Color.White;
            this.film_genre_title.Location = new System.Drawing.Point(313, 341);
            this.film_genre_title.Name = "film_genre_title";
            this.film_genre_title.Size = new System.Drawing.Size(77, 25);
            this.film_genre_title.TabIndex = 1;
            this.film_genre_title.Text = "Genre: ";
            // 
            // film_name
            // 
            this.film_name.AutoSize = true;
            this.film_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.film_name.ForeColor = System.Drawing.Color.White;
            this.film_name.Location = new System.Drawing.Point(310, 55);
            this.film_name.Name = "film_name";
            this.film_name.Size = new System.Drawing.Size(205, 46);
            this.film_name.TabIndex = 0;
            this.film_name.Text = "Film name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // film_genre
            // 
            this.film_genre.AutoSize = true;
            this.film_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.film_genre.ForeColor = System.Drawing.Color.White;
            this.film_genre.Location = new System.Drawing.Point(313, 374);
            this.film_genre.Name = "film_genre";
            this.film_genre.Size = new System.Drawing.Size(77, 25);
            this.film_genre.TabIndex = 10;
            this.film_genre.Text = "Genre: ";
            // 
            // film_speelduur
            // 
            this.film_speelduur.AutoSize = true;
            this.film_speelduur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.film_speelduur.ForeColor = System.Drawing.Color.White;
            this.film_speelduur.Location = new System.Drawing.Point(313, 437);
            this.film_speelduur.Name = "film_speelduur";
            this.film_speelduur.Size = new System.Drawing.Size(65, 25);
            this.film_speelduur.TabIndex = 11;
            this.film_speelduur.Text = "Duur: ";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1174, 591);
            this.Controls.Add(this.show_film_panel);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.Text = "TicketApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featured_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_3)).EndInit();
            this.Main_panel.ResumeLayout(false);
            this.Main_panel.PerformLayout();
            this.show_film_panel.ResumeLayout(false);
            this.show_film_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searched_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_button;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggen_menu;
        private System.Windows.Forms.ToolStripMenuItem about_menu;
        private System.Windows.Forms.ToolStripMenuItem info_button;
        private System.Windows.Forms.ToolStripMenuItem login_button;
        private System.Windows.Forms.ToolStripMenuItem aanmeld_button;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox featured_5;
        private System.Windows.Forms.PictureBox featured_4;
        private System.Windows.Forms.PictureBox featured_1;
        private System.Windows.Forms.PictureBox featured_2;
        private System.Windows.Forms.PictureBox featured_3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Panel show_film_panel;
        private System.Windows.Forms.Label film_name;
        private System.Windows.Forms.Label film_age;
        private System.Windows.Forms.Label film_speelduur_title;
        private System.Windows.Forms.Label film_genre_title;
        private System.Windows.Forms.PictureBox searched_movie;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox film_desc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label film_speelduur;
        private System.Windows.Forms.Label film_genre;
    }
}

