using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balance = $0.00");
            BankAccount myAccount = new BankAccount();
            Console.WriteLine("Deposit Amount:");
            double insertedMoney = Convert.ToDouble(Console.ReadLine());

            myAccount.Deposit(insertedMoney);

            
            
            
            
            myAccount.GetBalance(); 
            

            
        }
    }
}
