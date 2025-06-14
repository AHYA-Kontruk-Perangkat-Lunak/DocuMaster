using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace GUI_DocuMaster.Helpers
{
    class TxtFileParser : IFileParser
    {
        public async Task<string> ParseAsync(string filePath)
        {
            return await File.ReadAllTextAsync(filePath);
        }
    }
}
