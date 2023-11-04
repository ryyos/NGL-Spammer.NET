using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NGL_Spammer.NET.src.assets
{
    internal class QuestionsAsset
    {
        public List<String> questions(int count)
        {
            String path = @"D:\playground\C#\NGL-Spammer.NET\src\json\Questions.json";
            List<String> questions = new List<string>();
            Random random = new Random();

            String raw = File.ReadAllText(path);
            List<String> allQuests = JsonConvert.DeserializeObject<List<String>>(raw);

            for(int i = 0; i < count; i++)
            {
                questions.Add(allQuests[random.Next(199)]);
            }
            
            return questions;
        }
    }
}
