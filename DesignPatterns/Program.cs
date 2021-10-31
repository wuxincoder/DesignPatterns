using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace DesignPatterns
{
    


    internal class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();

            j.AddEntry("I cried today");

            j.AddEntry("I ate a bug");

            WriteLine(j);

        }
    }
}
