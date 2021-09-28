/*Project = Drag and Drop &  Scroll down
 * Created on = 27-09-2021
 * created by = SIVA RANJANI B
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace Demo
{
    public class Tests:BaseClass.BaseClass
    {
       
        [Test, Order(1)]
        // [Ignore("ignore a fixture")]
        public static void DragandDrop()
        {
            DoActions.DoActions.DragandDrop();
            //Calling the method
            Takescreenshot();
        }
          
    }
}