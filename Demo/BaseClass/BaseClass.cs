/*Project = Drag and Drop &  Scroll down
 * Created on = 27-09-2021
 * created by = SIVA RANJANI B
 */
using NLog.Fluent;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BaseClass
{
    public   class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void setup()
        {
            try
            {
                driver = new ChromeDriver();
                //Maximizing the window
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://demo.guru99.com/test/drag_drop.html");
                System.Threading.Thread.Sleep(2000);

                //creating an object for Ijavascriptexecutor
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                string title = (string)js.ExecuteScript("return document.title");
                Console.WriteLine(title);
                //to scroll the page 
                ((IJavaScriptExecutor)driver).ExecuteScript("scroll(0,16000)");
                System.Threading.Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);

            }
        }
        [TearDown]
            public void Teardown()
            {
            driver.Quit();
            }
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sivaranjani.b\source\repos\Demo\Demo\Screenshot\test1.png");
        }
    }
}
