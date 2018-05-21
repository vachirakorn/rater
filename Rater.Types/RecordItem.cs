using System;

namespace Rater.Types
{
    public class RecordItem
    {
        public string ButtonName { get; set; }
        public string TestNumber { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public TimeSpan Duration { get; set; }
        

    }
}
