using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobRepository
{
    class Account
    {
        #region Properties
        //Id of the Account
        public int Id { get; private set; }
        //Type of Account
        public char Type { get; set; }
        //Account LoginName
        public string LoginName { get; set; }
        //Account Password
        public string Password { get; set; }
        #endregion

        #region Method
        //Existing User SignIn
        public void SignIn(User u)
        {

        }
        //New User SignUp
        public void SignUp(User u)
        {

        }


        #endregion
    }
}
