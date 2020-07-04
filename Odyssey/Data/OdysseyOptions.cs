using System;

namespace Odyssey.Data
{
    public class OdysseyOptions
    {

        public int? WordGoal { get; set; }
        
        public TimeSpan? TimeGoal { get; set; }

        public bool DisableClipboard { get; set; }

        public bool ExcludeGibberish { get; set; }

        public bool PreventExit { get; set; }
    }
}
