using System;

namespace MB.Lib.Models
{
    public class Artist
    {
        // Sample: 1076328
        public int Id { get; set; }
        // Sample: 8972b1c1-6482-4750-b51f-596d2edea8b1
        public Guid UID { get; set; }
        // Sample: J.B. Lenoir & His African Hunch Rhythm
        public string Name { get; set; }
        // Sample: Lenoir, J.B. & His African Hunch Rhythm
        public string SortName { get; set; }
        // Sample: 1956
        public int StartYear { get; set; }
        // Sample: 12
        public int StartMonth { get; set; }
        // Sample: 28
        public int StartDay { get; set; }
        // Sample: 1993
        public int EndYear { get; set; }
        // Sample: 10
        public int EndMonth { get; set; }
        // Sample: 31
        public int EndDay { get; set; }
        // Sample: 1
        public int C11 { get; set; }
        // Sample: 79674
        public int C12 { get; set; }
        // Sample: 1
        public int C13 { get; set; }
        // Sample: Performed on Enviromental/"Soothing Sounds" albums.
        public string Disambiguation { get; set; }
        // Sample: 0
        public int C15 { get; set; }
        // Sample: 2011-05-17 01:22:02.558151+00
        public DateTime LastUpdated { get; set; }
        // Sample: f
        public bool C17 { get; set; }
        // Sample: 101247
        public int C18 { get; set; }
        // Sample: 101346
        public int C19 { get; set; }
    }
}
