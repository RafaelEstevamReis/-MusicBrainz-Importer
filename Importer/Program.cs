using System;

namespace Importer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileReader fr = new FileReader(@"C:\sblevers\mbdump\artist");

            foreach (var item in fr.Get<Models.Artist>())
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}
