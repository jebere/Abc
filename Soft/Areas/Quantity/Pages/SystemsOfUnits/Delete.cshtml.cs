using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Soft.Areas.Quantity.Pages.SystemsOfUnits
{
    public class DeleteModel : SystemsOfUnitsPage
    {
        public DeleteModel(ISystemsOfUnitsRepository r, IUnitsRepository u,
            ISystemsOfUnitsRepository s) : base(r, u, s) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await DeleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}