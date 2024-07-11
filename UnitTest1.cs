using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumDotNet
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Create instance of Selenium Web Driver
            IWebDriver driver = new ChromeDriver();

            //Navigate to URL
            driver.Navigate().GoToUrl("https://www.google.com/");

            //Maximize Window
            driver.Manage().Window.Maximize();

            //Find the element
            IWebElement webElement = driver.FindElement(By.Name("q"));


            //Type in the element
            webElement.SendKeys("Selenium");

            //Click on the element
            webElement.SendKeys(Keys.Return);

            webElement.Click();
        }
        [Test]

        public void PatrickWebSiteTest()
        {
            //Create instance of Selenium Web Driver
            IWebDriver driver = new ChromeDriver();

            //Navigate to URL
            driver.Navigate().GoToUrl("https://patrickwalkerjauregui.com/");

            //Click the LoginLink

            IWebElement loginLink = driver.FindElement(By.ClassName("flat-button"));

            //Click the Login link
            loginLink.Click();
            // Find the UserName text box
            IWebElement txtUserName = driver.FindElement(By.Name("user_name"));

            //Typing on the textUserName

            txtUserName.SendKeys("admin");

            // Find the UserEmail text box
            IWebElement txtUserEmail = driver.FindElement(By.Name("user_email"));

            //Typing on the textUserEmail

            txtUserEmail.SendKeys("patrick.n.walkerjauregui@gmail.com");


            // Find the UserSubject text box
            IWebElement txtUserSubject = driver.FindElement(By.Name("subject"));

            //Typing on the textUserSubject

            txtUserSubject.SendKeys("Nice Website");


            // Find the UserSubject text box
            IWebElement txtUserMessage = driver.FindElement(By.Name("message"));

            //Typing on the textUserSubject

            txtUserMessage.SendKeys("I hope you have a great day!");

            //Identify Send Button
            IWebElement sendButton = driver.FindElement(By.ClassName("flat-button"));

            sendButton.Submit();
        }   
    }
}