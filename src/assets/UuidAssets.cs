using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGL_Spammer.NET.src.assets
{
    internal class UuidAssets
    {
        public List<String> uuid(int count)
        {
            String path = @"D:\playground\C#\NGL-Spammer.NET\src\json\UUID.json";
            List<String> uuids = new List<string>();
            Random random = new Random();

            String raw = File.ReadAllText(path);
            List<String> allUuid = JsonConvert.DeserializeObject<List<String>>(raw);

            for (int i = 0; i < count; i++)
            {
                uuids.Add(allUuid[random.Next(148)]);
            }

            return uuids;
        }
    }
}
