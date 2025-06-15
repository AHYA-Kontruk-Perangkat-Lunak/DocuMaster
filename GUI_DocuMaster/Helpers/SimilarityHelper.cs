using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PlagiarismeCore.Analyzers;

namespace GUI_DocuMaster.Helpers
{
    public static class SimilarityHelper
    {
        /// <summary>
        /// Menghitung persentase kemiripan dua file menggunakan Jaccard Similarity pada kata unik.
        /// </summary>
        /// <param name="filePath1">Path file pertama.</param>
        /// <param name="filePath2">Path file kedua.</param>
        /// <returns>Persentase kemiripan [0.0 - 100.0]</returns>
        public static double CalculateJaccardSimilarity(string filePath1, string filePath2)
        {
            // Defensive: cek file exists, supaya error lebih informatif (optional, bisa juga di layer atas)
            if (!File.Exists(filePath1)) throw new FileNotFoundException($"File tidak ditemukan: {filePath1}");
            if (!File.Exists(filePath2)) throw new FileNotFoundException($"File tidak ditemukan: {filePath2}");

            string text1 = FileTextReader.ReadText(filePath1);
            string text2 = FileTextReader.ReadText(filePath2);

            var words1 = NormalizeAndSplit(text1);
            var words2 = NormalizeAndSplit(text2);

            if (words1.Count == 0 && words2.Count == 0) return 100.0;
            if (words1.Count == 0 || words2.Count == 0) return 0.0;

            int intersection = words1.Intersect(words2).Count();
            int union = words1.Union(words2).Count();

            double similarity = (double)intersection / union * 100.0;
            return similarity;
        }

        /// <summary>
        /// Menormalkan string dan membaginya menjadi kumpulan kata unik (HashSet).
        /// </summary>
        /// <param name="text">Teks mentah dari file</param>
        /// <returns>HashSet kata unik yang sudah dinormalisasi</returns>
        private static HashSet<string> NormalizeAndSplit(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return new HashSet<string>();
            string normalized = NormalisasiText.Normalize(text);
            return new HashSet<string>(
                normalized.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            );
        }
    }
}