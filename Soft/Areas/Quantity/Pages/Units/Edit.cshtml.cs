using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class EditModel : UnitsPage
    {
        public EditModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await getObject(id);

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            await updateObject();
            return RedirectToPage("./Index");
        }

    }

}
