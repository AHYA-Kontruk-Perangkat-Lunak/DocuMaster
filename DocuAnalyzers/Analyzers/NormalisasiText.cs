using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PlagiarismeCore.Analyzers
{
    /// <summary>
    /// Menormalisasi teks: 
    /// - Menghapus diakritik (accents)  
    /// - Mengonversi ke lowercase  
    /// - Menghapus tanda baca (punctuation)  
    /// - Merapikan whitespace  
    /// </summary>
    public static class NormalisasiText
    {
        /// <summary>
        /// Normalisasi string sesuai aturan di atas.
        /// </summary>
        public static string Normalize(string text)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));

            // 1. Decompose ke FormD dan buang non-spacing marks (diakritik)
            string formD = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder(capacity: formD.Length);
            foreach (char ch in formD)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (uc != UnicodeCategory.NonSpacingMark)
                    sb.Append(ch);
            }
            string noDiacritics = sb
                .ToString()
                .Normalize(NormalizationForm.FormC);

            // 2. Lowercase
            string lower = noDiacritics.ToLowerInvariant();

            // 3. Ganti semua karakter non-alphanumeric (termasuk punctuation) jadi spasi
            string noPunct = Regex.Replace(lower, @"[^\p{L}\p{Nd}]+", " ");

            // 4. Collapse whitespace (lebih dari satu spasi → satu spasi) dan trim
            string cleaned = Regex.Replace(noPunct, @"\s+", " ").Trim();

            return cleaned;
        }
    }
}