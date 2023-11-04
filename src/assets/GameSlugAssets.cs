using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGL_Spammer.NET.src.assets
{
    internal class GameSlugAssets
    {
        public String gameSlug(int type)
        {
            String path = @"D:\playground\C#\NGL-Spammer.NET\src\json\GameSlug.json";
            Random random = new Random();

            String raw = File.ReadAllText(path);
            List<String> games = JsonConvert.DeserializeObject<List<String>>(raw);

            return games[type];
        }
    }
}
