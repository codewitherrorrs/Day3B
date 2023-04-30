using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B
{
    interface InterfaceExample
    {
       void BankAccountDetails();
    }
    interface InterfaceExampleOne
    {
        void AccountBalanceDetails();
    }
    public class Bank : InterfaceExample,InterfaceExampleOne
    {
       public void BankAccountDetails()
        {
            int accountNumber = 123;
            string customerName = "Sagar Shahu";
            int pincode = 440023;
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Pincode : {pincode}");
        }
        public void AccountBalanceDetails()
        {
            int accountBalance = 25000;
            Console.WriteLine($"Your Current Balance is : {accountBalance}");
            Console.WriteLine("Do you Want to add Some Money Press 1 for accept or Press 0 for Getting Account Information: ");
            int choice = int.Parse(Console.ReadLine());
            if(choice== 1)
            {
                Console.WriteLine("How many Money you want to deposite.......");
                int money = int.Parse(Console.ReadLine());
                Console.WriteLine($"The Updated Balance is : { accountBalance + money }");
            }
            else if(choice == 0)
            {
                Console.WriteLine("You are Getting Account Balance...... ");
                Console.WriteLine($"Your Current Balance is : {accountBalance}");
            }
            else
            {
                Console.WriteLine("Invalid Key Pressed......");
            }
        }

    }
}
