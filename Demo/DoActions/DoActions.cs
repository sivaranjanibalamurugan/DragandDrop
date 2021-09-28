using OpenQA.Selenium;
/*Project = Drag and Drop &  Scroll down
 * Created on = 27-09-2021
 * created by = SIVA RANJANI B
 */
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DoActions
{
    public class DoActions:BaseClass.BaseClass
    {
        public static void DragandDrop()
        {
            //Element which needs to drag    		
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='credit2']/a"));

            //Element on which need to drop		
            IWebElement element2 = driver.FindElement(By.XPath("//*[@id='bank']/li"));

            Actions action = new Actions(driver);
            //To drag element 1 and drop on element 2
            action.DragAndDrop(element1, element2).Build().Perform();
            System.Threading.Thread.Sleep(2000);
            //Element where to be dropped
            IWebElement dropElement = driver.FindElement(By.XPath("//*[@id='bank']/li"));
            string textTo = dropElement.Text;

            Console.WriteLine(textTo);
            if (textTo.Equals(" BANK"))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            System.Threading.Thread.Sleep(200);
            //moving the element 1
            action.MoveToElement(element1);
            System.Threading.Thread.Sleep(200);
        }
    }
}
