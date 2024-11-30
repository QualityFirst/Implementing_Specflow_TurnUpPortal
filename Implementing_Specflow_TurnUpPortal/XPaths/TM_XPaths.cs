using Implementing_Specflow_TurnUpPortal.Utilities;
using OpenQA.Selenium;

namespace Implementing_Specflow_TurnUpPortal.XPaths
{
    public class TM_XPaths : CommonDriver
    {
       public static IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
    }
}
