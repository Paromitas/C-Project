using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobRepository
{
    class Company
    {
        #region Properties
        // CompanyId
        public int Id { get; private set; }
        // CompanyName
        public string Name { get; set; }
        //Company Address
        public string Address { get; set; }
        //Company Payment Method
        public string PaymentMethod { get; set; }
        //Company Credit Card 
        public int CreditCard { get; protected set;}
        //Company Profile
        public string Profile { get; set; }
        //If Company is Hiring
        public Boolean Hiring { get; set; }
        #endregion

        #region Methods
        public void PostJob(Job j)
        { }

        #endregion
    }
}
