using System.IO;
using Xceed.Words.NET;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

public static class FileTextReader
{
    public static string ReadText(string filePath)
    {
        string ext = Path.GetExtension(filePath).ToLowerInvariant();
        if (ext == ".txt")
        {
            return File.ReadAllText(filePath);
        }
        else if (ext == ".docx")
        {
            using (var doc = DocX.Load(filePath))
            {
                return doc.Text;
            }
        }
        else if (ext == ".pdf")
        {
            return ReadPdfText(filePath);
        }
        else
        {
            throw new NotSupportedException("Format file tidak didukung. Hanya .txt, .docx, dan .pdf.");
        }
    }

    private static string ReadPdfText(string filePath)
    {
        using (PdfDocument pdf = PdfDocument.Open(filePath))
        {
            var sb = new System.Text.StringBuilder();
            foreach (Page page in pdf.GetPages())
            {
                sb.AppendLine(page.Text);
            }
            return sb.ToString();
        }
    }
}