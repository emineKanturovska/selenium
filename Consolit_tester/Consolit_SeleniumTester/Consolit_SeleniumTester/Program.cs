using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace Consolit_SeleniumTester
{
    class Program
    {   //Create the reference for our browser
        IWebDriver driver;

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("https://consolit.se");
            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTests()
        {
            
            Thread.Sleep(2000);
            //find the element
            IWebElement element = driver.FindElement(By.CssSelector("#field1"));

            //perform operations
            element.SendKeys("test");

            // element.Clear();

            Thread.Sleep(5000);
            Console.WriteLine("Executed test");
        }

        [Test]
        public void NextTest()
        {
           
            //testing if the title is the same
            Assert.AreEqual("HEM | consolit", driver.Title);

            Thread.Sleep(5000);
        }

        [Test]
        public void ThirdTest()
        {
            
            //testing if it can find or locate to the link and wait for it to be clicked, 
            //then it tests if its the same link?
            Thread.Sleep(2000);
            var href = driver.FindElement(By.PartialLinkText("info@")).GetAttribute("href");
            Assert.True(href.Contains("info@"));
            Thread.Sleep(5000);
        }

        [Test]
        public void FourthTest()
        {
            
            //testing if it can find or locate to the link and wait for it to be clicked, 
            //then it tests if its the same link?
            //find the element
            Thread.Sleep(2000);
            IWebElement field1 = driver.FindElement(By.CssSelector("#field1"));
            IWebElement field2 = driver.FindElement(By.CssSelector("#field2"));
            IWebElement field3 = driver.FindElement(By.CssSelector("#field3"));
            IWebElement meddelande = driver.FindElement(By.Name("Meddelande"));
            //perform operations
            field1.SendKeys("Emine");
            field2.SendKeys("emine@consolit.se");
            field3.SendKeys("Test");
            meddelande.SendKeys("nytt test");
            Thread.Sleep(2000);
            //var href = driver.FindElement(By.PartialLinkText("info@")).GetAttribute("href");
            //Assert.True(href.Contains("info@"));
            //assertTrue driver.findElement(By.tagName("body").getText().contains("Submitted");
            driver.FindElement(By.Id("comp-jakvhffusubmit")).Click();
            //WebDriverWait wait


            var input = driver.FindElement(By.Id("comp-jakvhffusubmit")).Text;

            Assert.True(input.Contains("Skicka"), input + " doesn't contains 'Skicka'");
            Thread.Sleep(5000);

            var notification = driver.FindElement(By.Id("comp-jakvhffunotifications")).Text;

            Console.WriteLine(notification);


            // Assert.IsTrue(driver.FindElement(By.Id("comp-jakvhffusubmit")).Text.Contains("Skicka"));
        }

        [Test]
        public void FifthTest()
        {
            
            Thread.Sleep(2000);
            //navigate to consolit.se
            // driver.Navigate().GoToUrl("https://consolit.se");
            //clicking to ATT VARA EN consolit

            driver.FindElement(By.Id("comp-jakvhh0j1label")).Click();

            // var href = driver.FindElement(By.PartialLinkText("ATT VARA EN ")).GetAttribute("href");
            // Assert.True(href.Contains("ATT VARA EN"));
            Thread.Sleep(5000);

            //loggan knappen
            driver.FindElement(By.Id("comp-jakvhffyimgimage")).Click();
            Thread.Sleep(500);

        }

        [Test]
        public void AnsokViaMeny()
        {
           
            Thread.Sleep(2000);
            //navigate to consolit.se
            //driver.Navigate().GoToUrl("https://consolit.se");
            //clicking to ATT VARA EN consolit
            TimeSpan t = new TimeSpan(30);
            WebDriverWait wait = new WebDriverWait(driver, t);
            //driver.FindElement(By.Id("comp-jakvhh0j1bg")).Click();
            driver.FindElement(By.PartialLinkText("ATT VARA EN ")).Click();
            var text1 = driver.FindElement(By.PartialLinkText("ATT VARA EN ")).Text;

            driver.FindElement(By.PartialLinkText("BLI EN ")).Click();
            var text = driver.FindElement(By.PartialLinkText("BLI EN ")).Text;


            Thread.Sleep(5000);
            //Assert.IsTrue(text1.Contains("ATT VARA EN "));
            Assert.True(text1.Contains("ATT VARA EN "), text1 + " doesn't contains 'ATT VARA EN '");
            Assert.True(text.Contains("BLI EN "), text + " doesn't contains 'BLI EN '");
            //ansök knapp
            driver.FindElement(By.Id("comp-jakwkqwqlink")).Click();


            Thread.Sleep(5000);


        }

        [Test]
        public void AnsokTest()
        {
            

            //navigate to consolit.se
            //clicking to ATT VARA EN consolit

            Thread.Sleep(2000);
            driver.FindElement(By.Id("comp-jakvhh0j1label")).Click();

            // varaEnConsolit.Click();


            // var href = driver.FindElement(By.PartialLinkText("ATT VARA EN ")).GetAttribute("href");
            // Assert.True(href.Contains("ATT VARA EN"));
            Thread.Sleep(5000);

            //lokalisera till knappen Bli en consolit
            driver.FindElement(By.Id("comp-jakwkt4clink")).Click();
            Thread.Sleep(5000);

            //driver.FindElement(By.Id("comp-jakwkt4clink")).Click();
            //ansök knapp
            driver.FindElement(By.Id("comp-jakwkqwqlink")).Click();

            Thread.Sleep(5000);
        }

        [Test] //är ej klar
        public void LastTest()
        {
            
            //navigate to consolit.se
            //clicking to ATT VARA EN consolit

            Thread.Sleep(2000);
            driver.FindElement(By.Id("comp-jakvhh0j1label")).Click();

            // varaEnConsolit.Click();


            // var href = driver.FindElement(By.PartialLinkText("ATT VARA EN ")).GetAttribute("href");
            // Assert.True(href.Contains("ATT VARA EN"));
            Thread.Sleep(5000);

            //lokalisera till knappen Bli en consolit
            driver.FindElement(By.Id("comp-jakwkt4clink")).Click();
            
            Thread.Sleep(5000);

            //driver.FindElement(By.Id("comp-jakwkt4clink")).Click();
            //ansök knapp
            
            IWebElement systemutvecklare = driver.FindElement(By.Id("comp-jakwkqwqlink"));
            systemutvecklare.Click();
            

           /* IWebElement embedded = driver.FindElement(By.Id("comp-jbetnbm4link"));
            embedded.Click();
            
            IWebElement cgartist = driver.FindElement(By.Id("comp-jbetob6mlink"));
            cgartist.Click();

          
            IWebElement spontan = driver.FindElement(By.Id("comp-jakwkqxqlink"));
            spontan.Click();*/
            Thread.Sleep(5000);
        }


        [TearDown]
        public void CleanUp()
        {
            
            //close the driver
            driver.Close();
            Console.WriteLine("Closed the browser");
        }

    }
}
