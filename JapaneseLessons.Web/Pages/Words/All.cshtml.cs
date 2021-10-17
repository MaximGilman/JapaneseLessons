using JapaneseLibrary.Models;
using JapaneseLibrary.UseCases.Word;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapaneseLessons.Web.Pages.Words
{
    public class AllWordsModel : PageModel
    {
        public IEnumerable<Word> Words { get; set; }

        private readonly GetWords _getWords;
        public AllWordsModel(GetWords getWords)
        {
            _getWords = getWords;
        }

        public async Task OnGet()
        {
            Words = await _getWords.Execute();
        }
    }
}
