---
layout: default
---

## Install the _BeekmanLabs.UnitTesting_ Package 

### Visual Studio
Run the following command in the Package Manager Console.
```sh
PM> Install-Package BeekmanLabs.UnitTesting
```

### Xamarin Studio
Navigate to _Project_&#8594;_Add Packages_, then search for "BeekmanLabs.UnitTesting" in the _Add Packages_ GUI.

## Usage

### MyClass

Add a class with a parameterless constructor.

``` csharp
namespace MyProject
{
    public class MyClass
    {
        // Parameterless constructor.
        public MyClass() {}
        
        public string MyMethod {
            return "foo";
        }
    }
}
```

### MyClassTest

Inherit from the _BeekmanLabs.UnitTesting.TestBaseT_ class in your NUnit test class, then use the _Subject_ property to access an instance of the class you are testing.

``` csharp
using BeekmanLabs.UnitTesting;
using NUnit.Framework;

namespace MyProject.Tests
{
    public class MyClassTest : TestBase<MyClass>
    {
        [Test]
        public void MyTest()
        {
            var expected = "foo";
        
            // An instance of MyClass is available in a property called "Subject"
            var result = Subject.MyMethod();
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
```
