using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAvivatecCsharp.Utils
{
    class Utils
    {
        private IWebDriver driver;

        public void EvidencePrint(string evidenceName)
        {
            //Print
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            
            //Pegando data atual
            DateTime dataAtual = DateTime.UtcNow;
            TimeZoneInfo horaBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");

            
            string date = TimeZoneInfo.ConvertTimeFromUtc(dataAtual, horaBrasilia).ToString("ddMMyyyy");

            var classpath = Path.GetFullPath($@"{System.AppContext.BaseDirectory}..\..\Evidences\");

            string evidencePath = $"{classpath}{date}";

            string printsPath = $"{evidencePath}\\{TestContext.CurrentContext.Test.Name}";

            if (!Directory.Exists(evidencePath))
            {
                Directory.CreateDirectory(evidencePath);
            }

            if (!Directory.Exists(printsPath))
            {
                Directory.CreateDirectory(printsPath);
            }


            ss.SaveAsFile($"{printsPath}\\{evidenceName}.png", ScreenshotImageFormat.Png);
        }


    }
}
