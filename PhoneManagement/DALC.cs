using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement
{
    internal class DALC
    {
        public static string GetStringConnection()
        {
            string connectionString = "Data Source=WIN-0AVBIPRU9F2;Initial Catalog=Phone;Integrated Security=True";
            return connectionString;
        }
    }
}
