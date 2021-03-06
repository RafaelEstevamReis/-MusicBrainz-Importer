using System;

namespace MB.Lib.Models
{
    public class ArtistAlias
    {
        public int Id { get; set; }
        public int Id2 { get; set; } // reference ?
        public string Name { get; set; }
        public string Locale { get; set; }
        public int C5 { get; set; }
        public DateTime C6 { get; set; }
        public int C7 { get; set; }
        public string SortName { get; set; }

    }
}
