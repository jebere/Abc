using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Quantity
{
    [TestClass]
    public class UnitFactorDataTests : SealedClassTest<UnitFactorData, PeriodData>
    {
        [TestMethod]
        public void FactorTest()
        {
            isProperty(() => obj.Factor, x => obj.Factor = x);
        }

        [TestMethod]
        public void SystemOfUnitsIdTest()
        {
            isNullableProperty(() => obj.SystemOfUnitsId, x => obj.SystemOfUnitsId = x);
        }
        [TestMethod]
        public void UnitIdTest()
        {
            isNullableProperty(() => obj.UnitId, x => obj.UnitId = x);
        }
    }
}