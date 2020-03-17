using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Quantity
{
    [TestClass]
    public class UnitDataTests : SealedClassTest<UnitData, DefinedEntityData>
    {
        [TestMethod]
        public void MeasureIdTest()
        {
            isNullableProperty(() => obj.MeasureId, x => obj.MeasureId = x);
        }
    }
}