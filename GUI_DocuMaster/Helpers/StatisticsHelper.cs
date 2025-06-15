using System;
using System.IO;
using PlagiarismeCore.Analyzers;

namespace DocuMaster.Helpers
{
    public static class StatisticsHelper
    {
        /// <summary>
        /// Mengambil statistik file: karakter, kata, kalimat.
        /// </summary>
        /// <param name="filePath">Path ke file yang dianalisis.</param>
        /// <returns>String ringkasan statistik file.</returns>
        public static string GetTextStatistics(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File tidak ditemukan: {filePath}");

            string text = FileTextReader.ReadText(filePath);

            // Normalisasi (untuk perhitungan kata)
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