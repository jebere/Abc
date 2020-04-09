using System.Collections.Generic;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Quantity
{
    public class SystemsOfUnitsPage : CommonPage<ISystemsOfUnitsRepository, SystemOfUnits, SystemOfUnitsView, SystemOfUnitsData>
    {
        protected internal SystemsOfUnitsPage(ISystemsOfUnitsRepository r, IUnitsRepository u,
            ISystemsOfUnitsRepository s) : base(r)
        {
            PageTitle = "Systems Of Units";
            Units = createSelectList<Unit, UnitData>(u);
            SystemsOfUnits = createSelectList<SystemOfUnits, SystemOfUnitsData>(s);
        }
        public IEnumerable<SelectListItem> Units { get; }
        public IEnumerable<SelectListItem> SystemsOfUnits { get; }
        public override string ItemId => Item.Id;
        protected internal override string getPageUrl() => "/Quantity/SystemsOfUnits";
        protected internal override SystemOfUnits toObject(SystemOfUnitsView view) => SystemOfUnitsViewFactory.Create(view);
        protected internal override SystemOfUnitsView toView(SystemOfUnits obj) => SystemOfUnitsViewFactory.Create(obj);
    }
}
