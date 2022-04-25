#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using MovieCrud.Entity;
using MovieCrud.Models;

namespace MovieCrud.Pages
{
    public class Create2Model : PageModel
    {
        private readonly IRepository<Movie> _repository;

        public Create2Model(IRepository<Movie> repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _repository.CreateAsync(Movie);

            return RedirectToPage("./Index");
        }
    }
}
