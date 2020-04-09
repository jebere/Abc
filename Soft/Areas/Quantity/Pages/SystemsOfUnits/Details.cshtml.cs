using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Soft.Areas.Quantity.Pages.SystemsOfUnits
{
    public class DetailsModel : SystemsOfUnitsPage
    {
        public DetailsModel(ISystemsOfUnitsRepository r, IUnitsRepository u,
            ISystemsOfUnitsRepository s) : base(r, u, s) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}

