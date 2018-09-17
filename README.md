# BeekmanLabs.UnitTesting
Simple test subject construction for NUnit.

<a href="https://ci.appveyor.com/project/ethanhann/beekmanlabs/branch/master">
    <img src="https://ci.appveyor.com/api/projects/status/github/BeekmanLabs/UnitTesting?branch=master&svg=true">
</a>

*Usage*

```
using BeekmanLabs.UnitTesting;
using NUnit.Framework;

namespace MyProject.Tests
{
    [TestFixture]
    public class TestClass : TestBase<SubjectOfTest>
    {
        [Test]
        public void TestMethod()
        {
            // Subject must have a public parameterless constructor.
            // Inside of a test (like this one) Subject can be used in assertions.
            Assert.IsInstanceOf<SubjectOfTest>(Subject);
        }
    }
}

```
