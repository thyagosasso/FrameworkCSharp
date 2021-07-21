using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAvivatecCsharp.Core;

namespace TesteAvivatecCsharp.Pages
{
    class LoginPage : Core.BasePage
    {

        private IWebElement txtEmailCadastro()
        {
            return driver.FindElement(By.XPath("//input[@id='email_create']"));
        }
        private IWebElement btnCriarConta()
        {
            return driver.FindElement(By.XPath("//button[@id='SubmitCreate']"));
        }
        private IWebElement txtEmailLogin()
        {
            return driver.FindElement(By.XPath("//input[@id='email']"));
        }
        private IWebElement txtSenhaLogin()
        {
            return driver.FindElement(By.XPath("//input[@id='passwd']"));
        }
        private IWebElement btnLogin()
        {
            return driver.FindElement(By.XPath("//button[@id='SubmitLogin']"));
        }
        public void PreencherEmailCadastro()
        {
            txtEmailCadastro().SendKeys("meuemail123@hotmail.com");
            EvidencePrint("E-mail após preenchido");
            btnCriarConta().Click();
        }

        public void PreencherLogin()
        {
            txtEmailLogin().SendKeys("meuemail123@hotmail.com");
            txtSenhaLogin().SendKeys("sdwssw");
            EvidencePrint("E-mail e senha após preenchimento");
            btnLogin().Click();
        }



    }
}
