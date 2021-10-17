using System;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JapaneseLibrary.Repositories;

namespace JapaneseLibrary.UseCases.Word
{
    public class EditWord
    {
        private readonly IRepository<Models.Word> _wordRepository;
        public EditWord(IRepository<Models.Word> wordRepository)
        {
            _wordRepository = wordRepository;
        }

        public async Task Execute(Models.Word word)
        => throw new NotImplementedException();
    }
}