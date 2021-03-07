using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Lib.Models
{
    public class Release
    {
        // Sample: 372235
        public int Id { get; set; }
        // Sample: 425cf29a-1490-43ab-abfa-7b17a2cec351
        public Guid UID { get; set; }
        // Sample: Silent All These Years
        public string Title { get; set; }
        // Sample: 20211
        public int C04 { get; set; }
        // Sample: 896742
        public int C05 { get; set; }
        // Sample: 1
        public int C06 { get; set; }
        // Sample: 1
        public int C07 { get; set; }
        // Sample: 120
        public int C08 { get; set; }
        // Sample: 28
        public int C09 { get; set; }
        // Sample: 5017556902295
        public int C10 { get; set; }
        // Sample: 
        public int Disambiguation { get; set; }
        // Sample: 0
        public int C12 { get; set; }
        // Sample: -1
        public string C13 { get; set; }
        // Sample: 2010-03-30 19:04:18.144351+00
        public DateTime C14 { get; set; }
    }

}
