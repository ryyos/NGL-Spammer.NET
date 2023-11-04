using NGL_Spammer.NET.src.assets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGL_Spammer.NET.src.menu
{
    internal class Interfaces
    {
        public List<String> choise()
        {

            List<String> choices = new List<string>();

            Image.image();
            Console.WriteLine("==================================");
            Console.WriteLine("+     Insert UserName Target     +");
            Console.WriteLine("==================================");
            Console.Write("-> ");
            choices.Add(Console.ReadLine());
            Console.Clear();

            Image.image();
            Console.WriteLine("==================================");
            Console.WriteLine("+          Insert Type           +");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Anonymous");
            Console.WriteLine("2. Confesion");
            Console.WriteLine("3. 3 Words");
            Console.WriteLine("4. W FriendSHip");
            Console.WriteLine("5. Rizz Me");
            Console.WriteLine("6. TBH");
            Console.WriteLine("7. Ship me");
            Console.WriteLine("8. Your Crush");
            Console.WriteLine("9. Canceled");
            Console.WriteLine("10. Deal Breaker");
            Console.WriteLine("==================================");
            Console.Write("-> ");
            choices.Add(Console.ReadLine());
            Console.Clear();

            Image.image();
            Console.WriteLine("==================================");
            Console.WriteLine("+      Insert Count Spammer      +");
            Console.WriteLine("==================================");
            Console.Write("-> ");
            choices.Add(Console.ReadLine());
            Console.Clear();

            Image.image();
            Console.WriteLine("==================================");
            Console.WriteLine("+         <---STATUS--->          +");
            Console.WriteLine("==================================");
            return choices;

        }
    }
}
