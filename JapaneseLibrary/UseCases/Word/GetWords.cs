using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JapaneseLibrary.Repositories;

namespace JapaneseLibrary.UseCases.Word
{
    public class GetWords
    {
        private readonly IRepository<Models.Word> _wordsRepository;
        public GetWords(IRepository<Models.Word> wordsRepository)
        {
            _wordsRepository = wordsRepository;
        }

        public async Task<IEnumerable<Models.Word>> Execute(Expression<Func<Models.Word, bool>> expression = null)
        {
            return (await _wordsRepository.Get(expression)).Take(100);
        }
    }
}