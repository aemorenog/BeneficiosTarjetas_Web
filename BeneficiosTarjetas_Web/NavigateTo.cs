﻿using BeneficiosTarjetas_Web.UIElements;
using System.Threading;
using OpenQA.Selenium;
using System;

namespace BeneficiosTarjetas_Web
{
    public static class NavigateTo
    {
        public static void IngresoLogin(IWebDriver driver)
        {
            HomeBeneficios HBT = new HomeBeneficios(driver);

            try
            {
                HBT.MenuIngresaCuenta.Click();
                Thread.Sleep(3000);
                driver.Navigate().GoToUrl("http://www.beneficiostarjetas.cl");
                Thread.Sleep(3000);
                HBT.MenuInformacionAyuda.Click();
                Thread.Sleep(3000);
                driver.Navigate().GoToUrl("http://www.beneficiostarjetas.cl");
                Thread.Sleep(3000);
                HBT.MenuCarrodeCompra.Click();
                Thread.Sleep(3000);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.StackTrace.ToString()+" ");
                Console.WriteLine("Hola Mundo");

            }

        }

        
    }
}
