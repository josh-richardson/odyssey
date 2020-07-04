using System;

namespace Odyssey.Data
{
    public class OdysseyOptions
    {
        public int? WordGoal { get; set; } = null;

        public TimeSpan? TimeGoal { get; set; } = null;

        public bool DisableClipboard { get; set; }

        public bool ExcludeGibberish { get; set; }

        public bool PreventExit { get; set; }

        public string InitialFile { get; set; }
    }
}