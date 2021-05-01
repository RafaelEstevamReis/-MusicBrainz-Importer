using MB.Lib;
using Simple.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MB.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var extractor = new ModelExtractor(@"N:\MusicBrainz Database\mbdump\artist");
            //var model = extractor.BuildModel();

            string path = @"\\nas\home\Organizando\Dados Crawlers\MusicBrainz Database\mbdump\";

            FileReader fr = new FileReader($"{path}\\artist");

            SqliteDB db = new SqliteDB("music.db");
            db.CreateTables()
              .Add<Artists>()
              .Commit();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int count = 0;
            //var names = fr.Get<Lib.Models.Artist>()
            //              .Select(a => a.Name);
            //var hashSet = new HashSet<string>(names);

            var artists = fr.Get<Lib.Models.Artist>()
                            .Select(o => new Artists()
                            {
                                Id = o.UID,
                                Name = o.Name,
                                SortName = o.SortName,
                            });
            db.BulkInsert(artists);

            //File.WriteAllLines("artistsUnique.txt", hashSet.OrderBy(o => o));
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
            Console.WriteLine($"End: Items: {count} Time: {sw.Elapsed}");

        }
    }
    public class Artists
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SortName { get; set; }
    }
}
