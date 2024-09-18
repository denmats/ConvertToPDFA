using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf;

namespace ConvertToPDFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR_KEY");
        }

       

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text) || !File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Please select a valid PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string inputPath = txtFilePath.Text;
            string outputPath = Path.ChangeExtension(inputPath, ".pdfa.pdf");

            try
            {
                // Load the PDF document
                PdfLoadedDocument loadedDocument = new PdfLoadedDocument(inputPath);

                // Convert to PDF/A
                loadedDocument.ConvertToPDFA(PdfConformanceLevel.Pdf_A1B);

                // Save the PDF/A document
                loadedDocument.Save(outputPath);

                // Close the document
                loadedDocument.Close(true);

                MessageBox.Show($"PDF/A document saved successfully at:\n{outputPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
