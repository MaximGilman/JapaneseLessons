namespace JapaneseLessons.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Meaning { get; set; }
        public string PronounceRussian { get; set; }
        public string PronounceJapanese { get; set; }
    }
}