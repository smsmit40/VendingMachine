using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static bool LikeContinue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to make another selection? [Y/N]");
                var done = Console.ReadLine();
                done.Trim().ToUpper();
                if (done == "Y")
                {
                    return true;
                }

                if (done == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please make a valid selection");
                }

            }
        }
        static void Main(string[] args)
        {
            List<VendingMachine> Vend = new List<VendingMachine>();
            Vend.Add(new VendingMachine("Coke", 1.50, 5));
            Vend.Add(new VendingMachine("Diet Coke", 1.75, 4));
            Vend.Add(new VendingMachine("Sprite", 1.50, 5));
            Vend.Add(new VendingMachine("Red Gatorade", 2.00, 3));
            Vend.Add(new VendingMachine("Ultra Zero Monster", 2.25, 2));
            int TotalSelect = 0;
            double TotalSpent = 0;


            while (true)
            {

                Console.WriteLine("Hello, Please make a selection from the selection below:");
                Console.WriteLine($"1:{Vend[0].Name}\n2:{Vend[1].Name}\n3.{Vend[2].Name}\n4:{Vend[3].Name}\n5:{Vend[4].Name} ");
                var x = int.Parse(Console.ReadLine());


                switch (x)
                {
                    case 1:
                        if (Vend[0].Storage >= 1)
                        {
                            TotalSelect += 1;
                            Vend[0].Storage -= 1;
                            TotalSpent += Vend[0].Price;
                            Console.WriteLine($"You have selected a {Vend[0].Name}.  THat will be ${Vend[0].Price}.");
                            Console.WriteLine($"Storage: {Vend[0].Storage}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"We are out of {Vend[0].Name}.  Please select another product");
                            break;
                        }
                    case 2:
                        if (Vend[1].Storage >= 1)
                        {
                            TotalSelect += 1;
                            Vend[1].Storage -= 1;
                            TotalSpent += Vend[1].Price;
                            Console.WriteLine($"You have selected a {Vend[1].Name}.  THat will be ${Vend[1].Price}.");
                            Console.WriteLine($"Storage: {Vend[1].Storage}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"We are out of {Vend[1].Name}.  Please select another product");
                            break;
                        }
                    case 3:
                        if (Vend[2].Storage >= 1)
                        {
                            TotalSelect += 1;
                            Vend[2].Storage -= 1;
                            TotalSpent += Vend[2].Price;
                            Console.WriteLine($"You have selected a {Vend[2].Name}.  THat will be ${Vend[2].Price}.");
                            Console.WriteLine($"Storage: {Vend[2].Storage}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"We are out of {Vend[2].Name}.  Please select another product");
                            break;
                        }
                    case 4:
                        if (Vend[3].Storage >= 1)
                        {
                            TotalSelect += 1;
                            Vend[3].Storage -= 1;
                            TotalSpent += Vend[3].Price;
                            Console.WriteLine($"You have selected a {Vend[3].Name}.  THat will be ${Vend[3].Price}.");
                            Console.WriteLine($"Storage: {Vend[3].Storage}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"We are out of {Vend[3].Name}.  Sorry for any inconvenience");
                            continue;
                        }

                    case 5:
                        if (Vend[4].Storage >= 1)
                        {
                            TotalSelect += 1;
                            Vend[4].Storage -= 1;
                            TotalSpent += Vend[4].Price;
                            Console.WriteLine($"You have selected a {Vend[4].Name}.  THat will be ${Vend[4].Price}.");
                            Console.WriteLine($"Storage: {Vend[4].Storage}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"We are out of {Vend[4].Name}.  Please select another product");
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid selection.  Please try again.");
                        break;
                }

                var finished = LikeContinue();
                if (finished==true)
                {
                    continue;
                }
                if(finished==false)
                {
                    Console.WriteLine($"\n\n\nYou have selected {TotalSelect} items for a total of ${TotalSpent}.\nThank You!");
                    break;
                }



            }



        }

    }
}
