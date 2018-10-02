using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.IO.Compression.ZipFile;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(".txt");
            comboBox1.Items.Add(".json");
            comboBox1.Items.Add(".bin");
            comboBox1.Items.Add(".zip");
        }


        // Deschidere/salvare fisier text: https://www.youtube.com/watch?v=Ct9EV5QT6Pk
        private void DeschideFisier(object sender, EventArgs e)
        {
            Stream continut;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "TXT files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((continut = openFileDialog.OpenFile()) != null)
                {
                    string numeFisier = openFileDialog.FileName;
                    string textFisier = File.ReadAllText(numeFisier);
                    richTextBox1.Text = textFisier;
                    richTextBox3.Text = numeFisier;
                }
                
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalveazaFisierCaText(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT Files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream continut = File.Open(saveFileDialog.FileName, FileMode.Create);
                using (StreamWriter salvareContinut = new StreamWriter(continut, Encoding.UTF8))
                {
                    salvareContinut.Write(richTextBox1.Text);
                }
            }
        }

        class FisierPtJson
        {
            public string fileName { get; set; }
            public string fileContent { get; set; }
        }


        //https://www.newtonsoft.com/json/help/html/SerializingJSON.htm
        private void SalveazaFisierCaJSON(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FisierPtJson fisierPtJson = new FisierPtJson();
                saveFileDialog.Filter = "JSON Files (*.json)|*.json";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.AddExtension = true;
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.OverwritePrompt = true;
                fisierPtJson.fileName = saveFileDialog.FileName;
                fisierPtJson.fileContent = richTextBox1.Text;

                Stream continut = File.Open(saveFileDialog.FileName, FileMode.Create);
                
                {
                    using (StreamWriter salvareContinut = new StreamWriter(continut, Encoding.UTF8))
                    {
                        JsonSerializer serializare = new JsonSerializer();
                        serializare.Formatting = Formatting.Indented;
                        serializare.Serialize(salvareContinut, fisierPtJson);
                    }
                }
            }
        }

        //https://stackoverflow.com/questions/16212600/character-textfile-to-binary-textfile
        private void SalveazaFisierCaBinar(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BIN Files (*.bin)|*.bin";
            saveFileDialog.DefaultExt = "bin";
            saveFileDialog.AddExtension = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader recordRead = new StreamReader(richTextBox3.Text);

                String records = recordRead.ReadToEnd();        //Citeste textul

                recordRead.Close();

                Byte[] arr = Encoding.UTF8.GetBytes(records);

                FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create);
                StreamWriter binfile = new StreamWriter(file);

                //for (int i = 0; i < arr.Count(); i++)
                //    binfile.WriteLine(Convert.ToString(arr[i], 2));

                foreach (byte b in arr)
                {
                    binfile.Write((b >> 7 & 1) == 0 ? '0' : '1');
                    binfile.Write((b >> 6 & 1) == 0 ? '0' : '1');
                    binfile.Write((b >> 5 & 1) == 0 ? '0' : '1');
                    binfile.Write((b >> 4 & 1) == 0 ? '0' : '1');
                    binfile.Write((b >> 3 & 1) == 0 ? '0' : '1');
                    binfile.Write((b >> 2 & 1) == 0 ? '0' : '1');
                    binfile.Write((b >> 1 & 1) == 0 ? '0' : '1');
                    binfile.Write((b & 1) == 0 ? '0' : '1');
                }

                binfile.Close();
                file.Close();
            }
        }

        private void SelectieExtensii(object sender, EventArgs e)
        {

        }

        private void SalveazaCuExtensieDorita(object sender, EventArgs e)
        {
            string tipExtensie = comboBox1.SelectedItem.ToString();
            switch (tipExtensie)
            {
                case ".txt":
                    butonSalveazaText.PerformClick();
                    break;
                case ".json":
                    butonSalveazaJson.PerformClick();
                    break;
                case ".bin":
                    butonSalveazaBinar.PerformClick();
                    break;
                case ".zip":
                    butonSalveazaZip.PerformClick();
                    break;
            }
        }


        private void UploadPDF(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string numeFisierPDF = openFileDialog.FileName;
                {
                    Process.Start(numeFisierPDF);
                    richTextBox2.Text = numeFisierPDF;
                }
            }
        }

        //https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-compress-and-extract-files
        private void SalveazaZip(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ZIP files (*.zip)|*.zip";
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;

            // Extragere nume fisier din calea completa a fisierului - thanks to Silviu
            string extrageNumeFisierDinCale = @"[^\\]+?$";
            string numeFisier = Regex.Match(richTextBox2.Text, extrageNumeFisierDinCale).Value;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ZipArchive zip = ZipFile.Open(saveFileDialog.FileName, ZipArchiveMode.Create))
                {
                    zip.CreateEntryFromFile(richTextBox2.Text, numeFisier);
                }
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }


        //https://stackoverflow.com/questions/5848154/winforms-switching-between-forms
        private void TechnicalTasks(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
