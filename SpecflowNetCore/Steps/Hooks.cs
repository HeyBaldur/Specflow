using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowNetCore.Steps
{
    [Binding]
    public sealed class Hooks
    {
        /*
         * Hooks (event bindings) can be used to perform additional automation logic at 
         * specific times, such as any setup required prior to executing a scenario. 
         * In order to use hooks, you need to add the Binding attribute to your class.
         */

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
