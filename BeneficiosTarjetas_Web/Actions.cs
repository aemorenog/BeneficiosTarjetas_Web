namespace BeneficiosTarjetas_Web
{
    using BeneficiosTarjetas_Web.UIElements;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

    public static class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }
    }

}