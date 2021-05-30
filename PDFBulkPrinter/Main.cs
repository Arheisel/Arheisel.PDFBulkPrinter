using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArheiselPDFBulkPrinter
{
    public partial class Main : Form
    {
        List<string> Files = new List<string>();

        string SelectedPath = string.Empty;

        public Main()
        {
            InitializeComponent();

            printerList.DataSource = PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    SelectedPath = fbd.SelectedPath;
                    currDir.Text = fbd.SelectedPath;

                    Files = Directory.GetFiles(fbd.SelectedPath).ToList();

                    if (Files.Count <= 0) {
                        printButton.Enabled = false;
                        fileListBox.Items.Clear();
                        return;
                    }

                    var nameList = new List<int>();
                    foreach(string file in Files)
                    {
                        nameList.Add(int.Parse(Path.GetFileNameWithoutExtension(file)));
                    }
                    nameList.Sort();

                    fileListBox.Items.Clear();
                    Files.Clear();
                    foreach (int fnumber in nameList)
                    {
                        Files.Add(Path.Combine(SelectedPath, fnumber + ".pdf"));

                        fileListBox.Items.Add(fnumber + ".pdf");
                    }

                    printButton.Enabled = true;
                    label1.Text = "Status: Ready";
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the printer settings for our printer
                var printerSettings = new PrinterSettings
                {
                    PrinterName = (string)printerList.SelectedItem,
                    Copies = (short)1,
                };

                // Create our page settings for the paper size selected
                var pageSettings = new PageSettings(printerSettings)
                {
                    Margins = new Margins(0, 0, 0, 0),
                };
                foreach (PaperSize paperSize in printerSettings.PaperSizes)
                {
                    if (paperSize.PaperName == "A4")
                    {
                        pageSettings.PaperSize = paperSize;
                        break;
                    }
                }

                var count = 1;
                // Now print the PDF document
                foreach(string file in Files)
                {
                    label1.Text = "Status: Printing... " + count + " of " + Files.Count;
                    using (var document = PdfDocument.Load(file))
                    {
                        using (var printDocument = document.CreatePrintDocument())
                        {
                            printDocument.PrinterSettings = printerSettings;
                            printDocument.DefaultPageSettings = pageSettings;
                            printDocument.PrintController = new StandardPrintController();
                            printDocument.Print();
                        }
                    }
                    count++;
                }

                label1.Text = "Status: Done";

                MessageBox.Show("Done Printing!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
