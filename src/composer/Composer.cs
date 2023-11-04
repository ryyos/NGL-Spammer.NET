using NGL_Spammer.NET.src.API;
using NGL_Spammer.NET.src.assets;
using NGL_Spammer.NET.src.content;
using NGL_Spammer.NET.src.menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGL_Spammer.NET.src.composer
{
    internal class Composer
    {
        public void chief()
        {
            Interfaces interfaces = new Interfaces();
            PostAsyn postAsyn = new PostAsyn();
            Contents contents = new Contents();

            QuestionsAsset questionsAsset = new QuestionsAsset();
            UuidAssets uuidAssets = new UuidAssets();
            GameSlugAssets gameSlugAssets = new GameSlugAssets();

            List<String> choose = interfaces.choise();
            

            String userName = choose[0];
            int type = Convert.ToInt32(choose[1]);
            int count = Convert.ToInt32(choose[2]);

            List<String> questions = questionsAsset.questions(count);
            List<String> uuid = uuidAssets.uuid(count);
            String gameSlug = gameSlugAssets.gameSlug(type);


            for(int i = 0; i < questions.Count; i++)
            {
                FormUrlEncodedContent urlEncode = contents.urlEncode(userName, questions[i], uuid[i], gameSlug);
                HttpResponseMessage response = PostAsyn.PostData(urlEncode);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"ID       : {i}");
                    Console.WriteLine($"Status   : Send Success!!");
                    Console.WriteLine($"Message  : {questions[i]}");
                    Console.WriteLine($"Response : {response.Content.ReadAsStringAsync().Result}");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                } else
                {
                    Console.WriteLine($"ID       : {i}");
                    Console.WriteLine($"Status   : Send Failed!!");
                    Console.WriteLine($"Message  : {questions[i]}");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                }



            }


        }
    }
}
