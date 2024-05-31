using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml;
using System.IO;


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
            _driver = new ChromeDriver(chromeDriverPath, options);
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            Console.WriteLine("-URL launch Successfully-");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    
            //   Read data from XML file
            XmlDocument xmlDoc = new XmlDocument();
            string XMLpath = Directory.GetCurrentDirectory() + @"\data.xml";
            Console.WriteLine(XMLpath);
            xmlDoc.Load(XMLpath);

            XmlNodeList CListUname = xmlDoc.GetElementsByTagName("name");
            XmlNodeList CListPass = xmlDoc.GetElementsByTagName("pass");
            string username = "";
            string password = "";
            for (int i = 0; i < CListUname.Count; i++)
            {
                username = CListUname[i].InnerText.ToString();
                _driver.FindElement(By.XPath("//*[@name='username']")).SendKeys(username);
            }

            for (int i = 0; i < CListPass.Count; i++)
            {
                password = CListPass[i].InnerText.ToString();
                _driver.FindElement(By.XPath("//*[@name='password']")).SendKeys(password);
            }

            Console.WriteLine(Environment.NewLine);
            _driver.FindElement(By.XPath("//*[text()=' Login ']")).Click();
            Console.WriteLine("-Login Successfully-");
            _driver.Quit();
        }
    }

}