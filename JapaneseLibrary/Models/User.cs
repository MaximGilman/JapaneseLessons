using System.Collections.Generic;

namespace JapaneseLibrary.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Try> Tries { get; set; }
    }
}