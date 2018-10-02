namespace WindowsFormsApp
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
            this.butonDeschideFisier = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butonSalveazaText = new System.Windows.Forms.Button();
            this.butonSalveazaJson = new System.Windows.Forms.Button();
            this.butonSalveazaBinar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butonSalveazaCuExtensiaAleasa = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.butonUploadPDF = new System.Windows.Forms.Button();
            this.butonSalveazaZip = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // butonDeschideFisier
            // 
            this.butonDeschideFisier.Location = new System.Drawing.Point(12, 26);
            this.butonDeschideFisier.Name = "butonDeschideFisier";
            this.butonDeschideFisier.Size = new System.Drawing.Size(154, 23);
            this.butonDeschideFisier.TabIndex = 0;
            this.butonDeschideFisier.Text = "Deschide fisier";
            this.butonDeschideFisier.UseVisualStyleBackColor = true;
            this.butonDeschideFisier.Click += new System.EventHandler(this.DeschideFisier);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(759, 283);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // butonSalveazaText
            // 
            this.butonSalveazaText.Location = new System.Drawing.Point(172, 26);
            this.butonSalveazaText.Name = "butonSalveazaText";
            this.butonSalveazaText.Size = new System.Drawing.Size(124, 23);
            this.butonSalveazaText.TabIndex = 2;
            this.butonSalveazaText.Text = "Salveaza fisier";
            this.butonSalveazaText.UseVisualStyleBackColor = true;
            this.butonSalveazaText.Click += new System.EventHandler(this.SalveazaFisierCaText);
            // 
            // butonSalveazaJson
            // 
            this.butonSalveazaJson.Location = new System.Drawing.Point(302, 26);
            this.butonSalveazaJson.Name = "butonSalveazaJson";
            this.butonSalveazaJson.Size = new System.Drawing.Size(232, 23);
            this.butonSalveazaJson.TabIndex = 3;
            this.butonSalveazaJson.Text = "Salveaza fisier text ca JSON";
            this.butonSalveazaJson.UseVisualStyleBackColor = true;
            this.butonSalveazaJson.Click += new System.EventHandler(this.SalveazaFisierCaJSON);
            // 
            // butonSalveazaBinar
            // 
            this.butonSalveazaBinar.Location = new System.Drawing.Point(540, 26);
            this.butonSalveazaBinar.Name = "butonSalveazaBinar";
            this.butonSalveazaBinar.Size = new System.Drawing.Size(231, 23);
            this.butonSalveazaBinar.TabIndex = 4;
            this.butonSalveazaBinar.Text = "Salveaza fisier text ca fisier binar";
            this.butonSalveazaBinar.UseVisualStyleBackColor = true;
            this.butonSalveazaBinar.Click += new System.EventHandler(this.SalveazaFisierCaBinar);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SelectieExtensii);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salveaza cu extensia:";
            // 
            // butonSalveazaCuExtensiaAleasa
            // 
            this.butonSalveazaCuExtensiaAleasa.Location = new System.Drawing.Point(444, 412);
            this.butonSalveazaCuExtensiaAleasa.Name = "butonSalveazaCuExtensiaAleasa";
            this.butonSalveazaCuExtensiaAleasa.Size = new System.Drawing.Size(107, 23);
            this.butonSalveazaCuExtensiaAleasa.TabIndex = 7;
            this.butonSalveazaCuExtensiaAleasa.Text = "Salveaza!";
            this.butonSalveazaCuExtensiaAleasa.UseVisualStyleBackColor = true;
            this.butonSalveazaCuExtensiaAleasa.Click += new System.EventHandler(this.SalveazaCuExtensieDorita);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // butonUploadPDF
            // 
            this.butonUploadPDF.Location = new System.Drawing.Point(12, 450);
            this.butonUploadPDF.Name = "butonUploadPDF";
            this.butonUploadPDF.Size = new System.Drawing.Size(153, 23);
            this.butonUploadPDF.TabIndex = 8;
            this.butonUploadPDF.Text = "Upload PDF";
            this.butonUploadPDF.UseVisualStyleBackColor = true;
            this.butonUploadPDF.Click += new System.EventHandler(this.UploadPDF);
            // 
            // butonSalveazaZip
            // 
            this.butonSalveazaZip.Location = new System.Drawing.Point(575, 450);
            this.butonSalveazaZip.Name = "butonSalveazaZip";
            this.butonSalveazaZip.Size = new System.Drawing.Size(196, 23);
            this.butonSalveazaZip.TabIndex = 9;
            this.butonSalveazaZip.Text = "Salveaza PDF ca ZIP";
            this.butonSalveazaZip.UseVisualStyleBackColor = true;
            this.butonSalveazaZip.Click += new System.EventHandler(this.SalveazaZip);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(184, 450);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(367, 52);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adresa fisierului deschis:";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(267, 363);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(417, 31);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Technical tasks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TechnicalTasks);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.butonSalveazaZip);
            this.Controls.Add(this.butonUploadPDF);
            this.Controls.Add(this.butonSalveazaCuExtensiaAleasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butonSalveazaBinar);
            this.Controls.Add(this.butonSalveazaJson);
            this.Controls.Add(this.butonSalveazaText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.butonDeschideFisier);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonDeschideFisier;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butonSalveazaText;
        private System.Windows.Forms.Button butonSalveazaJson;
        private System.Windows.Forms.Button butonSalveazaBinar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonSalveazaCuExtensiaAleasa;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button butonUploadPDF;
        private System.Windows.Forms.Button butonSalveazaZip;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

