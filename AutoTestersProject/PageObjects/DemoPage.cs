using AutoTestersProject.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestersProject.PageObjects
{
    public class DemoPage
    {
        public DemoPage()
        {
            PageFactory.InitElements(BasePage._driver, this);
        }

        By PasswordKey = By.Id("passwd"); 
    }
}
