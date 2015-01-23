using NUnit.Framework;

namespace BeekmanLabs.UnitTesting
{
    public abstract class TestBase<TSubject> : TestBase where TSubject : new()
    {
        public TSubject Subject { get; set; }

        [SetUp]
        public void ConstructSubject()
        {
            Subject = new TSubject();
        }
    }
}
