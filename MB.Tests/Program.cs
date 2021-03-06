using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using MB.Lib;

namespace MB.Tests
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
            using var fs = File.OpenWrite("artistsSort.txt");
            using var swr = new StreamWriter(fs, Encoding.UTF8);
            foreach (var item in fr.Get<Lib.Models.Artist>())
            {
                i++;
                swr.WriteLine($"{item.SortName}");
            }
            swr.Flush();
            sw.Stop();
            Console.WriteLine($"End: Items: {i} Time: {sw.Elapsed}");

        }
    }
}
