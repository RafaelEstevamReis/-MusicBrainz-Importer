using System;
using System.Diagnostics;
using MB.Lib;

namespace MB.Importer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileReader fr = new FileReader(@"\mbdump\artist");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int i = 0;
            foreach (var item in fr.Get<Lib.Models.Artist>())
            {
                i++;
                //Console.WriteLine(item.Nome);
            }

            sw.Stop();
            Console.WriteLine($"End: Items: {i} Time: {sw.Elapsed}");

        }
    }
}
