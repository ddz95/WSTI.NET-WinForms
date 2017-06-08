namespace GryFilmy
{
    partial class MainForm
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
            this.AddProduct = new System.Windows.Forms.Button();
            this.DelProduct = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.ListView();
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wypożyczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetInfo = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.ClientBox = new System.Windows.Forms.GroupBox();
            this.ReturnedPicture = new System.Windows.Forms.PictureBox();
            this.BorrowPicture = new System.Windows.Forms.PictureBox();
            this.Returned = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomPicture = new System.Windows.Forms.PictureBox();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.ProductInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickMenu.SuspendLayout();
            this.ClientBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowPicture)).BeginInit();
            this.UserBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(38, 19);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(156, 23);
            this.AddProduct.TabIndex = 1;
            this.AddProduct.Text = "Dodaj produkt";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DelProduct
            // 
            this.DelProduct.Location = new System.Drawing.Point(38, 48);
            this.DelProduct.Name = "DelProduct";
            this.DelProduct.Size = new System.Drawing.Size(156, 23);
            this.DelProduct.TabIndex = 2;
            this.DelProduct.Text = "Usuń produkt";
            this.DelProduct.UseVisualStyleBackColor = true;
            this.DelProduct.Click += new System.EventHandler(this.DelProduct_Click);
            // 
            // ProductList
            // 
            this.ProductList.ContextMenuStrip = this.RightClickMenu;
            this.ProductList.Location = new System.Drawing.Point(12, 236);
            this.ProductList.MultiSelect = false;
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(429, 388);
            this.ProductList.TabIndex = 3;
            this.ProductList.UseCompatibleStateImageBehavior = false;
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wypożyczToolStripMenuItem,
            this.oddanoToolStripMenuItem,
            this.usuńProduktToolStripMenuItem,
            this.ProductInfoItem});
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.Size = new System.Drawing.Size(267, 114);
            // 
            // wypożyczToolStripMenuItem
            // 
            this.wypożyczToolStripMenuItem.Image = global::GryFilmy.Properties.Resources.rent_small;
            this.wypożyczToolStripMenuItem.Name = "wypożyczToolStripMenuItem";
            this.wypożyczToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.wypożyczToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.wypożyczToolStripMenuItem.Text = "Wypożycz";
            this.wypożyczToolStripMenuItem.Click += new System.EventHandler(this.wypożyczToolStripMenuItem_Click);
            // 
            // oddanoToolStripMenuItem
            // 
            this.oddanoToolStripMenuItem.Image = global::GryFilmy.Properties.Resources.received;
            this.oddanoToolStripMenuItem.Name = "oddanoToolStripMenuItem";
            this.oddanoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.oddanoToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.oddanoToolStripMenuItem.Text = "Zwróć";
            this.oddanoToolStripMenuItem.Click += new System.EventHandler(this.oddanoToolStripMenuItem_Click);
            // 
            // usuńProduktToolStripMenuItem
            // 
            this.usuńProduktToolStripMenuItem.Image = global::GryFilmy.Properties.Resources.remove;
            this.usuńProduktToolStripMenuItem.Name = "usuńProduktToolStripMenuItem";
            this.usuńProduktToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.usuńProduktToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.usuńProduktToolStripMenuItem.Text = "Usuń produkt";
            this.usuńProduktToolStripMenuItem.Click += new System.EventHandler(this.usuńProduktToolStripMenuItem_Click);
            // 
            // GetInfo
            // 
            this.GetInfo.Location = new System.Drawing.Point(38, 77);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(156, 23);
            this.GetInfo.TabIndex = 4;
            this.GetInfo.Text = "Informacje o produkcie";
            this.GetInfo.UseVisualStyleBackColor = true;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // Borrow
            // 
            this.Borrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrow.Location = new System.Drawing.Point(38, 19);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(151, 23);
            this.Borrow.TabIndex = 5;
            this.Borrow.Text = "Wypożycz";
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // ClientBox
            // 
            this.ClientBox.Controls.Add(this.ReturnedPicture);
            this.ClientBox.Controls.Add(this.BorrowPicture);
            this.ClientBox.Controls.Add(this.Returned);
            this.ClientBox.Controls.Add(this.Borrow);
            this.ClientBox.Location = new System.Drawing.Point(447, 236);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(206, 88);
            this.ClientBox.TabIndex = 7;
            this.ClientBox.TabStop = false;
            this.ClientBox.Text = "Strefa klienta";
            // 
            // ReturnedPicture
            // 
            this.ReturnedPicture.Image = global::GryFilmy.Properties.Resources.received;
            this.ReturnedPicture.Location = new System.Drawing.Point(8, 48);
            this.ReturnedPicture.Name = "ReturnedPicture";
            this.ReturnedPicture.Size = new System.Drawing.Size(24, 24);
            this.ReturnedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ReturnedPicture.TabIndex = 12;
            this.ReturnedPicture.TabStop = false;
            // 
            // BorrowPicture
            // 
            this.BorrowPicture.Image = global::GryFilmy.Properties.Resources.rent_small;
            this.BorrowPicture.Location = new System.Drawing.Point(8, 19);
            this.BorrowPicture.Name = "BorrowPicture";
            this.BorrowPicture.Size = new System.Drawing.Size(24, 24);
            this.BorrowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BorrowPicture.TabIndex = 11;
            this.BorrowPicture.TabStop = false;
            // 
            // Returned
            // 
            this.Returned.Location = new System.Drawing.Point(38, 49);
            this.Returned.Name = "Returned";
            this.Returned.Size = new System.Drawing.Size(151, 23);
            this.Returned.TabIndex = 9;
            this.Returned.Text = "Zwróć";
            this.Returned.UseVisualStyleBackColor = true;
            this.Returned.Click += new System.EventHandler(this.Returned_Click);
            // 
            // UserBox
            // 
            this.UserBox.Controls.Add(this.pictureBox3);
            this.UserBox.Controls.Add(this.pictureBox2);
            this.UserBox.Controls.Add(this.pictureBox1);
            this.UserBox.Controls.Add(this.AddProduct);
            this.UserBox.Controls.Add(this.DelProduct);
            this.UserBox.Controls.Add(this.GetInfo);
            this.UserBox.Location = new System.Drawing.Point(447, 340);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(206, 111);
            this.UserBox.TabIndex = 8;
            this.UserBox.TabStop = false;
            this.UserBox.Text = "Opcje";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GryFilmy.Properties.Resources.info;
            this.pictureBox3.Location = new System.Drawing.Point(8, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GryFilmy.Properties.Resources.remove;
            this.pictureBox2.Location = new System.Drawing.Point(8, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GryFilmy.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(669, 24);
            this.MainMenu.TabIndex = 9;
            this.MainMenu.Text = "MainMenu";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItem,
            this.OpenItem,
            this.SaveAsItem,
            this.toolStripSeparator1,
            this.CloseItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(38, 20);
            this.FileMenu.Text = "Plik";
            // 
            // NewItem
            // 
            this.NewItem.Image = global::GryFilmy.Properties.Resources.blank;
            this.NewItem.Name = "NewItem";
            this.NewItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewItem.Size = new System.Drawing.Size(172, 22);
            this.NewItem.Text = "Nowy";
            this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
            // 
            // OpenItem
            // 
            this.OpenItem.Image = global::GryFilmy.Properties.Resources.open;
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenItem.Size = new System.Drawing.Size(172, 22);
            this.OpenItem.Text = "Otwórz";
            this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // SaveAsItem
            // 
            this.SaveAsItem.Image = global::GryFilmy.Properties.Resources.save;
            this.SaveAsItem.Name = "SaveAsItem";
            this.SaveAsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveAsItem.Size = new System.Drawing.Size(172, 22);
            this.SaveAsItem.Text = "Zapisz jako";
            this.SaveAsItem.Click += new System.EventHandler(this.SaveAsItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // CloseItem
            // 
            this.CloseItem.Image = global::GryFilmy.Properties.Resources.close;
            this.CloseItem.Name = "CloseItem";
            this.CloseItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.CloseItem.Size = new System.Drawing.Size(172, 22);
            this.CloseItem.Text = "Zamknij";
            this.CloseItem.Click += new System.EventHandler(this.CloseItem_Click);
            // 
            // BottomPicture
            // 
            this.BottomPicture.Image = global::GryFilmy.Properties.Resources.wsti;
            this.BottomPicture.Location = new System.Drawing.Point(447, 475);
            this.BottomPicture.Name = "BottomPicture";
            this.BottomPicture.Size = new System.Drawing.Size(206, 149);
            this.BottomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomPicture.TabIndex = 12;
            this.BottomPicture.TabStop = false;
            // 
            // MainPicture
            // 
            this.MainPicture.Image = global::GryFilmy.Properties.Resources.anastasia_zhenina_65700;
            this.MainPicture.Location = new System.Drawing.Point(12, 27);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(641, 203);
            this.MainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPicture.TabIndex = 11;
            this.MainPicture.TabStop = false;
            // 
            // ProductInfoItem
            // 
            this.ProductInfoItem.Image = global::GryFilmy.Properties.Resources.info;
            this.ProductInfoItem.Name = "ProductInfoItem";
            this.ProductInfoItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.ProductInfoItem.Size = new System.Drawing.Size(266, 22);
            this.ProductInfoItem.Text = "Informacje o produkcie";
            this.ProductInfoItem.Click += new System.EventHandler(this.ProductInfoItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 642);
            this.Controls.Add(this.BottomPicture);
            this.Controls.Add(this.MainPicture);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wypożyczalnia - zajęcia WSTI.NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RightClickMenu.ResumeLayout(false);
            this.ClientBox.ResumeLayout(false);
            this.ClientBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowPicture)).EndInit();
            this.UserBox.ResumeLayout(false);
            this.UserBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DelProduct;
        private System.Windows.Forms.ListView ProductList;
        private System.Windows.Forms.Button GetInfo;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem wypożyczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oddanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńProduktToolStripMenuItem;
        private System.Windows.Forms.GroupBox ClientBox;
        private System.Windows.Forms.GroupBox UserBox;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseItem;
        private System.Windows.Forms.Button Returned;
        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.PictureBox BottomPicture;
        private System.Windows.Forms.PictureBox BorrowPicture;
        private System.Windows.Forms.PictureBox ReturnedPicture;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ProductInfoItem;
    }
}

