using System.Linq;

namespace PlagiarismeCore.Analyzers
{
    public static class PenghitungKata
    {
        /// <summary>
        /// Hitung total kata via split + generic frequency counter.
        /// </summary>
        public static int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            // Gunakan null! untuk menghindari warning passing null literal
            var words = text
                .Split((char[])null!, StringSplitOptions.RemoveEmptyEntries);

            var freq = PenghitungFrekuensiKata.HitungElemen(words);
            return freq.Values.Sum();
        }
    }
}