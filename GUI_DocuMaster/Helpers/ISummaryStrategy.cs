using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_DocuMaster.Helpers
{
    interface ISummaryStrategy
    {
        Task<string> SummarizeAsync(string inputText);
    }
}
