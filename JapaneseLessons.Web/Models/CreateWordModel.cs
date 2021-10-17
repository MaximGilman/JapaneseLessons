using JapaneseLibrary.Models;

namespace JapaneseLessons.Web.Models
{
    public class CreateWordModel 
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Meaning { get; set; }
        public string PronounceRussian { get; set; }
        public string PronounceJapanese { get; set; }
        public Lesson Lesson { get; set; }
    }
}