using System;
using System.Collections.Generic;
using System.Linq;
using JapaneseLessons.Context;
using JapaneseLessons.Models;

namespace JapaneseLessons.Services
{
    public class WordProducer
    {
        public delegate void RunIsOver();
        public event RunIsOver AllWordsWerePassed;

        private const int Size = 20;
        private List<Word> words;
        private int currentIndex;
        public void SetupWords(MyLessonsContext ctx)
        {
            words = ctx.Words.Take(Size).ToList();
        }
        
        public void Clear()
        {
            words = null;
        }
        
        public Word GetNextWord()
        {
            if (words == null || words.Count <= currentIndex || currentIndex >= Size)
            {
                AllWordsWerePassed?.Invoke();
                return null;
            }
            return words[currentIndex++];
        }
    }
}