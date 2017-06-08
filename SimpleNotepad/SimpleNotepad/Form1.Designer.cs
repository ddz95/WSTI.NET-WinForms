namespace SimpleNotepad
{
    partial class Form1
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.CutTool = new System.Windows.Forms.ToolStripButton();
            this.CopyTool = new System.Windows.Forms.ToolStripButton();
            this.PasteTool = new System.Windows.Forms.ToolStripButton();
            this.FontTool = new System.Windows.Forms.ToolStripButton();
            this.TextEditor = new System.Windows.Forms.RichTextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.font = new System.Windows.Forms.FontDialog();
            this.MainMenu.SuspendLayout();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(699, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // Tools
            // 
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutTool,
            this.CopyTool,
            this.PasteTool,
            this.FontTool});
            this.Tools.Location = new System.Drawing.Point(0, 24);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(699, 25);
            this.Tools.TabIndex = 1;
            // 
            // CutTool
            // 
            this.CutTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutTool.Image = global::SimpleNotepad.Properties.Resources.scissors;
            this.CutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutTool.Name = "CutTool";
            this.CutTool.Size = new System.Drawing.Size(23, 22);
            this.CutTool.Text = "Wytnij";
            this.CutTool.Click += new System.EventHandler(this.CutTool_Click);
            // 
            // CopyTool
            // 
            this.CopyTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyTool.Image = global::SimpleNotepad.Properties.Resources.archives;
            this.CopyTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyTool.Name = "CopyTool";
            this.CopyTool.Size = new System.Drawing.Size(23, 22);
            this.CopyTool.Text = "Kopiuj";
            this.CopyTool.Click += new System.EventHandler(this.CopyTool_Click);
            // 
            // PasteTool
            // 
            this.PasteTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteTool.Image = global::SimpleNotepad.Properties.Resources.paste;
            this.PasteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteTool.Name = "PasteTool";
            this.PasteTool.Size = new System.Drawing.Size(23, 22);
            this.PasteTool.Text = "Wklej";
            this.PasteTool.Click += new System.EventHandler(this.PasteTool_Click);
            // 
            // FontTool
            // 
            this.FontTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontTool.Image = global::SimpleNotepad.Properties.Resources.text;
            this.FontTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontTool.Name = "FontTool";
            this.FontTool.Size = new System.Drawing.Size(23, 22);
            this.FontTool.Text = "Czcionka";
            this.FontTool.Click += new System.EventHandler(this.FontTool_Click);
            // 
            // TextEditor
            // 
            this.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditor.Location = new System.Drawing.Point(0, 49);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(699, 397);
            this.TextEditor.TabIndex = 2;
            this.TextEditor.Text = "";
            // 
            // openFile
            // 
            this.openFile.Filter = "Pliki tekstowe(*.txt)|*.txt|Wszystkie pliki|*.*";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Pliki tekstowe(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 446);
            this.Controls.Add(this.TextEditor);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton CutTool;
        private System.Windows.Forms.ToolStripButton CopyTool;
        private System.Windows.Forms.ToolStripButton PasteTool;
        private System.Windows.Forms.RichTextBox TextEditor;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.FontDialog font;
        private System.Windows.Forms.ToolStripButton FontTool;
    }
}

