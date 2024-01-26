using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Tests
{
    internal class selenium

    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ma-calculatrice.fr/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
          
        }
        [TearDown]
        public void Clean()
        {
            driver.Close();
          
        }
        [OneTimeTearDown]
        public void Quit()
        {
            driver.Quit();

        }
        [Test]
        public void SeleniumAdditionTest()
        {

          
            var number1 = driver.FindElement(By.Id("un"));
            var number2 = driver.FindElement(By.Id("trois"));
            var plus = driver.FindElement(By.Id("addition"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));


          
            number1.Click();
            Task.Delay(100);
            plus.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            string actualResult = res.Text;


          
            Assert.That(actualResult, Is.EqualTo("4"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
        [Test]
        public void SeleniumMoinsTest()
        {


            var number1 = driver.FindElement(By.Id("trois"));
            var number2 = driver.FindElement(By.Id("un"));
            var moins = driver.FindElement(By.Id("moins"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));

            number1.Click();
            Task.Delay(100);
            moins.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            string actualResult = res.Text;


            Assert.That(actualResult, Is.EqualTo("2"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }

        [Test]
        public void SeleniumMultiplicationTest()
        {

            var number1 = driver.FindElement(By.Id("deux"));
            var number2 = driver.FindElement(By.Id("un"));
            var multipl = driver.FindElement(By.Id("multiplier"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));



           
            number1.Click();
            Task.Delay(100);
            multipl.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

            
            string actualResult = res.Text;



            Assert.That(actualResult, Is.EqualTo("2"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }

        [Test]
        public void SeleniumDivisionTest()
        {

  
            var number1 = driver.FindElement(By.Id("deux"));
            var number2 = driver.FindElement(By.Id("deux"));
            var div = driver.FindElement(By.Id("diviser"));
            var equal = driver.FindElement(By.Id("egale"));
            var res = driver.FindElement(By.Id("total"));


            number1.Click();
            Task.Delay(100);
            div.Click();
            Task.Delay(100);
            number2.Click();
            Task.Delay(100);
            equal.Click();
            Task.Delay(100);

  
            string actualResult = res.Text;



            Assert.That(actualResult, Is.EqualTo("1"));
            Console.WriteLine(actualResult);
            Assert.Pass();


        }
       

       
       

    }
}
