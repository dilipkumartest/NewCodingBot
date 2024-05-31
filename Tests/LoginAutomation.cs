using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace
TestAutomationFramework.Tests
{
    public class LoginAutomation
    {
        private IWebDriver? _driver;
        [Test]
        public void Test1()
        {

         //   Set the path to the ChromeDriver executable
                string chromeDriverPath = @"C:\Users\dilip.kumar\Desktop\VSWorkspace\CSharpProj\To\chromedriver.exe";
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                _driver = new ChromeDriver(chromeDriverPath,options);
                _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
                Console.WriteLine("-URL launch Successfully-");
                Thread.Sleep(5000);
                _driver.FindElement(By.XPath("//*[@name='username']")).SendKeys("Admin");
                _driver.FindElement(By.XPath("//*[@name='password']")).SendKeys("admin123");
                _driver.FindElement(By.XPath("//*[text()=' Login ']")).Click();
                Console.WriteLine("-Login Successfully-");
                _driver.Quit();
        }
    }
    
}