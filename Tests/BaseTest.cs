using System;
using Abc.Aids;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public abstract class BaseTest<TClass, TBaseClass>

    {
        protected TClass obj;
        protected Type type;

        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(TClass);
        }

        [TestMethod]
        public void InInheritedTest()
        {
            Assert.AreEqual(typeof(TBaseClass), type.BaseType);
        }
        protected static void isNullableProperty<T>(Func<T> get, Action<T> set)
        {
            isProperty(get, set);
            set(default);
            Assert.IsNull(get());
        }
        protected static void isProperty<T>(Func<T> get, Action<T> set)
        {
            var d = (T)GetRandom.Value(typeof(T));
            Assert.AreNotEqual(d, get());
            set(d);
            Assert.AreEqual(d, get());
        }

    }
}