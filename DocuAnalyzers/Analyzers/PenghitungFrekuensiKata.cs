using System;
using System.Collections.Generic;

namespace PlagiarismeCore.Analyzers
{
    public static class PenghitungFrekuensiKata
    {
        /// <summary>
        /// Generic: hitung frekuensi elemen apa pun.
        /// </summary>
        public static Dictionary<T, int> HitungElemen<T>(IEnumerable<T> elemen)
            where T : notnull
        {
            if (elemen is null)
                throw new ArgumentNullException(nameof(elemen));

            var dict = new Dictionary<T, int>();
            foreach (var e in elemen)
            {
                if (dict.ContainsKey(e)) dict[e]++;
                else dict[e] = 1;
            }
            return dict;
        }
    }
}