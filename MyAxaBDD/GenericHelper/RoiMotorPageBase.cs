using MyAxaBDD.RoiMotorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAxaBDD.GenericHelper
{
    public class RoiMotorPageBase :BaseClass
    {
        public static StepOnePage NavigateToROIMotorDS()
        {
            LaunchUrl("https://dsdev.testaxa.ie/MotorQuote/");

            return new StepOnePage();
        }

    }
}
