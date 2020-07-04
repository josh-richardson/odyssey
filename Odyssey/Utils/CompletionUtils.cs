using System.Linq;
using GibberishClassification;

namespace Odyssey.Utils
{
    internal class CompletionUtils
    {
        public static int GetWordCount(string text, bool excludeGibberish)
        {
            if (!excludeGibberish) return text.Split(' ').Where(i => i.Length != 0).ToArray().Length;

            var withoutGibberish = string.Join(" ",
                GibberishClassifier.SplitInChunks(text, 120).Where(i => GibberishClassifier.Classify(i) <= 60)
                    .ToArray());
            return GetWordCount(withoutGibberish, false);
        }
    }
}