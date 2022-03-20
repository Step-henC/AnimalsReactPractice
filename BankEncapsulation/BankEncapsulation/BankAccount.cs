using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public double MoneyDep { get; set; }
        
        public void Deposit(double baLance)
        {
           balance += baLance;
        }
        public double GetBalance()
        {
            Console.WriteLine("Do you want the balance?");
            string answer = Console.ReadLine();
            if (answer == null)
            { return 1; }

            Console.WriteLine(balance);
            return 0;
        }
    }
}
