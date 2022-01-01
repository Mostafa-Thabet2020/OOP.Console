using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public class Defaults
    {
        #region Time values
        public const int DaysOfYear = 365;
        public const int MonthsOfYear = 12;
        public const int DaysOfWeek = 7;
        #endregion

        #region Application Information
        public const string ApplicationName = "ISaller";
        public const string ApplicationVersion = "1.0";
        public const string ApplicationDescription = $"This application " +
            $"for help supplier" +
            $" to sale them product";
        public const string ApplicationType = "E-Commorce";
        public const string OwnerOfApplication = "RTD Company";
        #endregion
    }
}
