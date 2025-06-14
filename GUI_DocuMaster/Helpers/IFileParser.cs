using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_DocuMaster.Helpers
{
    interface IFileParser
    {
        Task<string> ParseAsync(string filePath);
    }
}
