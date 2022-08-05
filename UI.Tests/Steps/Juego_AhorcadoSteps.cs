using System;
using TechTalk.SpecFlow;
using Ahorcado.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UI.Tests.Steps
{
    [Binding]
    public class Juego_AhorcadoSteps
    {
        IWebDriver driver;
        String? URL;
        PartidaAhorcado? Partida;

        [BeforeScenario]
        public void TestInitialize()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"Drivers";
            driver = new ChromeDriver(path);
            URL = "https://localhost:44314/";

        }


        [Given(@"The word to guess 'AGILES'")]
        public void GivenTheWordToGuess()
        {         
            Partida = new PartidaAhorcado("AGILES");
            driver.Navigate().GoToUrl(URL);
        }
        
        [When(@"Player entered A as the LetraIntresada")]
        public void WhenPlayerEnteredAAsTheLetraIntresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("A");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered G as the LetraIntresada")]
        public void WhenPlayerEnteredGAsTheLetraIntresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("G");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered I as the LetraIntresada")]
        public void WhenPlayerEnteredIAsTheLetraIntresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("I");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered L as the LetraIntresada")]
        public void WhenPlayerEnteredLAsTheLetraIntresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("L");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered E as the LetraIntresada")]
        public void WhenPlayerEnteredEAsTheLetraIntresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("E");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered S as the LetraIntresada")]
        public void WhenPlayerEnteredSAsTheLetraIntresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("S");
            BotonIntentar.Click();
        }
        
        [Then(@"Player should be told that he won the game")]
        public void ThenPlayerShouldBeToldThatHeLostTheGame()
        {
            var LabelGanar = driver.FindElement(By.Id("win"));

            Assert.AreEqual(LabelGanar.Text, "¡Ganaste!");
        }

        [AfterScenario]
        public void TestCleanUp()
        {
            driver.Quit();
        }
    }
}
