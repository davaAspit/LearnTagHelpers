using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnTagHelpers.Logic;
using LearnTagHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnTagHelpers.Pages.TechTerms
{
    public class CreateModel : PageModel
    {
        private TechTermRepository repository = new TechTermRepository();
        [BindProperty]
        public TechTerm TechTerm { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            repository.Add(TechTerm);
        }
    }
}