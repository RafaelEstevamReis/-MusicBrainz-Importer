using System;

namespace Importer.Models
{
    public class Artist
    {
        public int C1 { get; set; }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string SortName { get; set; }
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }
        public int EndYear { get; set; }
        public int EndMonth { get; set; }
        public int EndDay { get; set; }
        public string C11 { get; set; }
        public string C12 { get; set; }
        public string C13 { get; set; }
        public string Disambiguation { get; set; }
        public string C15 { get; set; }
        public DateTime C16 { get; set; }
        public bool C17 { get; set; }
        public string C18 { get; set; }
        public string C19 { get; set; }
    }
}
