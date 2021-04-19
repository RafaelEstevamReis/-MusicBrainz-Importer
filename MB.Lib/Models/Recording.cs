using System;

namespace MB.Lib.Models
{
    public class Recording
    {
        // Sample: 20937085
        public int Id { get; set; }
        // Sample: 0f42ab32-22cd-4dcf-927b-a8d9a183d68b
        public Guid UID { get; set; }
        // Sample: Travelling Man
        public string Title { get; set; }
        // Sample: 2001233
        public int C04 { get; set; }
        // Sample: 260000
        public int Length { get; set; }
        // Sample: 
        public string Disambiguation { get; set; }
        // Sample: 0
        public int C07 { get; set; }
        // Sample: 2017-05-15 20:36:38.082509+00
        public DateTime LastUpdate { get; set; }
        // Sample: f
        public bool Video { get; set; }
    }

}
