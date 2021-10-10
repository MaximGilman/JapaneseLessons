using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using JapaneseLibrary.Repositories;
namespace JapaneseLibrary.UseCases.User
{
    public class GetUsers
    {
        private readonly IRepository<Models.User> _userRepository;
        public GetUsers(IRepository<Models.User> userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<IEnumerable<Models.User>> Execute(Expression<Func<Models.User, bool>> expression = null)
        {
            return await _userRepository.Get(expression);
        }
    }
}