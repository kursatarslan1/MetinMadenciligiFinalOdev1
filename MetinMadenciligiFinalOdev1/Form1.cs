using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;


namespace MetinMadenciligiFinalOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvResults.FirstDisplayedScrollingColumnIndex = 5;
            dgvResults.FirstDisplayedScrollingRowIndex = 0;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;
            TextAnalyzer analyzer = new TextAnalyzer(text);
            List<string> results = analyzer.AnalyzeText();
            dgvResults.Rows.Clear();
            dgvResults.Rows.Add(results.ToArray());
            FillLabel(results);
        }

        private void btnDownloadExcelFile_Click(object sender, EventArgs e)
        {
            // Kullanıcıya dosya kaydetme yeri seçtirme
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Results to Excel File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Analysis Results");

                            for (int col = 0; col < dgvResults.Columns.Count; col++)
                            {
                                worksheet.Cells[1, col + 1].Value = dgvResults.Columns[col].HeaderText;
                            }

                            for (int row = 0; row < dgvResults.Rows.Count; row++)
                            {
                                for (int col = 0; col < dgvResults.Columns.Count; col++)
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = dgvResults.Rows[row].Cells[col].Value?.ToString() ?? "";
                                }
                            }

                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fileInfo);
                        }

                        MessageBox.Show("Excel dosyası başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Excel dosyasını kaydederken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
     
        }

        private void FillLabel(List<string> result)
        {
            lblPunctuationCount.Text = AddValueToLabel(lblPunctuationCount.Text, result[0]);
            lblSentenceCount.Text = AddValueToLabel(lblSentenceCount.Text, result[1]);
            lblWordCount.Text = AddValueToLabel(lblWordCount.Text, result[2]);
            lblSyllableCount.Text = AddValueToLabel(lblSyllableCount.Text, result[3]);
            lblLetterCount.Text = AddValueToLabel(lblLetterCount.Text, result[4]);
            lblRootCount.Text = AddValueToLabel(lblRootCount.Text, result[5]);
            lblAverageWordCountPerSentence.Text = AddValueToLabel(lblAverageWordCountPerSentence.Text, result[6]);
            lblAverageSyllableCountPerWord.Text = AddValueToLabel(lblAverageSyllableCountPerWord.Text, result[7]);
            lblAverageLetterCountPerWord.Text = AddValueToLabel(lblAverageLetterCountPerWord.Text, result[8]);

            lblMostUsedRoots.Text = AddValueToLabel(lblMostUsedRoots.Text, result[9]);
            lblLeastUsedRoots.Text = AddValueToLabel(lblLeastUsedRoots.Text, result[10]);
            lblMostUsedSyllables.Text = AddValueToLabel(lblMostUsedSyllables.Text, result[11]);
            lblLeastUsedSyllables.Text = AddValueToLabel(lblLeastUsedSyllables.Text, result[12]);
            lblMostUsedLetters.Text = AddValueToLabel(lblMostUsedLetters.Text, result[13]);
            lblLeastUsedLetters.Text = AddValueToLabel(lblLeastUsedLetters.Text, result[14]);
            lblSyllableGroupsByWord.Text = AddValueToLabel(lblSyllableGroupsByWord.Text, result[15]);
            lblSuffixGroupByWord.Text = AddValueToLabel(lblSuffixGroupByWord.Text, result[16]);
        }

        private string AddValueToLabel(string currentText, string newValue)
        {
            // Eğer ":" karakteri varsa, iki nokta sonrasını ekleyelim
            if (newValue.Contains(":"))
            {
                var parts = newValue.Split(new[] { ':' }, 2); // ":" ile ayır
                return currentText + " " + parts[1]; // Sonrasını ekleyelim
            }
            else
            {
                return currentText + " " + newValue; // Eğer ":" yoksa direkt ekleyelim
            }
        }
    }
}
