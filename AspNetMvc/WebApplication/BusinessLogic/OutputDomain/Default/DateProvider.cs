using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.OutputDomain.Default
{
    internal sealed class DateProvider : IDateProvider
    {

        DateTime IDateProvider.GetDateTime() {
            return DateTime.Now;
        }
    }

    internal interface IDateProvider {

        DateTime GetDateTime();

    }

}
