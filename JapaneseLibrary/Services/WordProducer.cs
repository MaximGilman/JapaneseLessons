﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapaneseLibrary.Models;
using JapaneseLibrary.Repositories;
using JapaneseLibrary.UseCases.Word;

namespace JapaneseLibrary.Services
{
    public class WordProducer
    {
        private readonly GetWords _getWords;

        public delegate void RunIsOver();
        public event RunIsOver AllWordsWerePassed;

        public WordProducer(GetWords getWords)
        {
            _getWords = getWords;
        }

        private const int WordsAmount = 20;
        private List<Word> words;
        private int currentIndex;

        public async Task SetupWords()
        {
            // ToDo: Create lazy load for partition
            var allWords = await _getWords.Execute();
            if (!allWords.Any())
                throw new KeyNotFoundException("No words found");
            words = allWords.Take(WordsAmount).ToList();
        }

        public void Clear()
        {
            words = null;
        }

        public Word GetNextWord()
        {
            if (words == null || words.Count <= currentIndex || currentIndex >= WordsAmount)
            {
                AllWordsWerePassed?.Invoke();
                Clear();
                return null;
            }
            return words[currentIndex++];
        }
    }
}