using System;
using TechTalk.SpecFlow;
using Ahorcado.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UI.Tests.Steps
{
    [Binding]
    public class Juego_AhorcadoSteps
    {
        IWebDriver driver = new ChromeDriver();
        String? URL;
        PartidaAhorcado? Partida;

        [BeforeScenario]
        public void TestInitialize()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"Drivers";
            driver = new ChromeDriver(path);
            URL = "https://tpagiles2022test.azurewebsites.net/";

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
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("A");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered G as the LetraIngresada")]
        public void WhenPlayerEnteredGAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("G");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered I as the LetraIngresada")]
        public void WhenPlayerEnteredIAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("I");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered L as the LetraIngresada")]
        public void WhenPlayerEnteredLAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("L");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered E as the LetraIngresada")]
        public void WhenPlayerEnteredEAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("E");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered S as the LetraIngresada")]
        public void WhenPlayerEnteredSAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("S");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered X as the LetraIngresada")]
        public void WhenPlayerEnteredXAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("X");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered Y as the LetraIngresada")]
        public void WhenPlayerEnteredYAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("Y");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered J as the LetraIngresada")]
        public void WhenPlayerEnteredJAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("J");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered Q as the LetraIngresada")]
        public void WhenPlayerEnteredQAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("Q");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered W as the LetraIngresada")]
        public void WhenPlayerEnteredWAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("W");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered Z as the LetraIngresada")]
        public void WhenPlayerEnteredZAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("Z");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered P as the LetraIngresada")]
        public void WhenPlayerEnteredPAsTheLetraIngresada()
        {
            var CampoLetra = driver.FindElement(By.Id("inputletter"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarLetra"));

            CampoLetra.SendKeys("P");
            BotonIntentar.Click();
        }
        
        [When(@"Player entered 'AGILES' as the PalabraIngresada")]
        public void WhenPlayerEnteredAgilesAsThePalabraIngresada()
        {
            var CampoPalabra = driver.FindElement(By.Id("inputword"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarPalabra"));

            CampoPalabra.SendKeys("AGILES");
            BotonIntentar.Click();
        }

        [When(@"Player entered 'ANCLAS' as the PalabraIngresada")]
        public void WhenPlayerEnteredAsThePalabraIngresada()
        {
            var CampoPalabra = driver.FindElement(By.Id("inputword"));
            var BotonIntentar = driver.FindElement(By.Id("IntentarPalabra"));

            CampoPalabra.SendKeys("ANCLAS");
            BotonIntentar.Click();
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

        [AfterScenario]
        public void TestCleanUp()
        {
            driver.Quit();
        }
    }
}
