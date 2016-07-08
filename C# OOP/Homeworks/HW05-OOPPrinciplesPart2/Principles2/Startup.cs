using Principles2.BankAccounts.Customers;
using Principles2.BankAccounts.TheBank;
using Principles2.MyException;
using Principles2.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles2
{
    class Startup
    {
        static void Main(string[] args)
        {
            // Uncomment these function calls to test the problems.

           // Shapes();

           // BankAccountsTest();

           // ExceptionTest();
        }


        static void Shapes()
        {
            Shape[] shapesTest = new Shape[3];
            shapesTest[0] = new Triangle(2.5m, 3m);
            shapesTest[1] = new Rectangle(4.4m, 2.5m);
            // This throws an exceptione because Square must have the same hight as width.
            //shapesTest[2] = new Square(2m, 3m);
            shapesTest[2] = new Square(2.2m, 2.2m);


            foreach (var item in shapesTest)
            {
                Console.WriteLine(item.CalculateSurface());
            }           
        }

        static void BankAccountsTest()
        {
            Bank ourTestBank = new Bank();

            ourTestBank.AddDepositAccount(new Individual("Ivan", "Petrov"), 1300, 0.14m);
            ourTestBank.AddDepositAccount(new Individual("Ivan", "Bednyakov"), 800, 0.14m);
            ourTestBank.AddLoanAccount(new Individual("Nikolay", "Ivanov"), 300, 0.15m);
            ourTestBank.AddLoanAccount(new Company("Telerik"), 1300, 0.09m);
            ourTestBank.AddMortageAccount(new Individual("Petya", "Pavlova"), 2000, 0.14m);
            ourTestBank.AddMortageAccount(new Company("Aladdin Foods"), 1300, 0.14m);

            Console.WriteLine(ourTestBank);

            foreach (var item in ourTestBank.BankList)
            {
                Console.WriteLine(item.CalculateInterest(5));
            }

        }

        static void ExceptionTest()
        {
            int[] integers = new int[] { 1, 2, 10, 99 }; // Change the numbers here to check if the exception is thrown.
            foreach (var integer in integers)
            {
                Console.WriteLine(integer);
                if (integer < 1 || integer > 100)
                {
                    throw new InvalidRangeException<int>("Number is out of range!", 1, 100);
                }
            }
            Console.WriteLine("All integers are in range!\n");

            DateTime date = new DateTime(2012, 6, 27);  // Change the Date here to check if the exception is thrown.
            Console.WriteLine(date);
            if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>("Date is out of range!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
            Console.WriteLine("Date is correct!");
        }
    }
}
