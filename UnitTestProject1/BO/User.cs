using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.BO
{
    public class User
    {
        private string login;
        private string passwd;

        public User(string login, string passwd) {
            this.login = login;
            this.passwd = passwd;
        }

        public void setLogin(string login) {
            this.login = login;
        }

        public void setPasswd(string passwd) {
            this.passwd = passwd;
        }

        public string getLogin() {
            return login;
        }

        public string getPasswd() {
            return passwd;
        }
    }
}
