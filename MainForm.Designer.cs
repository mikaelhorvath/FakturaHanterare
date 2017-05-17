namespace FakturaHanterare
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.company_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Invoice_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OCR_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.email_txtBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fakturor";
            // 
            // company_txtBox
            // 
            this.company_txtBox.Location = new System.Drawing.Point(568, 35);
            this.company_txtBox.Name = "company_txtBox";
            this.company_txtBox.Size = new System.Drawing.Size(225, 22);
            this.company_txtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Företag";
            // 
            // Invoice_txtBox
            // 
            this.Invoice_txtBox.Location = new System.Drawing.Point(568, 82);
            this.Invoice_txtBox.Name = "Invoice_txtBox";
            this.Invoice_txtBox.Size = new System.Drawing.Size(225, 22);
            this.Invoice_txtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Faktura Nr";
            // 
            // OCR_textBox
            // 
            this.OCR_textBox.Location = new System.Drawing.Point(568, 128);
            this.OCR_textBox.Name = "OCR_textBox";
            this.OCR_textBox.Size = new System.Drawing.Size(225, 22);
            this.OCR_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "OCR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lägg till Faktura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(568, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Maila uppgifter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Betaldatum";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 468);
            this.listBox1.TabIndex = 0;
            // 
            // email_txtBox1
            // 
            this.email_txtBox1.Location = new System.Drawing.Point(568, 423);
            this.email_txtBox1.Name = "email_txtBox1";
            this.email_txtBox1.Size = new System.Drawing.Size(225, 22);
            this.email_txtBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-Post";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email_txtBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OCR_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Invoice_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.company_txtBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Faktura Hanterare 1.0";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox company_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Invoice_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OCR_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox email_txtBox1;
        private System.Windows.Forms.Label label5;
    }
}

