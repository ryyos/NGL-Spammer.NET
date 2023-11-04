using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGL_Spammer.NET.src.API
{
    internal class PostAsyn
    {
        public static HttpResponseMessage PostData(FormUrlEncodedContent formData)
        {

            string url = "https://ngl.link/api/submit";


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = client.PostAsync(url, formData).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        // string responseContent = response.Content.ReadAsStringAsync().Result;
                        // Console.WriteLine("-> Send Success : " + responseContent);
                        return response;
                    }
                    else
                    {
                        Console.WriteLine("HTTP POST request failed with status code: " + response.StatusCode);
                        return client.PostAsync(url, formData).Result;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Terjadi kesalahan saat melakukan permintaan POST: " + ex.Message);
                    return client.PostAsync(url, formData).Result;
                }

            }
        }
    }
}
