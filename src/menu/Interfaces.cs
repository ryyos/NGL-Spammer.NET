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
        public void choise()
        {

            ArrayList choices = new ArrayList();
            

            Console.WriteLine("==================================");
            Console.WriteLine("+     Insert UserName Target     +");
            Console.WriteLine("==================================");
            Console.Write("->");
            choices.Add(Console.ReadLine());

            Console.WriteLine("==================================");
            Console.WriteLine("+          Insert Type           +");
            Console.WriteLine("==================================");
            Console.Write("->");
            choices.Add(Console.ReadLine());

        }
    }
}
