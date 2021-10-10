using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JapaneseLibrary.Repositories;
using JapaneseLibrary.Models;
namespace JapaneseLibrary.UseCases.User
{
    public class GetUser
    {
        private readonly IRepository<Models.User> _userRepository;
        public GetUser(IRepository<Models.User> userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<Models.User> Execute(Expression<Func<Models.User, bool>> expression = null)
        {
            return await _userRepository.GetFirstOrDefault(expression);
        }
    }
}