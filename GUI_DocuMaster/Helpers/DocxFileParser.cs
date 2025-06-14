using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novacode; 


namespace GUI_DocuMaster.Helpers
{
    class DocxFileParser : IFileParser
    {
        public async Task<string> ParseAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                using (var document = DocX.Load(filePath))
                {
                    return document.Text;
                }
            });
        }
    }
}
