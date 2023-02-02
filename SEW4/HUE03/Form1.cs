using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;      // für Progress Bar
using System.Collections.ObjectModel;

namespace HUE03
{
    public partial class Form1 : Form
    {
        private ConcurrentBag<string> analysePfad;      // ConcurrentBag gibt bei einer Abfrage ein aus Sicht des Anwenders zufälliges Element zurück.
                                                        // Dabei wird aber nicht nach dem Zufallsprinzip gehandelt,
                                                        // sondern es findet eine geschwindigkeitsoptimierte Abfrage statt.
                                                        // Die ConcurrentBag Collection gibt somit immer das Element zurück welches am effizientesten ermittelt werden kann.
        private string ergebnisPfad;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Multiselect = true;      // mehrer Dateien können gewählt werden
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";     // nur .txt Dateien können gewählt werden

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                analysePfad = new ConcurrentBag<string>(openFileDialog.FileNames);
            }

        }

        private void btnSelectResultDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ergebnisPfad = folderBrowserDialog.SelectedPath;
            }
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            progressBar.Value = 0;
            progressBar.Maximum = analysePfad.Count;

            List<Task> tasks = new List<Task>();

            foreach (string file in analysePfad)
            {
                tasks.Add(Task.Run(() => Analyse(file)));   // Hilfe von Zarzer
            }

            await Task.WhenAll(tasks);

            txtResult.AppendText("Alles Fertig!");
        }

        private void Analyse(string file)
        {
            int[] frequency = new int[26];

            StreamReader reader = new StreamReader(file);

            int character;
            while ((character = reader.Read()) != -1)       //solange bis zum Ende der Datei
            {
                if (char.IsLetter((char)character))
                {
                    frequency[char.ToLower((char)character) - 'a']++; 
                }
            }


            
            string resultFile = "häufigkeit_" + Path.GetFileName(file);

            StreamWriter writer = new StreamWriter(resultFile);

            for (int i = 0; i < 26; i++)
            {
                writer.WriteLine((char)(i + 'a') + " : " + frequency[i]);
            }


            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value++;
            });

            txtResult.Invoke((MethodInvoker)delegate
            {
                txtResult.AppendText(Path.GetFileName(file) + " wurde analysiert.\r\n");
            });
        }
    }
}
