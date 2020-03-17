using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests;

namespace Abc.Tests
{
    public abstract class SealedClassTest<TClass, TBaseClass>: ClassTest<TClass, TBaseClass> where TClass: new()

    {
        [TestMethod]
        public void IsSealed()
        {
            Assert.IsTrue(type.IsSealed);
        }
    }
}