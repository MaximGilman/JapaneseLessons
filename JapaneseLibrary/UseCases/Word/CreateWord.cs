using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JapaneseLibrary.Repositories;

namespace JapaneseLibrary.UseCases.Word
{
    public class CreateWord
    {
        private readonly IRepository<Models.Word> _wordRepository;
        public CreateWord(IRepository<Models.Word> wordRepository)
        {
            _wordRepository = wordRepository;
        }

        public async Task Execute(Models.Word word)
        => await _wordRepository.Add(word);
    }
}