using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TesteAvivatecCsharp.Pages;

namespace TesteAvivatecCsharp.Steps
{
    [Binding]
    public class CadastroSteps
    {

        HomePage home;
        LoginPage login;
        CadastroPage cadastro;
        MinhaContaPage minhaConta;

        String url = "http://automationpractice.com/index.php";

        [Given(@"Que eu esteja no website que desejo fazer o cadastro")]
        public void DadoQueEuEstejaNoWebsiteQueDesejoFazerOCadastro()
        {
            home = new HomePage();
            login = new LoginPage();

            home.AcessarHomePage(url);
            home.AcessarPaginaLogin();
            login.PreencherEmailCadastro();
        }
        
        [When(@"eu preencher o cadastro corretamente e finalizar")]
        public void QuandoEuPreencherOCadastroCorretamenteEFinalizar()
        {
            cadastro = new CadastroPage();

            cadastro.PreencherDadosCadastrais();
        }
        
        [Then(@"terei completado meu cadastro com sucesso")]
        public void EntaoTereiCompletadoMeuCadastroComSucesso()
        {
            minhaConta = new MinhaContaPage();

            minhaConta.ValidarContaLogada();
        }
    }
}
