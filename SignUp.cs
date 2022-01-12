using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAcc
{
    public class SignUp
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["CustomerAcc.Properties.Settings.DB_Connection"].ConnectionString;
    }
}
