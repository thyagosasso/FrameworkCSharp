using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAvivatecCsharp.Core;

namespace TesteAvivatecCsharp.Pages
{
    class HomePage : Core.BasePage
    {

        private IWebElement btnAcessarConta()
        {
            return driver.FindElement(By.XPath("//a[@title='Log in to your customer account']"));
        }

        public void AcessarHomePage(String url)
        {
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            
            //Validando acesso
            EvidencePrint("HomePage");
            Equals("My Store", driver.Title);

        }

  
        public void AcessarPaginaLogin()
        {
            btnAcessarConta().Click();
            EvidencePrint("Login Page");
        }

       

    }
}
