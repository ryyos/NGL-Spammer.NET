using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGL_Spammer.NET.src.content
{
    internal class Contents
    {
        public String urlEncode(String username, List<String> questions, List<String> uuid)
        {
            ArrayList urls = new ArrayList();

        for(int i = 0; i <= questions.Count; i++)
            {

                urls.Add(new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("username", $"\"{username}\""),
                new KeyValuePair<string, string>("question", $"\"{questions[i]}\""),
                new KeyValuePair<string, string>("deviceId", $"\"{uuid[i]}\""),
                new KeyValuePair<string, string>("gameSlug", ""),
                new KeyValuePair<string, string>("referrer", "")

            }));
            }



            return null;
        }
    }
}
