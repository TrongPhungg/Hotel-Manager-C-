using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    [Serializable]
    internal class login
    {
        private String _user;
        private String _password;
        public login()
        {
            this._user = "";
            this._password = "";
        }
        public login(string user, string password)
        {
            this._user = user;
           this._password = password;
        }
        public String TaiKhoan
        {
            get { return this._user; }
            set { this._user = value; }
        }
        public String MatKhau
        {
            get { return this._password; }
            set { this._password = value; }
        }
    }
}
