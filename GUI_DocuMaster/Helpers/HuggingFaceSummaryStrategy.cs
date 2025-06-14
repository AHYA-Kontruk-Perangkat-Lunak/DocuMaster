using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace GUI_DocuMaster.Helpers
{
    class HuggingFaceSummaryStrategy : ISummaryStrategy
    {
        private readonly string _apiToken;

        public HuggingFaceSummaryStrategy(string apiToken)
        {
            if (string.IsNullOrWhiteSpace(apiToken))
                throw new ArgumentException("API token harus valid.", nameof(apiToken));

            _apiToken = apiToken;
        }

        public async Task<string> SummarizeAsync(string inputText)
        {
            if (string.IsNullOrWhiteSpace(inputText))
                return "Teks kosong tidak dapat dirangkum.";

            var client = new RestClient("https://api-inference.huggingface.co/models/facebook/bart-large-cnn");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Authorization", $"Bearer {_apiToken}");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new { inputs = inputText });

            var response = await client.ExecuteAsync(request);

            if (!response.IsSuccessful)
                return $"Gagal merangkum: {response.StatusDescription}";

            var json = JArray.Parse(response.Content);
            return json[0]?["summary_text"]?.ToString() ?? "Tidak ada ringkasan yang dihasilkan.";
        }
    }
}
