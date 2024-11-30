using Implementing_Specflow_TurnUpPortal.Utilities;
using OpenQA.Selenium;
using System.Diagnostics;

namespace Implementing_Specflow_TurnUpPortal.XPaths
{
    public class TM_XPaths : CommonDriver
    {

        public const string typeCode = "//*[@id=\"TypeCode_listbox\"]/li[2]";
        public const string createNewButton = "//*[@id=\"container\"]/p/a";
        public const string saveButton = "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span";
        public const string lastPage = "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span";
        public const string materialDropDown = "//*[@id=\"TypeCode_listbox\"]/li[1]";
    }
}
