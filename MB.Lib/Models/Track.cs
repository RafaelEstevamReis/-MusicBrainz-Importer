using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Lib.Models
{
    public class Track
    {
        // Sample: 34228823
        public int Id { get; set; }
        // Sample: 9b02977e-a03b-4a6b-a9a9-06e722bdcd7a
        public Guid UID { get; set; }
        // Sample: 428644
        public int C03 { get; set; }
        // Sample: 3254461
        public int C04 { get; set; }
        // Sample: 1
        public int Position { get; set; }
        // Sample: A1
        public string Number { get; set; }
        // Sample: The Ghost of Tom Joad
        public string Title { get; set; }
        // Sample: 813
        public int C08 { get; set; }
        // Sample: 263000
        public int Length { get; set; }
        // Sample: 0
        public int C10 { get; set; }
        // Sample: 2021-02-21 12:19:56.629604+00
        public DateTime LastUpdated { get; set; }
        // Sample: f
        public bool C12 { get; set; }
    }

}
