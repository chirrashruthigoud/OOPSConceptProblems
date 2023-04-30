using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{//it will hide sensitive data from the user
 //declare field or variable should be private
 //property-get: is read-only and property-set: it is used to set data
    public class Encapsulation
    {
        private int AccountNumber;

        // private double Balance;
        /*  public int SetAccountNum
          {
              get
              {
                  return AccountNumber;
              }
              set
              {
                  AccountNumber = value;//name = value:it will set or assign value to the name
              }
          }
             public int getAccountNum
               {
                   get; set;
               }*/

        public int getAccount()
        {
            return AccountNumber;
        }
        public void setAccount(int number)
        {
            AccountNumber = number;
        }
        
    }
}
