using Abc.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Data.Common
{
    [TestClass]
    public class UniqueEntityViewTests : AbstractClassTests<UniqueEntityData, PeriodData>
    {
        private class testClass : UniqueEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void IdTest()
        {
            isNullableProperty(() => obj.Id, x => obj.Id = x);
        }
    }
}