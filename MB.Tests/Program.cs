using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using MB.Lib;

namespace MB.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var extractor = new ModelExtractor(@"N:\MusicBrainz Database\mbdump\artist");
            var model = extractor.BuildModel();


            FileReader fr = new FileReader(@"N:\MusicBrainz Database\mbdump\artist");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            var names = fr.Get<Lib.Models.Artist>()
                          .Select(a => a.Name);
            var hashSet = new HashSet<string>(names);

            File.WriteAllLines("artistsUnique.txt", hashSet.OrderBy(o => o));
            //int i = 0;
            //using var fs = File.OpenWrite("artists.txt");
            //using var swr = new StreamWriter(fs, Encoding.UTF8);
            //foreach (var item in fr.Get<Lib.Models.Artist>())
            //{
            //    i++;
            //    swr.WriteLine($"{item.SortName}");
            //}
            //swr.Flush();
            sw.Stop();
            Console.WriteLine($"End: Items: {hashSet.Count} Time: {sw.Elapsed}");

        }
    }
}
