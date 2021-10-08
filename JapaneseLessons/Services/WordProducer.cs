using JapaneseLessons.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapaneseLessons.Repositories;

namespace JapaneseLessons.Services
{
    public class WordProducer
    {
        private readonly IRepository<Word> _wordRepository;

        public delegate void RunIsOver();
        public event RunIsOver AllWordsWerePassed;

        public WordProducer(IRepository<Word> wordRepository)
        {
            _wordRepository = wordRepository;
        }

        private const int Size = 20;
        private List<Word> words;
        private int currentIndex;
        
        public async Task SetupWords()
        {
            // ToDo: Create lazy load for partition
            var allWords = await _wordRepository.Get();
            words = allWords.Take(Size).ToList();
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