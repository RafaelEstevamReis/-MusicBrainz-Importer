using System;
using System.Diagnostics;

namespace Importer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileReader fr = new FileReader(@"C:\sblevers\mbdump\artist");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int i = 0;
            foreach (var item in fr.Get<Models.Artist>())
            {
                i++;
                //Console.WriteLine(item.Nome);
            }

            sw.Stop();
            Console.WriteLine($"End: Items: {i} Time: {sw.Elapsed}");

        }
    }
}
