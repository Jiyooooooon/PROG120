using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMaching
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerCommand;
            
            Vending Coke = new Vending();

            Console.WriteLine("Welcome!");
            Console.WriteLine();
            Console.WriteLine("Please type P to insert a dollar,");
            Console.WriteLine("or B to buy a Coke");
            Console.WriteLine("or R to get all your money back");
            Console.WriteLine("or Q to quit this program");
            Console.WriteLine();
            customerCommand = Console.ReadLine();
            customerCommand = customerCommand.ToUpper();
            while (customerCommand != "Q")
            {
                switch (customerCommand)
                {
                    case "P":
                        Coke.AcceptCash();
                        Console.WriteLine("Thank you, you now have ${0}", Coke.Balance);
                        break;
                    case "B":
                        switch (Coke.BuyCoke())
                        {
                            case 0:
                                Console.WriteLine("Thank you for your purchase, you have ${0} left.", Coke.Balance);
                                break;
                            case 1:
                                Console.WriteLine("Sorry, the machine is empty. Enter an R to get your money back.");
                                break;
                            case 2:
                                Console.WriteLine("Sorry, you need to insert a dollar.");
                                break;
                            case 3:
                                Console.WriteLine("Sorry, you need to insert a dollar and the machince is empty.");
                                break;
                            default:
                                Console.WriteLine("Invaild selection");
                                break;
                        }
                        break;
                    case "R":
                        if (Coke.Balance != 0)
                        {
                            Console.WriteLine("Here is your ${0}", Coke.GiveRefund());
                        }
                        else
                        {
                            Console.WriteLine("sorry, you don't have that much money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invaild selection");
                        break;
                }
                Console.WriteLine("Please type P to insert a dollar,");
                Console.WriteLine("or B to buy a Coke");
                Console.WriteLine("or R to get all your money back");
                Console.WriteLine("or Q to quit this program");
                customerCommand = Console.ReadLine();
                customerCommand = customerCommand.ToUpper();
            }
            Console.WriteLine("Have a good day, See you later!");
            Console.ReadLine();
        }
    }
}
