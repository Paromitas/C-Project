using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobRepository
{
    class User
    {
        #region Properties
        //UserId
        public int Id { get; private set; }
        //UserName
        public string Name { get; set; }
        //User Phone optional
        public string PhoneNumber { get; set; }
        //User Address 
        public string Address { get; set; }
        //User Resume
        public string Resume { get; set; }
        public string Skill { get; set; }
        public string Coverletter { get; set; }
        #endregion

        #region Method
        public void PostResume(Job j)
        {}
        #endregion

    }
}
