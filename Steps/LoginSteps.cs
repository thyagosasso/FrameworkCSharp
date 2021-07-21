using System;
using TechTalk.SpecFlow;
using TesteAvivatecCsharp.Pages;

namespace TesteAvivatecCsharp.Steps
{
    [Binding]
    public class LoginSteps
    {

        HomePage home;
        LoginPage login;
        MinhaContaPage minhaConta;

        String url = "http://automationpractice.com/index.php";

        [Given(@"Que eu queira logar em minha conta no website")]
        public void DadoQueEuQueiraLogarEmMinhaContaNoWebsite()
        {
            home = new HomePage();

            home.AcessarHomePage(url);
        }
        
        [Given(@"esteja na pagina de login")]
        public void DadoEstejaNaPaginaDeLogin()
        {
            home.AcessarPaginaLogin();
        }
        
        [When(@"eu insirir o login e a senha corretamente")]
        public void QuandoEuInsirirOLoginEASenhaCorretamente()
        {
            login = new LoginPage();

            login.PreencherLogin();
        }
        
        [Then(@"o login será realizado com sucesso")]
        public void EntaoOLoginSeraRealizadoComSucesso()
        {
            minhaConta = new MinhaContaPage();

            minhaConta.ValidarContaLogada();
        }
    }
}
