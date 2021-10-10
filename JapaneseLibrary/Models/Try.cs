namespace JapaneseLibrary.Models
{
    public class Try
    {
        public int Id { get; set; }
        public int WordsCount { get; set; }
        public int SuccessCount { get; set; }
        public int ErrorCount { get; set; }
        public int PercentOfSuccess { get; set; }
        
        public User User { get; set; }
    }
}