using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement
{
    internal class Extract
    {
        public static string InsertUser { get; set; }

        public static string GetUser { get { return InsertUser; } set { } }
    }
}
