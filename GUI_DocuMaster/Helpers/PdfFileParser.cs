using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace GUI_DocuMaster.Helpers
{
    class PdfFileParser : IFileParser
    {
        public async Task<string> ParseAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                var builder = new StringBuilder();
                using (PdfDocument document = PdfDocument.Open(filePath))
                {
                    foreach (Page page in document.GetPages())
                    {
                        builder.AppendLine(page.Text);
                    }
                }
                return builder.ToString();
            });
        }
    }
}
