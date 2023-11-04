using System;
using System.Collections;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        
        string url = "https://ngl.link/api/submit";

        
        using (HttpClient client = new HttpClient())
        {

            FormUrlEncodedContent formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", "ryosoraa"),
                new KeyValuePair<string, string>("question", "helooo"),
                new KeyValuePair<string, string>("deviceId", "f317828d-2aaf-48c4-aa3c-4f1b7deae77e"),
                new KeyValuePair<string, string>("gameSlug", ""),
                new KeyValuePair<string, string>("referrer", "")
            });

            

            for(int i = 1; i < 4; i++)
            {
            HttpResponseMessage response = await client.PostAsync(url, formData);
                
                if (response.IsSuccessStatusCode)
                {
                    
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);
                }
                else
                {
                    Console.WriteLine("HTTP POST request gagal dengan kode status: " + response.StatusCode);
                }

            }


        }
    }
}
