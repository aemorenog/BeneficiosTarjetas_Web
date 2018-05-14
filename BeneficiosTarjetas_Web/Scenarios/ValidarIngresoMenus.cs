using NUnit.Framework;
using OpenQA.Selenium;

namespace BeneficiosTarjetas_Web.Scenarios
{
    public class ValidarIngresoMenus
    {
        public IWebDriver Driver { get; set; }

        public ValidarIngresoMenus()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();

        }

        [TestCase]
        public void ValidarMenus()
        {
            NavigateTo.IngresoLogin(Driver);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
