using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAvivatecCsharp.Pages
{
    class MinhaContaPage : Core.BasePage
    {
        private IWebElement txtHistoricoDeCompra()
        {
            return driver.FindElement(By.XPath("//a[@title='Orders']"));
        }

        public void ValidarContaLogada()
        {
            Assert.IsTrue(txtHistoricoDeCompra().Displayed);
        }

    }
}
