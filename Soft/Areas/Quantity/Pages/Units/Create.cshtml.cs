using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class CreateModel : UnitsPage
    {
        public CreateModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }

       

        public IActionResult OnGet() => Page();

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!await addObject()) return Page();
            return RedirectToPage("./Index");
        }
    }
}