using MyAxaBDD.BugZillaPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.GenericHelper
{
    public class BugZillaPageBase :BaseClass
    {
        public static BugZillaMainPage NavigateToBuZillaMainPage()
        {
            LaunchUrl("http://localhost:5001/index.cgi");
            return new BugZillaMainPage();
        }
    }
}
