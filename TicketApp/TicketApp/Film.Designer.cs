namespace TicketApp
{
    partial class Film
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
            System.Windows.Forms.Button FilmPoster;
            this.FilmAddPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.FilmBack = new System.Windows.Forms.Button();
            this.FilmBackLabel = new System.Windows.Forms.Label();
            this.FilmPosterLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilmDisc = new System.Windows.Forms.RichTextBox();
            this.FilmAddButton = new System.Windows.Forms.Button();
            this.FilmTime = new System.Windows.Forms.TextBox();
            this.FilmTrailer = new System.Windows.Forms.TextBox();
            this.FilmAge = new System.Windows.Forms.ComboBox();
            this.FilmGenre = new System.Windows.Forms.ComboBox();
            this.FilmNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilmOverzichtPanel = new System.Windows.Forms.Panel();
            this.FilmOverzichtTabel = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TijdAddPanel = new System.Windows.Forms.Panel();
            this.AddTime = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MovieAdd = new System.Windows.Forms.ComboBox();
            this.ZaalAdd = new System.Windows.Forms.ComboBox();
            this.FilmDate = new System.Windows.Forms.DateTimePicker();
            this.FilmPlayTime = new System.Windows.Forms.TextBox();
            FilmPoster = new System.Windows.Forms.Button();
            this.FilmAddPanel.SuspendLayout();
            this.FilmOverzichtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilmOverzichtTabel)).BeginInit();
            this.TijdAddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilmPoster
            // 
            FilmPoster.Location = new System.Drawing.Point(86, 532);
            FilmPoster.Name = "FilmPoster";
            FilmPoster.Size = new System.Drawing.Size(111, 27);
            FilmPoster.TabIndex = 6;
            FilmPoster.Text = "Film Poster";
            FilmPoster.UseVisualStyleBackColor = true;
            FilmPoster.Click += new System.EventHandler(this.FilmPoster_Click);
            // 
            // FilmAddPanel
            // 
            this.FilmAddPanel.Controls.Add(this.label9);
            this.FilmAddPanel.Controls.Add(this.FilmBack);
            this.FilmAddPanel.Controls.Add(this.FilmBackLabel);
            this.FilmAddPanel.Controls.Add(this.FilmPosterLabel);
            this.FilmAddPanel.Controls.Add(this.label6);
            this.FilmAddPanel.Controls.Add(this.label5);
            this.FilmAddPanel.Controls.Add(this.label4);
            this.FilmAddPanel.Controls.Add(this.label3);
            this.FilmAddPanel.Controls.Add(this.label2);
            this.FilmAddPanel.Controls.Add(this.FilmDisc);
            this.FilmAddPanel.Controls.Add(this.FilmAddButton);
            this.FilmAddPanel.Controls.Add(FilmPoster);
            this.FilmAddPanel.Controls.Add(this.FilmTime);
            this.FilmAddPanel.Controls.Add(this.FilmTrailer);
            this.FilmAddPanel.Controls.Add(this.FilmAge);
            this.FilmAddPanel.Controls.Add(this.FilmGenre);
            this.FilmAddPanel.Controls.Add(this.FilmNaam);
            this.FilmAddPanel.Controls.Add(this.label1);
            this.FilmAddPanel.Location = new System.Drawing.Point(9, 12);
            this.FilmAddPanel.Name = "FilmAddPanel";
            this.FilmAddPanel.Size = new System.Drawing.Size(1495, 838);
            this.FilmAddPanel.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(611, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Beschrijving";
            // 
            // FilmBack
            // 
            this.FilmBack.Location = new System.Drawing.Point(86, 599);
            this.FilmBack.Name = "FilmBack";
            this.FilmBack.Size = new System.Drawing.Size(111, 27);
            this.FilmBack.TabIndex = 17;
            this.FilmBack.Text = "Film Achterground";
            this.FilmBack.UseVisualStyleBackColor = true;
            this.FilmBack.Click += new System.EventHandler(this.FilmBack_Click);
            // 
            // FilmBackLabel
            // 
            this.FilmBackLabel.AutoSize = true;
            this.FilmBackLabel.Location = new System.Drawing.Point(246, 606);
            this.FilmBackLabel.Name = "FilmBackLabel";
            this.FilmBackLabel.Size = new System.Drawing.Size(33, 13);
            this.FilmBackLabel.TabIndex = 16;
            this.FilmBackLabel.Text = "Geen";
            // 
            // FilmPosterLabel
            // 
            this.FilmPosterLabel.AutoSize = true;
            this.FilmPosterLabel.Location = new System.Drawing.Point(246, 539);
            this.FilmPosterLabel.Name = "FilmPosterLabel";
            this.FilmPosterLabel.Size = new System.Drawing.Size(33, 13);
            this.FilmPosterLabel.TabIndex = 15;
            this.FilmPosterLabel.Text = "Geen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trailer (Youtube Code)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Speel duur (in minuten):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Leeftijd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naam:";
            // 
            // FilmDisc
            // 
            this.FilmDisc.Location = new System.Drawing.Point(614, 139);
            this.FilmDisc.Name = "FilmDisc";
            this.FilmDisc.Size = new System.Drawing.Size(391, 237);
            this.FilmDisc.TabIndex = 9;
            this.FilmDisc.Text = "";
            // 
            // FilmAddButton
            // 
            this.FilmAddButton.Location = new System.Drawing.Point(1231, 756);
            this.FilmAddButton.Name = "FilmAddButton";
            this.FilmAddButton.Size = new System.Drawing.Size(191, 63);
            this.FilmAddButton.TabIndex = 8;
            this.FilmAddButton.Text = "Toevoegen";
            this.FilmAddButton.UseVisualStyleBackColor = true;
            this.FilmAddButton.Click += new System.EventHandler(this.FilmAddButton_Click);
            // 
            // FilmTime
            // 
            this.FilmTime.Location = new System.Drawing.Point(86, 371);
            this.FilmTime.Name = "FilmTime";
            this.FilmTime.Size = new System.Drawing.Size(250, 20);
            this.FilmTime.TabIndex = 5;
            // 
            // FilmTrailer
            // 
            this.FilmTrailer.Location = new System.Drawing.Point(86, 449);
            this.FilmTrailer.Name = "FilmTrailer";
            this.FilmTrailer.Size = new System.Drawing.Size(250, 20);
            this.FilmTrailer.TabIndex = 4;
            // 
            // FilmAge
            // 
            this.FilmAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilmAge.FormattingEnabled = true;
            this.FilmAge.Location = new System.Drawing.Point(86, 288);
            this.FilmAge.Name = "FilmAge";
            this.FilmAge.Size = new System.Drawing.Size(250, 21);
            this.FilmAge.TabIndex = 3;
            // 
            // FilmGenre
            // 
            this.FilmGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilmGenre.FormattingEnabled = true;
            this.FilmGenre.Location = new System.Drawing.Point(86, 197);
            this.FilmGenre.Name = "FilmGenre";
            this.FilmGenre.Size = new System.Drawing.Size(250, 21);
            this.FilmGenre.TabIndex = 2;
            // 
            // FilmNaam
            // 
            this.FilmNaam.Location = new System.Drawing.Point(86, 139);
            this.FilmNaam.Name = "FilmNaam";
            this.FilmNaam.Size = new System.Drawing.Size(250, 20);
            this.FilmNaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(641, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Toevoegen";
            // 
            // FilmOverzichtPanel
            // 
            this.FilmOverzichtPanel.Controls.Add(this.FilmOverzichtTabel);
            this.FilmOverzichtPanel.Location = new System.Drawing.Point(12, 8);
            this.FilmOverzichtPanel.Name = "FilmOverzichtPanel";
            this.FilmOverzichtPanel.Size = new System.Drawing.Size(1484, 826);
            this.FilmOverzichtPanel.TabIndex = 19;
            // 
            // FilmOverzichtTabel
            // 
            this.FilmOverzichtTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmOverzichtTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.FilmOverzichtTabel.Location = new System.Drawing.Point(6, 13);
            this.FilmOverzichtTabel.Name = "FilmOverzichtTabel";
            this.FilmOverzichtTabel.RowHeadersWidth = 51;
            this.FilmOverzichtTabel.Size = new System.Drawing.Size(1475, 810);
            this.FilmOverzichtTabel.TabIndex = 0;
            this.FilmOverzichtTabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmOverzichtTabel_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Film Naam";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Film Genre";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Film Duur (in minuten)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Film Leeftijd";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Bekijk/Edit";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Verwijder";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // TijdAddPanel
            // 
            this.TijdAddPanel.Controls.Add(this.AddTime);
            this.TijdAddPanel.Controls.Add(this.label11);
            this.TijdAddPanel.Controls.Add(this.label10);
            this.TijdAddPanel.Controls.Add(this.label8);
            this.TijdAddPanel.Controls.Add(this.label7);
            this.TijdAddPanel.Controls.Add(this.MovieAdd);
            this.TijdAddPanel.Controls.Add(this.ZaalAdd);
            this.TijdAddPanel.Controls.Add(this.FilmDate);
            this.TijdAddPanel.Controls.Add(this.FilmPlayTime);
            this.TijdAddPanel.Location = new System.Drawing.Point(5, 8);
            this.TijdAddPanel.Name = "TijdAddPanel";
            this.TijdAddPanel.Size = new System.Drawing.Size(1491, 839);
            this.TijdAddPanel.TabIndex = 20;
            // 
            // AddTime
            // 
            this.AddTime.Location = new System.Drawing.Point(1264, 775);
            this.AddTime.Name = "AddTime";
            this.AddTime.Size = new System.Drawing.Size(162, 51);
            this.AddTime.TabIndex = 8;
            this.AddTime.Text = "Toevoegen";
            this.AddTime.UseVisualStyleBackColor = true;
            this.AddTime.Click += new System.EventHandler(this.AddTime_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(909, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Film:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(615, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Zaal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Film Speel Datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Film Speel Tijd:";
            // 
            // MovieAdd
            // 
            this.MovieAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieAdd.FormattingEnabled = true;
            this.MovieAdd.Location = new System.Drawing.Point(912, 66);
            this.MovieAdd.Name = "MovieAdd";
            this.MovieAdd.Size = new System.Drawing.Size(230, 21);
            this.MovieAdd.TabIndex = 3;
            // 
            // ZaalAdd
            // 
            this.ZaalAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZaalAdd.FormattingEnabled = true;
            this.ZaalAdd.Location = new System.Drawing.Point(618, 66);
            this.ZaalAdd.Name = "ZaalAdd";
            this.ZaalAdd.Size = new System.Drawing.Size(230, 21);
            this.ZaalAdd.TabIndex = 2;
            // 
            // FilmDate
            // 
            this.FilmDate.CustomFormat = "dd/MM/yyyy";
            this.FilmDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FilmDate.Location = new System.Drawing.Point(360, 67);
            this.FilmDate.Name = "FilmDate";
            this.FilmDate.Size = new System.Drawing.Size(200, 20);
            this.FilmDate.TabIndex = 1;
            // 
            // FilmPlayTime
            // 
            this.FilmPlayTime.Location = new System.Drawing.Point(46, 66);
            this.FilmPlayTime.Name = "FilmPlayTime";
            this.FilmPlayTime.Size = new System.Drawing.Size(237, 20);
            this.FilmPlayTime.TabIndex = 0;
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 846);
            this.Controls.Add(this.TijdAddPanel);
            this.Controls.Add(this.FilmOverzichtPanel);
            this.Controls.Add(this.FilmAddPanel);
            this.Name = "Film";
            this.Text = "Film";
            this.FilmAddPanel.ResumeLayout(false);
            this.FilmAddPanel.PerformLayout();
            this.FilmOverzichtPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilmOverzichtTabel)).EndInit();
            this.TijdAddPanel.ResumeLayout(false);
            this.TijdAddPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FilmAddPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button FilmBack;
        private System.Windows.Forms.Label FilmBackLabel;
        private System.Windows.Forms.Label FilmPosterLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox FilmDisc;
        private System.Windows.Forms.Button FilmAddButton;
        private System.Windows.Forms.TextBox FilmTime;
        private System.Windows.Forms.TextBox FilmTrailer;
        private System.Windows.Forms.ComboBox FilmAge;
        private System.Windows.Forms.ComboBox FilmGenre;
        private System.Windows.Forms.TextBox FilmNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FilmOverzichtPanel;
        private System.Windows.Forms.DataGridView FilmOverzichtTabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.Panel TijdAddPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MovieAdd;
        private System.Windows.Forms.ComboBox ZaalAdd;
        private System.Windows.Forms.DateTimePicker FilmDate;
        private System.Windows.Forms.TextBox FilmPlayTime;
        private System.Windows.Forms.Button AddTime;
    }
}