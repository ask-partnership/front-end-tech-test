using System;

namespace Ask.TechnicalTest.Business.Models
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Country Country { get; set; }
    }
}
