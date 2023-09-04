// Create a new instance of the Chrome driver.
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

IWebDriver driver = new FirefoxDriver();

driver.Navigate().GoToUrl("https://www.google.com/");

// Add a wait for the cookie consent to appear (consider using WebDriverWait)
    Thread.Sleep(1000); // This is not the most efficient way; WebDriverWait is preferred.

try
{
    // Find the "accept all" button and click it.
    IWebElement acceptButton = driver.FindElement(By.Id("L2AGLb"));
    acceptButton.Click();
}
catch (NoSuchElementException)
{
    Console.WriteLine("Accept All button not found.");
}

try
{
    IWebElement searchBar = driver.FindElement(By.Id("APjFqb"));
    searchBar.Click();
    searchBar.SendKeys("gmail");

    Thread.Sleep(200);
    searchBar.Submit();
    Thread.Sleep(2000);

}
catch (NoSuchElementException)
{

    Console.WriteLine("Search bar not found!");
}

try
{
    driver.Navigate().GoToUrl("https://www.google.com/intl/bg/gmail/about/");
    driver.Navigate().GoToUrl("https://accounts.google.com/AccountChooser/signinchooser?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&flowName=GlifWebSignIn&flowEntry=AccountChooser");
    IWebElement searchBar = driver.FindElement(By.Id("identifierId")); 
    searchBar.Click();
    searchBar.SendKeys("xyz");
    IWebElement button = driver.FindElement(By.Id("identifierNext"));
    button.Click();
}
catch (NoSuchElementException)
{
    Console.WriteLine("Error");
}

// ... Continue with the rest of your Selenium tasks ...
