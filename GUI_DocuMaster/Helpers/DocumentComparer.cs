using System;
using System.Collections.Generic;
using System.IO;

namespace GUI_DocuMaster.Helpers
{
    public static class DocumentComparer
    {
        public static List<(int Baris, string Text1, string Text2)> CompareFiles(string path1, string path2)
        {
            var lines1 = FileTextReader.ReadText(path1)
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            var lines2 = FileTextReader.ReadText(path2)
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            int max = Math.Max(lines1.Length, lines2.Length);
            var result = new List<(int, string, string)>();

            for (int i = 0; i < max; i++)
            {
                string l1 = i < lines1.Length ? lines1[i] : "";
                string l2 = i < lines2.Length ? lines2[i] : "";
                if (l1 != l2)
                {
                    result.Add((i + 1, l1, l2));
                }
            }
            return result;
        }
    }
}