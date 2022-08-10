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

        [Given(@"The word to guess '(.*)'")]
        public void GivenTheWordToGuess(string p0)
        {
            Partida = new PartidaAhorcado("AGILES");
            driver.Navigate().GoToUrl(URL);
        }
        
        [When(@"Player entered A as the LetraIngresada")]
        public void WhenPlayerEnteredAAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("A");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered G as the LetraIngresada")]
        public void WhenPlayerEnteredGAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("G");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered I as the LetraIngresada")]
        public void WhenPlayerEnteredIAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("I");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered L as the LetraIngresada")]
        public void WhenPlayerEnteredLAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("L");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered E as the LetraIngresada")]
        public void WhenPlayerEnteredEAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("E");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered S as the LetraIngresada")]
        public void WhenPlayerEnteredSAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("S");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered X as the LetraIngresada")]
        public void WhenPlayerEnteredXAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("X");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered Y as the LetraIngresada")]
        public void WhenPlayerEnteredYAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("Y");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered J as the LetraIngresada")]
        public void WhenPlayerEnteredJAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("J");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered Q as the LetraIngresada")]
        public void WhenPlayerEnteredQAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("Q");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered W as the LetraIngresada")]
        public void WhenPlayerEnteredWAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("W");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered Z as the LetraIngresada")]
        public void WhenPlayerEnteredZAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("Z");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered P as the LetraIngresada")]
        public void WhenPlayerEnteredPAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("Intentar"));

            CampoLetra.SendKeys("P");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered 'AGILES' as the PalabraIngresada")]
        public void WhenPlayerEnteredAgilesAsThePalabraIngresada()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Player entered 'ANCLAS' as the PalabraIngresada")]
        public void WhenPlayerEnteredAsThePalabraIngresada()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"Player should be told that he won the game")]
        public void ThenPlayerShouldBeToldThatHeWonTheGame()
        {
            var LabelGanar = driver.FindElement(By.Id("win"));

            Assert.AreEqual(LabelGanar.Text, "¡Ganaste!");
        }
        
        [Then(@"Player should be told that he lost the game")]
        public void ThenPlayerShouldBeToldThatHeLostTheGame()
        {
            var LabelGanar = driver.FindElement(By.Id("lost"));

            Assert.AreEqual(LabelGanar.Text, "Perdiste :(");
        }
    }
}
