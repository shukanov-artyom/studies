using System;
using NUnit.Framework;
using spfl;
using TechTalk.SpecFlow;

namespace scenarios
{
    [Binding]
    public class Steps
    {
        [Given(@"I create a test class instance")]
        public void GivenICreateATestClassInstance()
        {
            ScenarioContext.Current["class Instance"] = new ClassUnderTest();
        }

        [Given(@"call its doubling method with argument (.*)")]
        public void GivenCallItsDoublingMethodWithArgument(int p0)
        {
            ClassUnderTest test = ScenarioContext.Current["class Instance"] as ClassUnderTest;
            ScenarioContext.Current["result"] = test.Double(p0);
        }

        [Then(@"i get (.*)")]
        public void ThenIGet(int p0)
        {
            Assert.AreEqual(ScenarioContext.Current["result"], p0);
        }
    }
}
