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
    public class IndexModel : PageModel
    {
        private TechTermRepository repository = new TechTermRepository();
        public IReadOnlyList<TechTerm> TechTerms
        {
            get
            {
                return repository.TechTerms;
            }
        }
        public void OnGet()
        {

        }
    }
}