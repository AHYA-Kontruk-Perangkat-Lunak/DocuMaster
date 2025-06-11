using System;

namespace PlagiarismeCore.Analyzers
{
    public static class PenghitungTotalKarakter
    {
        /// <summary>
        /// Hitung total karakter (termasuk spasi & tanda baca).
        /// </summary>
        public static int CountCharacters(string text)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));

            return text.Length;
        }
    }
}