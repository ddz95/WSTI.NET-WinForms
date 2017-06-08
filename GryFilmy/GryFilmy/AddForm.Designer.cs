namespace GryFilmy
{
    partial class AddForm
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Games = new System.Windows.Forms.TabPage();
            this.GameAdd = new System.Windows.Forms.Button();
            this.GameProducer = new System.Windows.Forms.TextBox();
            this.ProducerLabel = new System.Windows.Forms.Label();
            this.GameDateLabel = new System.Windows.Forms.Label();
            this.GameDateTime = new System.Windows.Forms.DateTimePicker();
            this.GameAdult = new System.Windows.Forms.CheckBox();
            this.GamePrice = new System.Windows.Forms.NumericUpDown();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.GameType = new System.Windows.Forms.ComboBox();
            this.GameTypeLabel = new System.Windows.Forms.Label();
            this.GameName = new System.Windows.Forms.TextBox();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.Video = new System.Windows.Forms.TabPage();
            this.VideoAdd = new System.Windows.Forms.Button();
            this.VideoScenario = new System.Windows.Forms.TextBox();
            this.ScenarioLabel = new System.Windows.Forms.Label();
            this.VideoDirection = new System.Windows.Forms.TextBox();
            this.DirectionLabel = new System.Windows.Forms.Label();
            this.VideoAdult = new System.Windows.Forms.CheckBox();
            this.VideoDateTimeLabel = new System.Windows.Forms.Label();
            this.VideoDateTime = new System.Windows.Forms.DateTimePicker();
            this.VideoPrice = new System.Windows.Forms.NumericUpDown();
            this.VideoPriceLabel = new System.Windows.Forms.Label();
            this.VideoType = new System.Windows.Forms.ComboBox();
            this.VideoTypeLabel = new System.Windows.Forms.Label();
            this.VideoName = new System.Windows.Forms.TextBox();
            this.VideoNameLabel = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.TabPage();
            this.BookPagesLabel = new System.Windows.Forms.Label();
            this.BookPages = new System.Windows.Forms.NumericUpDown();
            this.BookAdult = new System.Windows.Forms.CheckBox();
            this.BookAdd = new System.Windows.Forms.Button();
            this.BookPubHouse = new System.Windows.Forms.TextBox();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.BookPubHouseLabel = new System.Windows.Forms.Label();
            this.BookAuthorLabel = new System.Windows.Forms.Label();
            this.BookDateTimeLabel = new System.Windows.Forms.Label();
            this.BookDateTime = new System.Windows.Forms.DateTimePicker();
            this.BookPrice = new System.Windows.Forms.NumericUpDown();
            this.BookPriceLabel = new System.Windows.Forms.Label();
            this.BookType = new System.Windows.Forms.ComboBox();
            this.BookTypeLabel = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.Games.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePrice)).BeginInit();
            this.Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPrice)).BeginInit();
            this.Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Games);
            this.Tabs.Controls.Add(this.Video);
            this.Tabs.Controls.Add(this.Book);
            this.Tabs.Location = new System.Drawing.Point(-3, -1);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(373, 223);
            this.Tabs.TabIndex = 0;
            // 
            // Games
            // 
            this.Games.Controls.Add(this.GameAdd);
            this.Games.Controls.Add(this.GameProducer);
            this.Games.Controls.Add(this.ProducerLabel);
            this.Games.Controls.Add(this.GameDateLabel);
            this.Games.Controls.Add(this.GameDateTime);
            this.Games.Controls.Add(this.GameAdult);
            this.Games.Controls.Add(this.GamePrice);
            this.Games.Controls.Add(this.PriceLabel);
            this.Games.Controls.Add(this.GameType);
            this.Games.Controls.Add(this.GameTypeLabel);
            this.Games.Controls.Add(this.GameName);
            this.Games.Controls.Add(this.GameNameLabel);
            this.Games.Location = new System.Drawing.Point(4, 22);
            this.Games.Name = "Games";
            this.Games.Padding = new System.Windows.Forms.Padding(3);
            this.Games.Size = new System.Drawing.Size(365, 197);
            this.Games.TabIndex = 0;
            this.Games.Text = "Gra";
            this.Games.UseVisualStyleBackColor = true;
            // 
            // GameAdd
            // 
            this.GameAdd.Location = new System.Drawing.Point(11, 137);
            this.GameAdd.Name = "GameAdd";
            this.GameAdd.Size = new System.Drawing.Size(337, 35);
            this.GameAdd.TabIndex = 11;
            this.GameAdd.Text = "Dodaj grę";
            this.GameAdd.UseVisualStyleBackColor = true;
            this.GameAdd.Click += new System.EventHandler(this.GameAdd_Click);
            // 
            // GameProducer
            // 
            this.GameProducer.Location = new System.Drawing.Point(11, 98);
            this.GameProducer.Name = "GameProducer";
            this.GameProducer.Size = new System.Drawing.Size(287, 20);
            this.GameProducer.TabIndex = 10;
            // 
            // ProducerLabel
            // 
            this.ProducerLabel.AutoSize = true;
            this.ProducerLabel.Location = new System.Drawing.Point(142, 82);
            this.ProducerLabel.Name = "ProducerLabel";
            this.ProducerLabel.Size = new System.Drawing.Size(59, 13);
            this.ProducerLabel.TabIndex = 9;
            this.ProducerLabel.Text = "Producent:";
            // 
            // GameDateLabel
            // 
            this.GameDateLabel.AutoSize = true;
            this.GameDateLabel.Location = new System.Drawing.Point(253, 42);
            this.GameDateLabel.Name = "GameDateLabel";
            this.GameDateLabel.Size = new System.Drawing.Size(75, 13);
            this.GameDateLabel.TabIndex = 8;
            this.GameDateLabel.Text = "Data premiery:";
            // 
            // GameDateTime
            // 
            this.GameDateTime.Location = new System.Drawing.Point(234, 59);
            this.GameDateTime.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.GameDateTime.Name = "GameDateTime";
            this.GameDateTime.Size = new System.Drawing.Size(114, 20);
            this.GameDateTime.TabIndex = 7;
            // 
            // GameAdult
            // 
            this.GameAdult.AutoSize = true;
            this.GameAdult.Location = new System.Drawing.Point(304, 101);
            this.GameAdult.Name = "GameAdult";
            this.GameAdult.Size = new System.Drawing.Size(44, 17);
            this.GameAdult.TabIndex = 6;
            this.GameAdult.Text = "+18";
            this.GameAdult.UseVisualStyleBackColor = true;
            this.GameAdult.CheckedChanged += new System.EventHandler(this.GameAdult_CheckedChanged);
            // 
            // GamePrice
            // 
            this.GamePrice.DecimalPlaces = 2;
            this.GamePrice.Location = new System.Drawing.Point(145, 58);
            this.GamePrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.GamePrice.Name = "GamePrice";
            this.GamePrice.Size = new System.Drawing.Size(79, 20);
            this.GamePrice.TabIndex = 5;
            this.GamePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(167, 42);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Cena:";
            // 
            // GameType
            // 
            this.GameType.FormattingEnabled = true;
            this.GameType.Location = new System.Drawing.Point(11, 58);
            this.GameType.Name = "GameType";
            this.GameType.Size = new System.Drawing.Size(116, 21);
            this.GameType.TabIndex = 3;
            // 
            // GameTypeLabel
            // 
            this.GameTypeLabel.AutoSize = true;
            this.GameTypeLabel.Location = new System.Drawing.Point(39, 42);
            this.GameTypeLabel.Name = "GameTypeLabel";
            this.GameTypeLabel.Size = new System.Drawing.Size(51, 13);
            this.GameTypeLabel.TabIndex = 2;
            this.GameTypeLabel.Text = "Gatunek:";
            // 
            // GameName
            // 
            this.GameName.Location = new System.Drawing.Point(11, 19);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(337, 20);
            this.GameName.TabIndex = 1;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Location = new System.Drawing.Point(142, 3);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(60, 13);
            this.GameNameLabel.TabIndex = 0;
            this.GameNameLabel.Text = "Nazwa gry:";
            // 
            // Video
            // 
            this.Video.Controls.Add(this.VideoAdd);
            this.Video.Controls.Add(this.VideoScenario);
            this.Video.Controls.Add(this.ScenarioLabel);
            this.Video.Controls.Add(this.VideoDirection);
            this.Video.Controls.Add(this.DirectionLabel);
            this.Video.Controls.Add(this.VideoAdult);
            this.Video.Controls.Add(this.VideoDateTimeLabel);
            this.Video.Controls.Add(this.VideoDateTime);
            this.Video.Controls.Add(this.VideoPrice);
            this.Video.Controls.Add(this.VideoPriceLabel);
            this.Video.Controls.Add(this.VideoType);
            this.Video.Controls.Add(this.VideoTypeLabel);
            this.Video.Controls.Add(this.VideoName);
            this.Video.Controls.Add(this.VideoNameLabel);
            this.Video.Location = new System.Drawing.Point(4, 22);
            this.Video.Name = "Video";
            this.Video.Padding = new System.Windows.Forms.Padding(3);
            this.Video.Size = new System.Drawing.Size(365, 197);
            this.Video.TabIndex = 1;
            this.Video.Text = "Film";
            this.Video.UseVisualStyleBackColor = true;
            // 
            // VideoAdd
            // 
            this.VideoAdd.Location = new System.Drawing.Point(11, 136);
            this.VideoAdd.Name = "VideoAdd";
            this.VideoAdd.Size = new System.Drawing.Size(343, 36);
            this.VideoAdd.TabIndex = 20;
            this.VideoAdd.Text = "Dodaj film";
            this.VideoAdd.UseVisualStyleBackColor = true;
            this.VideoAdd.Click += new System.EventHandler(this.VideoAdd_Click);
            // 
            // VideoScenario
            // 
            this.VideoScenario.Location = new System.Drawing.Point(145, 97);
            this.VideoScenario.Name = "VideoScenario";
            this.VideoScenario.Size = new System.Drawing.Size(100, 20);
            this.VideoScenario.TabIndex = 19;
            // 
            // ScenarioLabel
            // 
            this.ScenarioLabel.AutoSize = true;
            this.ScenarioLabel.Location = new System.Drawing.Point(154, 81);
            this.ScenarioLabel.Name = "ScenarioLabel";
            this.ScenarioLabel.Size = new System.Drawing.Size(62, 13);
            this.ScenarioLabel.TabIndex = 18;
            this.ScenarioLabel.Text = "Scenariusz:";
            // 
            // VideoDirection
            // 
            this.VideoDirection.Location = new System.Drawing.Point(11, 97);
            this.VideoDirection.Name = "VideoDirection";
            this.VideoDirection.Size = new System.Drawing.Size(116, 20);
            this.VideoDirection.TabIndex = 17;
            // 
            // DirectionLabel
            // 
            this.DirectionLabel.AutoSize = true;
            this.DirectionLabel.Location = new System.Drawing.Point(39, 81);
            this.DirectionLabel.Name = "DirectionLabel";
            this.DirectionLabel.Size = new System.Drawing.Size(48, 13);
            this.DirectionLabel.TabIndex = 16;
            this.DirectionLabel.Text = "Reżyser:";
            // 
            // VideoAdult
            // 
            this.VideoAdult.AutoSize = true;
            this.VideoAdult.Location = new System.Drawing.Point(256, 97);
            this.VideoAdult.Name = "VideoAdult";
            this.VideoAdult.Size = new System.Drawing.Size(44, 17);
            this.VideoAdult.TabIndex = 15;
            this.VideoAdult.Text = "+18";
            this.VideoAdult.UseVisualStyleBackColor = true;
            this.VideoAdult.CheckedChanged += new System.EventHandler(this.VideoAdult_CheckedChanged);
            // 
            // VideoDateTimeLabel
            // 
            this.VideoDateTimeLabel.AutoSize = true;
            this.VideoDateTimeLabel.Location = new System.Drawing.Point(253, 41);
            this.VideoDateTimeLabel.Name = "VideoDateTimeLabel";
            this.VideoDateTimeLabel.Size = new System.Drawing.Size(75, 13);
            this.VideoDateTimeLabel.TabIndex = 14;
            this.VideoDateTimeLabel.Text = "Data premiery:";
            // 
            // VideoDateTime
            // 
            this.VideoDateTime.Location = new System.Drawing.Point(234, 58);
            this.VideoDateTime.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.VideoDateTime.Name = "VideoDateTime";
            this.VideoDateTime.Size = new System.Drawing.Size(114, 20);
            this.VideoDateTime.TabIndex = 13;
            // 
            // VideoPrice
            // 
            this.VideoPrice.DecimalPlaces = 2;
            this.VideoPrice.Location = new System.Drawing.Point(145, 57);
            this.VideoPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.VideoPrice.Name = "VideoPrice";
            this.VideoPrice.Size = new System.Drawing.Size(79, 20);
            this.VideoPrice.TabIndex = 12;
            this.VideoPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VideoPriceLabel
            // 
            this.VideoPriceLabel.AutoSize = true;
            this.VideoPriceLabel.Location = new System.Drawing.Point(167, 41);
            this.VideoPriceLabel.Name = "VideoPriceLabel";
            this.VideoPriceLabel.Size = new System.Drawing.Size(35, 13);
            this.VideoPriceLabel.TabIndex = 11;
            this.VideoPriceLabel.Text = "Cena:";
            // 
            // VideoType
            // 
            this.VideoType.FormattingEnabled = true;
            this.VideoType.Items.AddRange(new object[] {
            "Kryminał",
            "Thriller",
            "Akcja",
            "Horror",
            "Przyrodniczy",
            "Historyczny",
            "Science-fiction",
            "Dokumentalny",
            "Autobiografia",
            "Komedia",
            "Tragedia",
            "Dramat",
            "Naukowy",
            "Przygodowy",
            "Młodzieżowy"});
            this.VideoType.Location = new System.Drawing.Point(11, 57);
            this.VideoType.Name = "VideoType";
            this.VideoType.Size = new System.Drawing.Size(116, 21);
            this.VideoType.TabIndex = 10;
            // 
            // VideoTypeLabel
            // 
            this.VideoTypeLabel.AutoSize = true;
            this.VideoTypeLabel.Location = new System.Drawing.Point(39, 41);
            this.VideoTypeLabel.Name = "VideoTypeLabel";
            this.VideoTypeLabel.Size = new System.Drawing.Size(51, 13);
            this.VideoTypeLabel.TabIndex = 9;
            this.VideoTypeLabel.Text = "Gatunek:";
            // 
            // VideoName
            // 
            this.VideoName.Location = new System.Drawing.Point(11, 18);
            this.VideoName.Name = "VideoName";
            this.VideoName.Size = new System.Drawing.Size(343, 20);
            this.VideoName.TabIndex = 1;
            // 
            // VideoNameLabel
            // 
            this.VideoNameLabel.AutoSize = true;
            this.VideoNameLabel.Location = new System.Drawing.Point(152, 3);
            this.VideoNameLabel.Name = "VideoNameLabel";
            this.VideoNameLabel.Size = new System.Drawing.Size(67, 13);
            this.VideoNameLabel.TabIndex = 0;
            this.VideoNameLabel.Text = "Nazwa filmu:";
            // 
            // Book
            // 
            this.Book.Controls.Add(this.BookPagesLabel);
            this.Book.Controls.Add(this.BookPages);
            this.Book.Controls.Add(this.BookAdult);
            this.Book.Controls.Add(this.BookAdd);
            this.Book.Controls.Add(this.BookPubHouse);
            this.Book.Controls.Add(this.BookAuthor);
            this.Book.Controls.Add(this.BookPubHouseLabel);
            this.Book.Controls.Add(this.BookAuthorLabel);
            this.Book.Controls.Add(this.BookDateTimeLabel);
            this.Book.Controls.Add(this.BookDateTime);
            this.Book.Controls.Add(this.BookPrice);
            this.Book.Controls.Add(this.BookPriceLabel);
            this.Book.Controls.Add(this.BookType);
            this.Book.Controls.Add(this.BookTypeLabel);
            this.Book.Controls.Add(this.BookName);
            this.Book.Controls.Add(this.BookNameLabel);
            this.Book.Location = new System.Drawing.Point(4, 22);
            this.Book.Name = "Book";
            this.Book.Padding = new System.Windows.Forms.Padding(3);
            this.Book.Size = new System.Drawing.Size(365, 197);
            this.Book.TabIndex = 2;
            this.Book.Text = "Książka";
            this.Book.UseVisualStyleBackColor = true;
            // 
            // BookPagesLabel
            // 
            this.BookPagesLabel.AutoSize = true;
            this.BookPagesLabel.Location = new System.Drawing.Point(233, 148);
            this.BookPagesLabel.Name = "BookPagesLabel";
            this.BookPagesLabel.Size = new System.Drawing.Size(58, 13);
            this.BookPagesLabel.TabIndex = 34;
            this.BookPagesLabel.Text = "Ilość stron:";
            // 
            // BookPages
            // 
            this.BookPages.Location = new System.Drawing.Point(297, 146);
            this.BookPages.Name = "BookPages";
            this.BookPages.Size = new System.Drawing.Size(44, 20);
            this.BookPages.TabIndex = 33;
            // 
            // BookAdult
            // 
            this.BookAdult.AutoSize = true;
            this.BookAdult.Location = new System.Drawing.Point(236, 123);
            this.BookAdult.Name = "BookAdult";
            this.BookAdult.Size = new System.Drawing.Size(44, 17);
            this.BookAdult.TabIndex = 32;
            this.BookAdult.Text = "+18";
            this.BookAdult.UseVisualStyleBackColor = true;
            this.BookAdult.CheckedChanged += new System.EventHandler(this.BookAdult_CheckedChanged);
            // 
            // BookAdd
            // 
            this.BookAdd.Location = new System.Drawing.Point(11, 123);
            this.BookAdd.Name = "BookAdd";
            this.BookAdd.Size = new System.Drawing.Size(219, 60);
            this.BookAdd.TabIndex = 31;
            this.BookAdd.Text = "Dodaj książkę";
            this.BookAdd.UseVisualStyleBackColor = true;
            this.BookAdd.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // BookPubHouse
            // 
            this.BookPubHouse.Location = new System.Drawing.Point(145, 97);
            this.BookPubHouse.Name = "BookPubHouse";
            this.BookPubHouse.Size = new System.Drawing.Size(203, 20);
            this.BookPubHouse.TabIndex = 30;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Location = new System.Drawing.Point(11, 97);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(116, 20);
            this.BookAuthor.TabIndex = 29;
            // 
            // BookPubHouseLabel
            // 
            this.BookPubHouseLabel.AutoSize = true;
            this.BookPubHouseLabel.Location = new System.Drawing.Point(215, 81);
            this.BookPubHouseLabel.Name = "BookPubHouseLabel";
            this.BookPubHouseLabel.Size = new System.Drawing.Size(77, 13);
            this.BookPubHouseLabel.TabIndex = 28;
            this.BookPubHouseLabel.Text = "Wydawnictwo:";
            // 
            // BookAuthorLabel
            // 
            this.BookAuthorLabel.AutoSize = true;
            this.BookAuthorLabel.Location = new System.Drawing.Point(39, 81);
            this.BookAuthorLabel.Name = "BookAuthorLabel";
            this.BookAuthorLabel.Size = new System.Drawing.Size(35, 13);
            this.BookAuthorLabel.TabIndex = 27;
            this.BookAuthorLabel.Text = "Autor:";
            // 
            // BookDateTimeLabel
            // 
            this.BookDateTimeLabel.AutoSize = true;
            this.BookDateTimeLabel.Location = new System.Drawing.Point(253, 41);
            this.BookDateTimeLabel.Name = "BookDateTimeLabel";
            this.BookDateTimeLabel.Size = new System.Drawing.Size(75, 13);
            this.BookDateTimeLabel.TabIndex = 26;
            this.BookDateTimeLabel.Text = "Data premiery:";
            // 
            // BookDateTime
            // 
            this.BookDateTime.Location = new System.Drawing.Point(234, 58);
            this.BookDateTime.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.BookDateTime.Name = "BookDateTime";
            this.BookDateTime.Size = new System.Drawing.Size(114, 20);
            this.BookDateTime.TabIndex = 25;
            // 
            // BookPrice
            // 
            this.BookPrice.DecimalPlaces = 2;
            this.BookPrice.Location = new System.Drawing.Point(145, 57);
            this.BookPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(79, 20);
            this.BookPrice.TabIndex = 24;
            this.BookPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BookPriceLabel
            // 
            this.BookPriceLabel.AutoSize = true;
            this.BookPriceLabel.Location = new System.Drawing.Point(167, 41);
            this.BookPriceLabel.Name = "BookPriceLabel";
            this.BookPriceLabel.Size = new System.Drawing.Size(35, 13);
            this.BookPriceLabel.TabIndex = 23;
            this.BookPriceLabel.Text = "Cena:";
            // 
            // BookType
            // 
            this.BookType.FormattingEnabled = true;
            this.BookType.Items.AddRange(new object[] {
            "Kryminał",
            "Thriller",
            "Akcja",
            "Horror",
            "Historyczny",
            "Science-fiction",
            "Autobiografia",
            "Komedia",
            "Tragedia",
            "Dramat",
            "Naukowy",
            "Przygodowy",
            "Młodzieżowy"});
            this.BookType.Location = new System.Drawing.Point(11, 57);
            this.BookType.Name = "BookType";
            this.BookType.Size = new System.Drawing.Size(116, 21);
            this.BookType.TabIndex = 22;
            // 
            // BookTypeLabel
            // 
            this.BookTypeLabel.AutoSize = true;
            this.BookTypeLabel.Location = new System.Drawing.Point(39, 41);
            this.BookTypeLabel.Name = "BookTypeLabel";
            this.BookTypeLabel.Size = new System.Drawing.Size(51, 13);
            this.BookTypeLabel.TabIndex = 21;
            this.BookTypeLabel.Text = "Gatunek:";
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(11, 18);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(343, 20);
            this.BookName.TabIndex = 20;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(152, 3);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(78, 13);
            this.BookNameLabel.TabIndex = 19;
            this.BookNameLabel.Text = "Nazwa książki:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 216);
            this.Controls.Add(this.Tabs);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowego produktu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.Tabs.ResumeLayout(false);
            this.Games.ResumeLayout(false);
            this.Games.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePrice)).EndInit();
            this.Video.ResumeLayout(false);
            this.Video.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPrice)).EndInit();
            this.Book.ResumeLayout(false);
            this.Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Games;
        private System.Windows.Forms.TabPage Video;
        private System.Windows.Forms.TabPage Book;
        private System.Windows.Forms.ComboBox GameType;
        private System.Windows.Forms.Label GameTypeLabel;
        private System.Windows.Forms.TextBox GameName;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.NumericUpDown GamePrice;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.DateTimePicker GameDateTime;
        private System.Windows.Forms.CheckBox GameAdult;
        private System.Windows.Forms.Label GameDateLabel;
        private System.Windows.Forms.TextBox GameProducer;
        private System.Windows.Forms.Label ProducerLabel;
        private System.Windows.Forms.Button GameAdd;
        private System.Windows.Forms.Label VideoNameLabel;
        private System.Windows.Forms.TextBox VideoName;
        private System.Windows.Forms.Label VideoDateTimeLabel;
        private System.Windows.Forms.DateTimePicker VideoDateTime;
        private System.Windows.Forms.NumericUpDown VideoPrice;
        private System.Windows.Forms.Label VideoPriceLabel;
        private System.Windows.Forms.ComboBox VideoType;
        private System.Windows.Forms.Label VideoTypeLabel;
        private System.Windows.Forms.CheckBox VideoAdult;
        private System.Windows.Forms.Label DirectionLabel;
        private System.Windows.Forms.Button VideoAdd;
        private System.Windows.Forms.TextBox VideoScenario;
        private System.Windows.Forms.Label ScenarioLabel;
        private System.Windows.Forms.TextBox VideoDirection;
        private System.Windows.Forms.TextBox BookPubHouse;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.Label BookPubHouseLabel;
        private System.Windows.Forms.Label BookAuthorLabel;
        private System.Windows.Forms.Label BookDateTimeLabel;
        private System.Windows.Forms.DateTimePicker BookDateTime;
        private System.Windows.Forms.NumericUpDown BookPrice;
        private System.Windows.Forms.Label BookPriceLabel;
        private System.Windows.Forms.ComboBox BookType;
        private System.Windows.Forms.Label BookTypeLabel;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label BookPagesLabel;
        private System.Windows.Forms.NumericUpDown BookPages;
        private System.Windows.Forms.CheckBox BookAdult;
        private System.Windows.Forms.Button BookAdd;
    }
}