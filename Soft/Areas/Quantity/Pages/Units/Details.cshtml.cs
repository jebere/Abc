using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Soft.Areas.Quantity.Pages.Units
{
    public class DetailsModel : UnitsPage
    {
        public DetailsModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {

            await getObject(id);

            return Page();
        }

    }

}

