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
        /// Hitung persentase kemiripan dua file berbasis Jaccard Similarity pada kata unik.
        /// </summary>
        public static double CalculateJaccardSimilarity(string filePath1, string filePath2)
        {
            string text1 = FileTextReader.ReadText(filePath1);
            string text2 = FileTextReader.ReadText(filePath2);

            // Normalisasi agar adil
            string norm1 = NormalisasiText.Normalize(text1);
            string norm2 = NormalisasiText.Normalize(text2);

            var words1 = new HashSet<string>(norm1.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            var words2 = new HashSet<string>(norm2.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            if (words1.Count == 0 && words2.Count == 0) return 100.0;
            if (words1.Count == 0 || words2.Count == 0) return 0.0;

            var intersection = new HashSet<string>(words1);
            intersection.IntersectWith(words2);

            var union = new HashSet<string>(words1);
            union.UnionWith(words2);

            double similarity = (double)intersection.Count / union.Count * 100.0;
            return similarity;
        }
    }
}