using System;
using System.Collections.Generic;
using System.Linq;

namespace PlagiarismeCore.Analyzers
{
	public static class PenghitungKalimat
	{
		/// <summary>
		/// Split teks menjadi kalimat dan hitung totalnya.
		/// </summary>
		public static int CountSentences(string text)
		{
			if (string.IsNullOrWhiteSpace(text))
				return 0;

			// Anggap kalimat diakhiri dengan titik, tanda tanya, atau seru
			var sentences = text.Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
								.Select(s => s.Trim())
								.Where(s => !string.IsNullOrWhiteSpace(s));
			// Pakai generic HitungElemen jika mau, walau biasanya cukup pakai Count()
			return sentences.Count();
		}
	}
}