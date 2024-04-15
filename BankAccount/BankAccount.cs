using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        
        int value = 0;
        public void Deposit(int amount)
        {
            value = value + amount; 
           
        }
      
        public void Withdraw(int amount)
        {
            
            if (amount < value)
            {
                value = value - amount;
            }
            else
            {
                amount = 0; 
            }
        }

        public int GetBalance()
        {
            
            return value;
        }
    }


}
