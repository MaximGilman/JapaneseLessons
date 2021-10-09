using System.Collections.Generic;

namespace JapaneseLessons.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Try> Tries { get; set; }
    }
}