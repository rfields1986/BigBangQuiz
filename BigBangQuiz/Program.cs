using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment
{
    class Program
    {
        static void Main(string[] args)

        {
            string input;

            Console.WriteLine("  Which TV Character Are You");
            Console.WriteLine("    \"The Big Bang Theroy\" Edition");
            Console.WriteLine("======================================\n\n");


            Console.WriteLine("Answer The Questions \"Y\" for Yes and \"N\" for No\n\n");


            Console.Write(" Are you lactose intolerant?  --> ");
            input = Console.ReadLine();
            Console.WriteLine("\n");


            if (input == "N" || input == "n")

            {
                Console.WriteLine(" Enjoy a glass of milk!!");
                Console.Write(" Will you move on to the next question?-->  ");
                input = Console.ReadLine();
                Console.WriteLine("\n");

                if (input == "Y" || input == "y")
                {
                    Console.Write(" Are you socially awkward?-->  ");
                    input = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (input == "N" || input == "n")
                    {
                        Console.WriteLine(" Enjoy a glass of milk with friends!!");
                        Console.Write(" Will you move on to the next question?-->  ");
                        input = Console.ReadLine();
                        Console.WriteLine("\n");

                        if (input == "Y" || input == "y")
                        {
                            Console.Write(" Do you have a high level of social awareness?-->  ");
                            input = Console.ReadLine();
                            Console.WriteLine("\n");

                            if (input == "N" || input == "n")
                            {
                                Console.WriteLine(" Enjoy a glass of milk with friends who think your awkward.");
                                Console.Write(" Will you move on to the next question?-->  ");
                                input = Console.ReadLine();
                                Console.WriteLine("\n");

                                if (input == "Y" || input == "y")
                                {
                                    Console.Write(" Would you like to be called Rocket Man instead of Froot Loops?-->  ");
                                    input = Console.ReadLine();
                                    Console.WriteLine("\n");

                                    if (input == "N" || input == "n")
                                    {
                                        Console.WriteLine(" Alright Fruit Loops For Life!!");
                                        Console.Write(" Will you move on to the next question--?  ");
                                        input = Console.ReadLine();
                                        Console.WriteLine("\n");

                                        if (input == "Y" || input == "y")
                                        {
                                            Console.Write(" Are you afraid to talk to the opposite gender?-->  ");
                                            input = Console.ReadLine();
                                            Console.WriteLine("\n");

                                            if (input == "N" || input == "n")
                                            {
                                                Console.WriteLine(" You are not like any of the character on \"The Big Bang Theroy.\"");
                                                Console.WriteLine("=============================Play Again===========================");
                                                Console.WriteLine("==================================================================\n\n");
                                            }
                                            else
                                            {
                                                Console.WriteLine(" You are Dr. Rajesh Ramayan Koothrappali");
                                                Console.WriteLine("                  Goodbye");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(" Goodbye Froot Loops\n\n");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(" You are Howard Wolowitz");
                                        Console.WriteLine("         GoodBye\n\n");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine(" Goodbye Low Awarness Social Milk Drinker \n\n ");
                                }
                            }
                            else
                            {
                                Console.WriteLine(" You are Penny");
                                Console.WriteLine("    Goodbye\n\n");
                            }
                        }
                        else
                        {

                            Console.WriteLine("Goodbye Social Milk Drinker\n\n");
                        }




                    }
                    else
                    {
                        Console.WriteLine(" You are Dr. Sheldon Cooper");
                        Console.WriteLine("         Goodbye\n\n");
                    }



                }

                else
                {
                    Console.WriteLine(" Goodbye Milk Drinker \n\n");
                }

            }

            else

            {
                Console.WriteLine(" You are Dr. Leonard Hofstadter");
                Console.WriteLine("            Goodbye \n\n");
            }






































        }
    }
}
