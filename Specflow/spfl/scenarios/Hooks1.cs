using System;
using System.Globalization;
using System.Linq;
using TechTalk.SpecFlow;

namespace scenarios
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            int a;
            string b = null;
            b = ScenarioContext.Current.ScenarioInfo.Tags.First(
                t => Int32.TryParse(t, NumberStyles.Any, CultureInfo.InvariantCulture, out a));
            if (!String.IsNullOrEmpty(b))
            {
                Int32.TryParse(b, NumberStyles.Any, CultureInfo.InvariantCulture, out a);
                int c = a/2;
            }
        }
    }
}
