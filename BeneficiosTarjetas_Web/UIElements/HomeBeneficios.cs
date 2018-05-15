using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BeneficiosTarjetas_Web.UIElements
{
    public class HomeBeneficios
    {
        public HomeBeneficios(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        ///<summary>Header Home BT</<summary>
        ///Ingresa a tu Cuenta

        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.head-top-gris > div > nav > ul > li.login-wrap > a > span")]
        public IWebElement MenuIngresaCuenta { get; set; }

        /// Información y Ayuda
        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.head-top-gris > div > nav > ul > li:nth-child(2) > a > span")]
        public IWebElement MenuInformacionAyuda { get; set; }

        ///Carro de Compra
        [FindsBy(How = How.CssSelector, Using = "#modal-carro > span")]
        public IWebElement MenuCarrodeCompra { get; set; }

        ///Seguimiento en Linea
        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > div.head-top-gris > div > nav > ul > li:nth-child(4) > a > span")]
        public IWebElement MenuSeguimientoLinea { get; set; }

        ///Imagen TodoSuma
        [FindsBy(How = How.CssSelector, Using = "body > div.rt-bg > div > div.base.wrapper > div.head-top-gris > div > nav > ul > li.ico-ts > a > img")]
        public IWebElement TodoSumaImagen { get; set; }

        ///Caja Buscar
        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement CajaBuscarHomeBeneficios { get; set; }

        ///Botón Buscar
        [FindsBy(How = How.CssSelector, Using = "# search_mini_form > div > button")]
        public IWebElement BtnBuscarHomeBT { get; set; }

        /// <summary>
        /// Menu Mundos Beneficios Tarjetas
        /// </summary>
        
        //Menu Mundo Viajes
        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > section > div > div.row.pad-m > nav > ul > li.viajes_menu > a > span")]
        public IWebElement MenuMundoViajes { get; set; }



        //Menu Mundo Tienda
        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > section > div > div.row.pad-m > nav > ul > li.viajes_menu > a > span")]
        public IWebElement MenuMundoTienda { get; set; }

        //Menu Mundo Descuentos
        [FindsBy(How = How.CssSelector, Using = "body > div > div > div.base.wrapper > section > div > div.row.pad-m > nav > ul > li.viajes_menu > a > span")]
        public IWebElement MenuMundoDescuento { get; set; }


    }
}
