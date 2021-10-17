using System.Threading.Tasks;
using JapaneseLibrary.Models;
using JapaneseLibrary.UseCases.Word;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JapaneseLessons.Web.Pages.Words
{
    public class EditModel : PageModel
    {
        private readonly GetWords _getWords;
        private readonly EditWord _editWord;
        public Word Word { get; set; }
        public EditModel(GetWords getWords, EditWord editWord)
        {
            _getWords = getWords;
            _editWord = editWord;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Word = await _getWords.Execute(id.Value);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _editWord.Execute(Word);
            return RedirectToPage("All");
        }
    }
}
