using System;
using Abc.Data.Common;
using Abc.Tests;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Common
{
    [TestClass]
    public class DefinedEntityDataTests : AbstractClassTest<DefinedEntityData, NamedEntityData>
    {
        private class testClass : DefinedEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void DefinitionTest()
        {
            isNullableProperty(() => obj.Definition, x => obj.Definition = x);
        }

       
    }
}