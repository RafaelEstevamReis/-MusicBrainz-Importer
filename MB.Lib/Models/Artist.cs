using System;

namespace MB.Lib.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public Guid UID { get; set; }
        public string Name { get; set; }
        public string SortName { get; set; }
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }
        public int EndYear { get; set; }
        public int EndMonth { get; set; }
        public int EndDay { get; set; }
        public int C11 { get; set; }
        public int C12 { get; set; }
        public int C13 { get; set; }
        public string Disambiguation { get; set; }
        public int C15 { get; set; }
        public DateTime C16 { get; set; }
        public bool C17 { get; set; }
        public int C18 { get; set; }
        public int C19 { get; set; }
    }
}
