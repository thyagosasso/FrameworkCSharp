using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TesteAvivatecCsharp.Core
{
    [Binding]
    class Hooks : Core.BasePage
{
        [AfterScenario]
        public void AfterScenario()
        {
            Driver.FinishDriver();
        }

    }
}
