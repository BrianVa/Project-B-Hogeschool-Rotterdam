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
            this.loggen_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.login_button = new System.Windows.Forms.ToolStripMenuItem();
            this.aanmeld_button = new System.Windows.Forms.ToolStripMenuItem();
            this.mijnAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.info_button = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.featured_5 = new System.Windows.Forms.PictureBox();
            this.featured_4 = new System.Windows.Forms.PictureBox();
            this.featured_1 = new System.Windows.Forms.PictureBox();
            this.featured_2 = new System.Windows.Forms.PictureBox();
            this.featured_3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.BitfilmTekst = new System.Windows.Forms.Label();
            this.BackLoop = new System.Windows.Forms.PictureBox();
            this.show_film_panel = new System.Windows.Forms.Panel();
            this.Kijkwijzer = new System.Windows.Forms.PictureBox();
            this.film_genre = new System.Windows.Forms.Label();
            this.TrailerVideo = new System.Windows.Forms.WebBrowser();
            this.film_speelduur = new System.Windows.Forms.Label();
            this.film_desc = new System.Windows.Forms.RichTextBox();
            this.OrderTijdButton = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.searched_movie = new System.Windows.Forms.PictureBox();
            this.film_speelduur_title = new System.Windows.Forms.Label();
            this.film_genre_title = new System.Windows.Forms.Label();
            this.film_name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TijdPanel = new System.Windows.Forms.Panel();
            this.TicketBack = new System.Windows.Forms.Button();
            this.FilmTijden = new System.Windows.Forms.DataGridView();
            this.SecondeTimer = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featured_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featured_3)).BeginInit();
            this.Main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackLoop)).BeginInit();
            this.show_film_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kijkwijzer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searched_movie)).BeginInit();
            this.TijdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmTijden)).BeginInit();
            this.SuspendLayout();
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.Location = new System.Drawing.Point(1142, 13);
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
            this.loggen_menu,
            this.about_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 24);
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
            // loggen_menu
            // 
            this.loggen_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login_button,
            this.aanmeld_button,
            this.mijnAccountToolStripMenuItem});
            this.loggen_menu.Name = "loggen_menu";
            this.loggen_menu.Size = new System.Drawing.Size(64, 20);
            this.loggen_menu.Text = "Account";
            this.loggen_menu.Click += new System.EventHandler(this.loggen_menu_Click);
            // 
            // login_button
            // 
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(146, 22);
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // aanmeld_button
            // 
            this.aanmeld_button.Name = "aanmeld_button";
            this.aanmeld_button.Size = new System.Drawing.Size(146, 22);
            this.aanmeld_button.Text = "Aanmelden";
            this.aanmeld_button.Click += new System.EventHandler(this.aanmeld_button_Click);
            // 
            // mijnAccountToolStripMenuItem
            // 
            this.mijnAccountToolStripMenuItem.Name = "mijnAccountToolStripMenuItem";
            this.mijnAccountToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.mijnAccountToolStripMenuItem.Text = "Mijn Account";
            this.mijnAccountToolStripMenuItem.Click += new System.EventHandler(this.mijnAccountToolStripMenuItem_Click);
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
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(906, 13);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(230, 20);
            this.SearchBox.TabIndex = 10;
            // 
            // featured_5
            // 
            this.featured_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.featured_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.featured_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featured_5.Image = ((System.Drawing.Image)(resources.GetObject("featured_5.Image")));
            this.featured_5.Location = new System.Drawing.Point(1020, 100);
            this.featured_5.Name = "featured_5";
            this.featured_5.Size = new System.Drawing.Size(180, 254);
            this.featured_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.featured_5.TabIndex = 9;
            this.featured_5.TabStop = false;
            this.featured_5.Click += new System.EventHandler(this.featured_5_Click);
            // 
            // featured_4
            // 
            this.featured_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.featured_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.featured_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featured_4.Image = ((System.Drawing.Image)(resources.GetObject("featured_4.Image")));
            this.featured_4.Location = new System.Drawing.Point(780, 100);
            this.featured_4.Name = "featured_4";
            this.featured_4.Size = new System.Drawing.Size(180, 254);
            this.featured_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.featured_4.TabIndex = 8;
            this.featured_4.TabStop = false;
            this.featured_4.Click += new System.EventHandler(this.featured_4_Click);
            // 
            // featured_1
            // 
            this.featured_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.featured_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.featured_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featured_1.Image = ((System.Drawing.Image)(resources.GetObject("featured_1.Image")));
            this.featured_1.Location = new System.Drawing.Point(60, 100);
            this.featured_1.Name = "featured_1";
            this.featured_1.Size = new System.Drawing.Size(180, 254);
            this.featured_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.featured_1.TabIndex = 7;
            this.featured_1.TabStop = false;
            this.featured_1.Click += new System.EventHandler(this.featured_1_Click);
            // 
            // featured_2
            // 
            this.featured_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.featured_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.featured_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featured_2.Image = ((System.Drawing.Image)(resources.GetObject("featured_2.Image")));
            this.featured_2.Location = new System.Drawing.Point(300, 100);
            this.featured_2.Name = "featured_2";
            this.featured_2.Size = new System.Drawing.Size(180, 254);
            this.featured_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.featured_2.TabIndex = 6;
            this.featured_2.TabStop = false;
            this.featured_2.Click += new System.EventHandler(this.featured_2_Click);
            // 
            // featured_3
            // 
            this.featured_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.featured_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.featured_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featured_3.Image = ((System.Drawing.Image)(resources.GetObject("featured_3.Image")));
            this.featured_3.Location = new System.Drawing.Point(540, 100);
            this.featured_3.Name = "featured_3";
            this.featured_3.Size = new System.Drawing.Size(180, 254);
            this.featured_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.featured_3.TabIndex = 5;
            this.featured_3.TabStop = false;
            this.featured_3.Click += new System.EventHandler(this.featured_3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(750, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "No time to die";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(30, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bad Boys for life";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(990, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sonic";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "SONIC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(510, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Birds of prey";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_panel
            // 
            this.Main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_panel.Controls.Add(this.BitfilmTekst);
            this.Main_panel.Controls.Add(this.featured_3);
            this.Main_panel.Controls.Add(this.featured_2);
            this.Main_panel.Controls.Add(this.search_button);
            this.Main_panel.Controls.Add(this.SearchBox);
            this.Main_panel.Controls.Add(this.label3);
            this.Main_panel.Controls.Add(this.featured_1);
            this.Main_panel.Controls.Add(this.label2);
            this.Main_panel.Controls.Add(this.featured_4);
            this.Main_panel.Controls.Add(this.label5);
            this.Main_panel.Controls.Add(this.featured_5);
            this.Main_panel.Controls.Add(this.label1);
            this.Main_panel.Controls.Add(this.label4);
            this.Main_panel.Controls.Add(this.BackLoop);
            this.Main_panel.Location = new System.Drawing.Point(0, 24);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(1280, 720);
            this.Main_panel.TabIndex = 16;
            this.Main_panel.Visible = false;
            // 
            // BitfilmTekst
            // 
            this.BitfilmTekst.BackColor = System.Drawing.Color.White;
            this.BitfilmTekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BitfilmTekst.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitfilmTekst.Location = new System.Drawing.Point(510, 20);
            this.BitfilmTekst.Name = "BitfilmTekst";
            this.BitfilmTekst.Size = new System.Drawing.Size(240, 60);
            this.BitfilmTekst.TabIndex = 16;
            this.BitfilmTekst.Text = "BITFILM";
            this.BitfilmTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackLoop
            // 
            this.BackLoop.Image = ((System.Drawing.Image)(resources.GetObject("BackLoop.Image")));
            this.BackLoop.Location = new System.Drawing.Point(-1280, 0);
            this.BackLoop.Name = "BackLoop";
            this.BackLoop.Size = new System.Drawing.Size(2560, 720);
            this.BackLoop.TabIndex = 17;
            this.BackLoop.TabStop = false;
            // 
            // show_film_panel
            // 
            this.show_film_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.show_film_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.show_film_panel.BackColor = System.Drawing.Color.Transparent;
            this.show_film_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_film_panel.BackgroundImage")));
            this.show_film_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_film_panel.Controls.Add(this.Kijkwijzer);
            this.show_film_panel.Controls.Add(this.film_genre);
            this.show_film_panel.Controls.Add(this.TrailerVideo);
            this.show_film_panel.Controls.Add(this.film_speelduur);
            this.show_film_panel.Controls.Add(this.film_desc);
            this.show_film_panel.Controls.Add(this.OrderTijdButton);
            this.show_film_panel.Controls.Add(this.Back_button);
            this.show_film_panel.Controls.Add(this.searched_movie);
            this.show_film_panel.Controls.Add(this.film_speelduur_title);
            this.show_film_panel.Controls.Add(this.film_genre_title);
            this.show_film_panel.Controls.Add(this.film_name);
            this.show_film_panel.Location = new System.Drawing.Point(0, 24);
            this.show_film_panel.Name = "show_film_panel";
            this.show_film_panel.Size = new System.Drawing.Size(1280, 720);
            this.show_film_panel.TabIndex = 16;
            this.show_film_panel.Visible = false;
            // 
            // Kijkwijzer
            // 
            this.Kijkwijzer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Kijkwijzer.Image = ((System.Drawing.Image)(resources.GetObject("Kijkwijzer.Image")));
            this.Kijkwijzer.Location = new System.Drawing.Point(447, 561);
            this.Kijkwijzer.Name = "Kijkwijzer";
            this.Kijkwijzer.Size = new System.Drawing.Size(100, 100);
            this.Kijkwijzer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kijkwijzer.TabIndex = 13;
            this.Kijkwijzer.TabStop = false;
            // 
            // film_genre
            // 
            this.film_genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.film_genre.AutoSize = true;
            this.film_genre.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_genre.ForeColor = System.Drawing.Color.White;
            this.film_genre.Location = new System.Drawing.Point(615, 465);
            this.film_genre.Name = "film_genre";
            this.film_genre.Size = new System.Drawing.Size(150, 47);
            this.film_genre.TabIndex = 10;
            this.film_genre.Text = "Genre: ";
            // 
            // TrailerVideo
            // 
            this.TrailerVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TrailerVideo.Location = new System.Drawing.Point(15, 465);
            this.TrailerVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.TrailerVideo.Name = "TrailerVideo";
            this.TrailerVideo.ScrollBarsEnabled = false;
            this.TrailerVideo.Size = new System.Drawing.Size(426, 240);
            this.TrailerVideo.TabIndex = 12;
            // 
            // film_speelduur
            // 
            this.film_speelduur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.film_speelduur.AutoSize = true;
            this.film_speelduur.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_speelduur.ForeColor = System.Drawing.Color.White;
            this.film_speelduur.Location = new System.Drawing.Point(588, 505);
            this.film_speelduur.Name = "film_speelduur";
            this.film_speelduur.Size = new System.Drawing.Size(128, 47);
            this.film_speelduur.TabIndex = 11;
            this.film_speelduur.Text = "Duur: ";
            // 
            // film_desc
            // 
            this.film_desc.BackColor = System.Drawing.Color.DarkGray;
            this.film_desc.Cursor = System.Windows.Forms.Cursors.Default;
            this.film_desc.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_desc.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.film_desc.Location = new System.Drawing.Point(224, 64);
            this.film_desc.MaxLength = 380;
            this.film_desc.Name = "film_desc";
            this.film_desc.ReadOnly = true;
            this.film_desc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.film_desc.Size = new System.Drawing.Size(570, 216);
            this.film_desc.TabIndex = 9;
            this.film_desc.Text = "";
            // 
            // OrderTijdButton
            // 
            this.OrderTijdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderTijdButton.Location = new System.Drawing.Point(907, 667);
            this.OrderTijdButton.Name = "OrderTijdButton";
            this.OrderTijdButton.Size = new System.Drawing.Size(356, 38);
            this.OrderTijdButton.TabIndex = 8;
            this.OrderTijdButton.Text = "Bekijk Tickets";
            this.OrderTijdButton.UseVisualStyleBackColor = true;
            this.OrderTijdButton.Click += new System.EventHandler(this.OrderTijdButton_Click);
            // 
            // Back_button
            // 
            this.Back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back_button.Location = new System.Drawing.Point(447, 667);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(185, 38);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // searched_movie
            // 
            this.searched_movie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searched_movie.Image = ((System.Drawing.Image)(resources.GetObject("searched_movie.Image")));
            this.searched_movie.Location = new System.Drawing.Point(15, 15);
            this.searched_movie.Name = "searched_movie";
            this.searched_movie.Size = new System.Drawing.Size(195, 265);
            this.searched_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searched_movie.TabIndex = 6;
            this.searched_movie.TabStop = false;
            // 
            // film_speelduur_title
            // 
            this.film_speelduur_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.film_speelduur_title.AutoSize = true;
            this.film_speelduur_title.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_speelduur_title.ForeColor = System.Drawing.Color.White;
            this.film_speelduur_title.Location = new System.Drawing.Point(447, 505);
            this.film_speelduur_title.Name = "film_speelduur_title";
            this.film_speelduur_title.Size = new System.Drawing.Size(128, 47);
            this.film_speelduur_title.TabIndex = 2;
            this.film_speelduur_title.Text = "Duur: ";
            // 
            // film_genre_title
            // 
            this.film_genre_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.film_genre_title.AutoSize = true;
            this.film_genre_title.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_genre_title.ForeColor = System.Drawing.Color.White;
            this.film_genre_title.Location = new System.Drawing.Point(447, 465);
            this.film_genre_title.Name = "film_genre_title";
            this.film_genre_title.Size = new System.Drawing.Size(150, 47);
            this.film_genre_title.TabIndex = 1;
            this.film_genre_title.Text = "Genre: ";
            // 
            // film_name
            // 
            this.film_name.AutoSize = true;
            this.film_name.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_name.ForeColor = System.Drawing.Color.White;
            this.film_name.Location = new System.Drawing.Point(216, 15);
            this.film_name.Name = "film_name";
            this.film_name.Size = new System.Drawing.Size(210, 47);
            this.film_name.TabIndex = 0;
            this.film_name.Text = "Film name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TijdPanel
            // 
            this.TijdPanel.BackColor = System.Drawing.Color.Transparent;
            this.TijdPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TijdPanel.BackgroundImage")));
            this.TijdPanel.Controls.Add(this.TicketBack);
            this.TijdPanel.Controls.Add(this.FilmTijden);
            this.TijdPanel.Location = new System.Drawing.Point(0, 24);
            this.TijdPanel.Name = "TijdPanel";
            this.TijdPanel.Size = new System.Drawing.Size(1280, 720);
            this.TijdPanel.TabIndex = 16;
            this.TijdPanel.Visible = false;
            // 
            // TicketBack
            // 
            this.TicketBack.Location = new System.Drawing.Point(10, 665);
            this.TicketBack.Name = "TicketBack";
            this.TicketBack.Size = new System.Drawing.Size(200, 40);
            this.TicketBack.TabIndex = 1;
            this.TicketBack.Text = "Back";
            this.TicketBack.UseVisualStyleBackColor = true;
            this.TicketBack.Click += new System.EventHandler(this.TicketBack_Click);
            // 
            // FilmTijden
            // 
            this.FilmTijden.AllowUserToAddRows = false;
            this.FilmTijden.AllowUserToDeleteRows = false;
            this.FilmTijden.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.FilmTijden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmTijden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.FilmTijden.GridColor = System.Drawing.Color.Black;
            this.FilmTijden.Location = new System.Drawing.Point(15, 20);
            this.FilmTijden.Name = "FilmTijden";
            this.FilmTijden.Size = new System.Drawing.Size(690, 260);
            this.FilmTijden.TabIndex = 0;
            this.FilmTijden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmTijden_CellContentClick);
            // 
            // SecondeTimer
            // 
            this.SecondeTimer.Enabled = true;
            this.SecondeTimer.Interval = 25;
            this.SecondeTimer.Tick += new System.EventHandler(this.SecondeTimer_Tick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Datum";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tijd";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Zaal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Select";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 50;
            // 
            // StoelenPanel
            // 
            this.StoelenPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoelenPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StoelenPanel.BackgroundImage")));
            this.StoelenPanel.Controls.Add(this.StoelBackButton);
            this.StoelenPanel.Controls.Add(this.dataGridView2);
            this.StoelenPanel.Controls.Add(this.dataGridView1);
            this.StoelenPanel.Location = new System.Drawing.Point(0, 0);
            this.StoelenPanel.Name = "StoelenPanel";
            this.StoelenPanel.Size = new System.Drawing.Size(1280, 720);
            this.StoelenPanel.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(15, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2.Location = new System.Drawing.Point(486, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(440, 312);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // StoelBackButton
            // 
            this.StoelBackButton.Location = new System.Drawing.Point(15, 665);
            this.StoelBackButton.Name = "StoelBackButton";
            this.StoelBackButton.Size = new System.Drawing.Size(200, 40);
            this.StoelBackButton.TabIndex = 2;
            this.StoelBackButton.Text = "Back";
            this.StoelBackButton.UseVisualStyleBackColor = true;
            this.StoelBackButton.Click += new System.EventHandler(this.StoelBackButton_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1279, 743);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TijdPanel);
            this.Controls.Add(this.show_film_panel);
            this.Controls.Add(this.Main_panel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.BackLoop)).EndInit();
            this.show_film_panel.ResumeLayout(false);
            this.show_film_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kijkwijzer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searched_movie)).EndInit();
            this.TijdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilmTijden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_button;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_menu;
        private System.Windows.Forms.ToolStripMenuItem info_button;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox featured_5;
        private System.Windows.Forms.PictureBox featured_4;
        private System.Windows.Forms.PictureBox featured_1;
        private System.Windows.Forms.PictureBox featured_2;
        private System.Windows.Forms.PictureBox featured_3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Panel show_film_panel;
        private System.Windows.Forms.Label film_name;
        private System.Windows.Forms.Label film_speelduur_title;
        private System.Windows.Forms.Label film_genre_title;
        private System.Windows.Forms.PictureBox searched_movie;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button OrderTijdButton;
        private System.Windows.Forms.RichTextBox film_desc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label film_speelduur;
        private System.Windows.Forms.Label film_genre;
        private System.Windows.Forms.WebBrowser TrailerVideo;
        private System.Windows.Forms.PictureBox Kijkwijzer;
        private System.Windows.Forms.Label BitfilmTekst;
        private System.Windows.Forms.Panel TijdPanel;
        private System.Windows.Forms.DataGridView FilmTijden;
        private System.Windows.Forms.Button TicketBack;
        private System.Windows.Forms.Timer SecondeTimer;
        private System.Windows.Forms.PictureBox BackLoop;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem loggen_menu;
        public System.Windows.Forms.ToolStripMenuItem login_button;
        public System.Windows.Forms.ToolStripMenuItem aanmeld_button;
        public System.Windows.Forms.ToolStripMenuItem mijnAccountToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}

