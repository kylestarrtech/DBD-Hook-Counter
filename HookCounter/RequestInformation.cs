using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HookCounter
{
    public static class RequestInformation
    {
        public async static void SendPOSTRequest(string url, string jsonData)
        {
            using (var client = new HttpClient()) {
                var response = await client.PostAsync(url,
                    new StringContent(jsonData, Encoding.UTF8, "application/json"));
            }
        }

        public static string ConvertToJSON(int s1, int s2, int s3, int s4)
        {
            string finalJSON =
                "{" +
                    "\"hooks\": [" +
                    $"{s1}," +
                    $"{s2}," +
                    $"{s3}," +
                    $"{s4}" +
                    "]," +
                    "\"deaths\": [" +
                    $"{(s1 >= 3).ToString().ToLower()}," +
                    $"{(s2 >= 3).ToString().ToLower()}," +
                    $"{(s3 >= 3).ToString().ToLower()}," +
                    $"{(s4 >= 3).ToString().ToLower()}" +
                    "]" +
                "}";
            return finalJSON;
        }
    }
}
