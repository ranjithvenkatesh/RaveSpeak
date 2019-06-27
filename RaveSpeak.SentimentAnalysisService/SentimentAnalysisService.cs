using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace RaveSpeak.SentimentAnalysis
{
    public class SentimentAnalysisService : ISentimentAnalysisService
    {
        public string GetSentiment(string id, string language, string text)
        {
            var client = new RestClient("https://westeurope.api.cognitive.microsoft.com/");
            var request = new RestRequest("text/analytics/v2.0/languages");


            var jsonObject = new
            {
                documents = 
                new [] {
                        new {
                            id = id,
                            language = language,
                            text = text
                        }
                }                
            };

            request.AddJsonBody(JsonConvert.SerializeObject(jsonObject));
            request.AddHeader("Ocp-Apim-Subscription-Key", Environment.GetEnvironmentVariable("Ocp-Apim-Subscription-Key"));
            var response = client.Post(request);

            return response.Content;
        }
    }
}
