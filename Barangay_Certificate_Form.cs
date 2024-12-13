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

namespace Barangay_Management_System
{
    public partial class Barangay_Certificate_Form : Form
    {
        private PrintDocument printDocument;
        public Barangay_Certificate_Form()
        {
            InitializeComponent();
            InitializeCertificationLetter();
          
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        private void InitializeCertificationLetter()
        {
            richtbx.Dock = DockStyle.Fill;
            richtbx.Multiline = true;
          
            // Load initial certification letter text or any default text
            richtbx.Text = "Dear [Recipient],\n\n" +
                                               "This is to certify that [Name] has successfully completed the required " +
                                               "training program on [Date].\n\n" +
                                               "Sincerely,\n[Your Name]\n[Your Title]";

            richtbx.ScrollBars = RichTextBoxScrollBars.Vertical;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Print the content of the RichTextBox
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Print the content of the RichTextBox
            e.Graphics.DrawString(GetRichTextBoxText(), richtbx.Font, Brushes.Black, 12, 12);
        }
        private string GetRichTextBoxText()
        {
            return richtbx.Text;
        }
        private void SaveCertificationLetter()
        {
            // Show a SaveFileDialog to choose a location to save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the content of the RichTextBox to the selected file
                File.WriteAllText(saveFileDialog.FileName, GetRichTextBoxText());
                MessageBox.Show("Certification letter saved!", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCertificationLetter();
        }
    }
}
