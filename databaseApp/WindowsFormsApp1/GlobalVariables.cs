using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GlobalVariables
    {
        private static int userAccess = 2;

        public static int UserAccess
        {
            get { return userAccess; }
            set { userAccess = value; }
        }
    }
}
