using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapaneseLibrary.Models;
using JapaneseLibrary.UseCases.Word;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JapaneseLessons.Web.Pages.Words
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Word Word { get; set; }

        private readonly CreateWord _createWord;

        public CreateModel(CreateWord createWord)
        {
            _createWord = createWord;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            await _createWord.Execute(Word);
            return RedirectToPage("All");
        }
    }
}
