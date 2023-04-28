using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConceptProblems
{
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
                AccountNumber = value;
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
