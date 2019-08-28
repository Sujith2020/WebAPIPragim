using DairyDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DairyAPI
{
    public class Security
    {
        public static bool Login(string username, string password)
        {
            using (SwarnaContext entities = new SwarnaContext())
            {
                return entities.Users.Any(user =>
                       user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                                          && user.Password == password);
            }
        }
    }
}