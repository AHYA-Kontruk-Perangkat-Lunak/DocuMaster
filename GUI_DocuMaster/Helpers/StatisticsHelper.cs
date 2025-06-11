using System.IO;
using PlagiarismeCore.Analyzers;

namespace DocuMaster.Helpers // Ganti dengan namespace sesuai project GUI kamu
{
    public static class StatisticsHelper
    {
        /// <summary>
        /// Mengambil statistik file: karakter, kata, kalimat
        /// </summary>
        public static string GetTextStatistics(string filePath)
        {
            string text = FileTextReader.ReadText(filePath);

            // Normalisasi (untuk kata)
            string normalized = NormalisasiText.Normalize(text);

            int totalChars = PenghitungTotalKarakter.CountCharacters(text);
            int totalWords = PenghitungKata.CountWords(normalized);
            int totalSentences = PenghitungKalimat.CountSentences(text);

            return
                $"Statistik File: {Path.GetFileName(filePath)}\n" +
                $"- Total Karakter: {totalChars}\n" +
                $"- Total Kata: {totalWords}\n" +
                $"- Total Kalimat: {totalSentences}\n";
        }
    }
}