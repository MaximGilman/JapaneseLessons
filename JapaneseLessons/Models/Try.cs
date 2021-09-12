using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace JapaneseLessons.Models
{
    public class Try
    {
        public Try()
        {
            LearnedWords = new List<Word>();
        }

        public int Id { get; set; }
        public int WordsCount { get; set; }
        public int SuccessCount { get; set; }
        public int ErrorCount { get; set; }
        public int PercentOfSuccess { get; set; }
        public List<Word> LearnedWords { get; set; }
    }
}