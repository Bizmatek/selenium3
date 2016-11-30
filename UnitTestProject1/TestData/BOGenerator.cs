using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.BO;

namespace UnitTestProject1.TestData
{
    class BOGenerator
    {
        public static User createUser(string login, string passwd) {
            return new BO.User(login, passwd);
        }
    }
}
