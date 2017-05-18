using System;

namespace Ask.TechnicalTest.Data.Entities
{
    public class Event : Entity
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Country Country { get; set; }
    }
}
