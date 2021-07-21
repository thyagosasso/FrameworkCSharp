using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAvivatecCsharp.Pages
{
    class CadastroPage : Core.BasePage
    {

        private IWebElement radioSexoMasc()
        {
            return driver.FindElement(By.XPath("//label[@for='id_gender1']"));
        }
        private IWebElement txtPrimeiroNomePessoal()
        {
            return driver.FindElement(By.XPath("//input[@id='customer_firstname']"));
        }
        private IWebElement txtUltimoNomePessoal()
        {
            return driver.FindElement(By.XPath("//input[@id='customer_lastname']"));
        }
        private IWebElement txtSenha()
        {
            return driver.FindElement(By.XPath("//input[@id='passwd']"));
        }
        private IWebElement selectDia()
        {
            return driver.FindElement(By.XPath("//select[@id='days']"));
        }
        private IWebElement selectMes()
        {
            return driver.FindElement(By.XPath("//select[@id='months']"));
        }
        private IWebElement selectAno()
        {
            return driver.FindElement(By.XPath("//select[@id='years']"));
        }
        private IWebElement txtPrimeiroNomeUsuario()
        {
            return driver.FindElement(By.XPath("//input[@id='firstname']"));
        }
        private IWebElement txtUltimoNomeUsuario()
        {
            return driver.FindElement(By.XPath("//input[@id='lastname']"));
        }
        private IWebElement txtEndereço()
        {
            return driver.FindElement(By.XPath("//input[@name='address1']"));
        }
        private IWebElement txtComplemento()
        {
            return driver.FindElement(By.XPath("//input[@name='address2']"));
        }
        private IWebElement txtCidade()
        {
            return driver.FindElement(By.XPath("//input[@name='city']"));
        }
        private IWebElement selectEstado()
        {
            return driver.FindElement(By.XPath("//select[@id='id_state']"));
        }
        private IWebElement txtCodigoPostal()
        {
            return driver.FindElement(By.XPath("//input[@name='postcode']"));
        }
        private IWebElement txtCelular()
        {
            return driver.FindElement(By.XPath("//input[@name='phone_mobile']"));
        }
        private IWebElement txtEndereçoAlternativo()
        {
            return driver.FindElement(By.XPath("//input[@name='alias']"));
        }
        private IWebElement btnConfirmarCadastro()
        {
            return driver.FindElement(By.XPath("//button[@name='submitAccount']"));
        }

        public void PreencherDadosCadastrais()
        {
            EvidencePrint("Informações pessoais antes do preenchimento");

            radioSexoMasc().Click();
            txtPrimeiroNomePessoal().SendKeys("Thyago");
            txtUltimoNomePessoal().SendKeys("Sasso Sheldon");
            txtSenha().SendKeys("sdwssw");

            var dia = new SelectElement(selectDia());
            dia.SelectByValue("3");

            var mes = new SelectElement(selectMes());
            mes.SelectByValue("9");

            var ano = new SelectElement(selectAno());
            ano.SelectByValue("1993");

            EvidencePrint("Informações pessoais após do preenchimento");

            Actions actions = new Actions(driver);
            actions.MoveToElement(txtPrimeiroNomeUsuario());
            actions.Perform();
            EvidencePrint("Informações de contato antes do preenchimento");

            txtPrimeiroNomeUsuario().Clear();
            txtPrimeiroNomeUsuario().SendKeys("Jorge");
            txtUltimoNomeUsuario().Clear();
            txtUltimoNomeUsuario().SendKeys("Augusto");
            txtEndereço().SendKeys("Rua Ibiratinga");
            txtComplemento().SendKeys("Casa 98689");
            txtCidade().SendKeys("São Paulo");

            var state = new SelectElement(selectEstado());
            state.SelectByText("Alabama");

            txtCodigoPostal().SendKeys("01534");
            txtCelular().SendKeys("0511197878787");

            EvidencePrint("Informações de contato após preenchimento");
            btnConfirmarCadastro().Click();
        }

    }
}
