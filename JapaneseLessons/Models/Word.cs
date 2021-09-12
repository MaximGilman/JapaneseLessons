﻿using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace JapaneseLessons.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Meaning { get; set; }
        public string PronounceRussian { get; set; }
        public string PronounceJapanese { get; set; }
        public List<Try> ExistedTries { get; set; }

    }
}