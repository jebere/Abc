using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Soft.Areas.Quantity.Pages.Units
{
    public class DeleteModel : UnitsPage
    {
        public DeleteModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            await getObject(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            await deleteObject(id);
            return RedirectToPage("./Index");
        }

    }

}