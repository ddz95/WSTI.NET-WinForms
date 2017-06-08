namespace ComboExample
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
            this.combo = new System.Windows.Forms.ComboBox();
            this.Header = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.SetBtn = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(12, 12);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(199, 21);
            this.combo.TabIndex = 0;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // Header
            // 
            this.Header.Location = new System.Drawing.Point(12, 58);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(199, 20);
            this.Header.TabIndex = 1;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(12, 97);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(199, 20);
            this.Value.TabIndex = 2;
            // 
            // SetBtn
            // 
            this.SetBtn.Location = new System.Drawing.Point(12, 123);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(199, 37);
            this.SetBtn.TabIndex = 3;
            this.SetBtn.Text = "Utwórz nowy produkt";
            this.SetBtn.UseVisualStyleBackColor = true;
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 42);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(43, 13);
            this.HeaderLabel.TabIndex = 4;
            this.HeaderLabel.Text = "Nazwa:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(12, 81);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(47, 13);
            this.ValueLabel.TabIndex = 5;
            this.ValueLabel.Text = "Wartość";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 176);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.SetBtn);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.combo);
            this.Name = "Form1";
            this.Text = "ComboExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button SetBtn;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label ValueLabel;
    }
}

