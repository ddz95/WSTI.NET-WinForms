namespace WindowsFormsApp1
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
            this.myButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.disableTextBox = new System.Windows.Forms.CheckBox();
            this.timesClicked = new System.Windows.Forms.Label();
            this.myOtherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.ForeColor = System.Drawing.Color.Red;
            this.myButton.Location = new System.Drawing.Point(12, 37);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(224, 23);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "My Button";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 1;
            // 
            // disableTextBox
            // 
            this.disableTextBox.AutoSize = true;
            this.disableTextBox.Location = new System.Drawing.Point(12, 95);
            this.disableTextBox.Name = "disableTextBox";
            this.disableTextBox.Size = new System.Drawing.Size(61, 17);
            this.disableTextBox.TabIndex = 2;
            this.disableTextBox.Text = "Disable";
            this.disableTextBox.UseVisualStyleBackColor = true;
            this.disableTextBox.CheckedChanged += new System.EventHandler(this.disableTextBox_CheckedChanged);
            // 
            // timesClicked
            // 
            this.timesClicked.AutoSize = true;
            this.timesClicked.Location = new System.Drawing.Point(210, 95);
            this.timesClicked.Name = "timesClicked";
            this.timesClicked.Size = new System.Drawing.Size(0, 13);
            this.timesClicked.TabIndex = 3;
            // 
            // myOtherButton
            // 
            this.myOtherButton.Location = new System.Drawing.Point(12, 66);
            this.myOtherButton.Name = "myOtherButton";
            this.myOtherButton.Size = new System.Drawing.Size(224, 23);
            this.myOtherButton.TabIndex = 4;
            this.myOtherButton.Text = "Change above!";
            this.myOtherButton.UseVisualStyleBackColor = true;
            this.myOtherButton.Click += new System.EventHandler(this.myOtherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 117);
            this.Controls.Add(this.myOtherButton);
            this.Controls.Add(this.timesClicked);
            this.Controls.Add(this.disableTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.myButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox disableTextBox;
        private System.Windows.Forms.Label timesClicked;
        private System.Windows.Forms.Button myOtherButton;
    }
}

