using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CustomerAcc
{
    internal class CustomerA1 : CustomerA
    {
        async Task<bool> CustomerA.Insert(User user)
        {
            using (IDbConnection db=new SqlConnection(SignUp.ConnectionString));
            {
                var result = await db.ExecuteAsync("", new { Username = user.UserName, Password = user.Password });
                return result > 0;
            }
        }
    }
}