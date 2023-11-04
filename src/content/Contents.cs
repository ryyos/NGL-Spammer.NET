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
        public FormUrlEncodedContent urlEncode(String username, String questions, String uuid, String gameSlug)
        {

                FormUrlEncodedContent formData = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("username", username),
                        new KeyValuePair<string, string>("question", questions),
                        new KeyValuePair<string, string>("deviceId", uuid),
                        new KeyValuePair<string, string>("gameSlug", gameSlug), 
                        new KeyValuePair<string, string>("referrer", "")

                    });
                
            return formData;

        }
    }
}
