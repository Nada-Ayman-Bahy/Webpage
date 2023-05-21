using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication6
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public String CalculateGPA(Double x)
        {
            if (x < 0.7 || x > 5.0)
                return "“Not Applicable";
            else if (x >= 0.7 && x <= 0.99)
                return "A+";
            else if (x >= 1 && x <= 1.29)
                return "A";
            else if (x >= 1.3 && x <= 1.69)
                return "A-";
            else if (x >= 1.7 && x <= 1.99)
                return "B+";
            else if (x >= 2.0 && x <= 2.29)
                return "B";
            else if (x >= 2.3 && x <= 2.69)
                return "B-";
            else if (x >= 2.7 && x <= 2.99)
                return "C+";
            else if (x >= 3.0 && x <= 3.29)
                return "C";
            else if (x >= 3.3 && x <= 3.69)
                return "C-";
            else if (x >= 3.7 && x <= 3.99)
                return "D+";
            else if (x >= 4.0 && x <= 4.99)
                return "D";
            else
                return "F";

        }
    }
}
