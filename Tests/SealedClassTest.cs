using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
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