using _04_04_2022_HomeTask.Models;
using System;

namespace _04_04_2022_HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            try
            {
                while (input > 0 && input <= 6)
                {
                    Console.WriteLine("1.AZN to EUR\n2.AZN to USD\n3.USD to AZN\n4.USD to Eur\n5.EUR to AZN\n6.EUR to USD");
                    input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("pls enter amount of AZN");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            AZN azn = new AZN(amount);
                            EUR eur = azn;
                            Console.WriteLine(eur.Amount);
                            break;
                        case 2:
                            Console.WriteLine("pls enter amount of AZN");
                            double amount1 = Convert.ToDouble(Console.ReadLine());
                            AZN azn1 = new AZN(amount1);
                            USD usd = azn1;
                            Console.WriteLine(usd.Amount);
                            break;
                      case 3:
                            Console.WriteLine("Pls enter amount of USD");
                            double amount2 = Convert.ToDouble(Console.ReadLine());
                            USD usd1 = new USD(amount2);
                            AZN azn2 = usd1;
                            Console.WriteLine(azn2.Amount);
                            break;
                        case 4:
                            Console.WriteLine("Pls enter amount of USD");
                            double amount3 = Convert.ToDouble(Console.ReadLine());
                            USD usd3 = new USD(amount3);
                            EUR eur1 = usd3;
                            Console.WriteLine(eur1.Amount);
                            break;
                        case 5:
                            Console.WriteLine("pls enter amount EUR");
                            double amount4 = Convert.ToDouble(Console.ReadLine());
                            EUR eur2 = new EUR(amount4);
                            AZN azn3 = eur2;
                            Console.WriteLine(azn3.Amount);
                            break;
                        case 6:
                            Console.WriteLine("pls enter amount EUR");
                            double amount5 = Convert.ToDouble(Console.ReadLine());
                            EUR eur3 = new EUR(amount5);
                            USD usd2 = eur3;
                            Console.WriteLine(usd2.Amount);
                            break;

                        default:
                            Console.WriteLine("not found");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //USD usd = new USD(500);
            //AZN azn = usd;
            //EUR eur = new EUR(500);
            //azn = eur;
            //Console.WriteLine(azn.Amount);
            USD us = new USD(700);
            AZN az = new AZN(1000);
            Console.WriteLine(us == az);

        }
    }
}
//AZN--USD
//AZN--EUR
//USD--AZN
//USD--EUR
//EUR--AZN
//EUR--USD