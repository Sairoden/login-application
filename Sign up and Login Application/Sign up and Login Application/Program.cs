using System;
using System.Collections;
using System.Collections.Generic;

namespace Sign_up_and_Login_Application
{
    class Program
    { 
        static void Main(string[] args)
        {
            int choice = 0;
            Form[] account = new Form[3];
            int limitAccount = 0;

        // DESIGN FIRST
        menu:
            Design newDesign = new Design();
            newDesign.Show();

            // Choices
            Console.WriteLine("Press the number according to your choices");
            choice = Int32.Parse(Console.ReadLine());

            // SHOW ACCOUNT(1)
            if (choice == 1)
            {
                for (int i = 0; i < limitAccount; i++)
                {
                    newDesign.EndLine();
                    Console.WriteLine("");
                    account[i].LogIn();
                }
                goto menu;
            }

            // CREATE ACCOUNT(2)
            else if (choice == 2)
            {
                newDesign.EndLine();
                Console.WriteLine("");

                if (limitAccount == 3)
                {
                    Console.WriteLine("Accounts are limited to 3 only!");
                    goto menu;
                }
                else
                {
                    Form firstAccount = new Form();
                    account[limitAccount] = firstAccount;

                    Form secondAccount = new Form();
                    account[limitAccount] = secondAccount;

                    Form thirdAccount = new Form();
                    account[limitAccount] = thirdAccount;

                    account[limitAccount].SignUp();
                    limitAccount++;

                    newDesign.EndLine();
                    Console.WriteLine("");
                    Console.WriteLine("                                       ACCOUNT ADDED SUCCESSFULLY!");
                    Console.WriteLine("");
                    goto menu;
                }
            }

            // FORGOT PASSWORD(3)
            else if (choice == 3) {
                forgotPassword:
                newDesign.EndLine();
                Console.WriteLine("");
                Console.WriteLine("Please enter your account number (1-3)");
                int accNumber = Int32.Parse(Console.ReadLine());
  
                if (accNumber > 0 && accNumber < 4)
                {
                    if (account[accNumber - 1] == null)
                    {
                        Console.WriteLine("Account Not Found!");
                        goto forgotPassword;
                    }
                    else
                    {
                        newDesign.EndLine();
                        Console.WriteLine("");
                        Console.WriteLine("Your PASSWORD is {0}", account[accNumber - 1].Password);
                        Console.WriteLine("");
                    goto menu;
                    }
                }  
                else
                {
                    goto menu;
                }
                
            }

            // LOGIN(4)
            else if (choice == 4)
            {
                // Check if username input is correct
                newDesign.EndLine();
                Console.WriteLine("");
            UsernameLog:
                Console.Write("Username: ");
                string user = Console.ReadLine();
                if (user.Length < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto UsernameLog;
                }

            // Check if password input is correct
            PasswordLog:
                Console.Write("Password: ");
                string pass = Console.ReadLine();
                if (pass.Length < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto PasswordLog;
                }

            // Check if email input is correct
            EmailLog:
                Console.Write("Email: ");
                string emailAdd = Console.ReadLine();
                if (!emailAdd.Contains("@") || !emailAdd.Contains(".com"))
                {
                    Console.WriteLine("Please ENTER a valid Email Address!");
                    goto EmailLog;
                }

            // Check if User ID input is correct
            userID:
                Console.WriteLine("Please enter your account number (1-3)");
                int accountID = Int32.Parse(Console.ReadLine());

                newDesign.EndLine();
                Console.WriteLine("");

                if (accountID> 0 && accountID < 4)
                {
                    if (account[accountID - 1] == null)
                    {
                        Console.WriteLine("Account Not Found!");
                        goto userID;
                    }
                    else
                    {
                        if (!account[accountID - 1].Password.Contains(pass))
                        {
                            Console.WriteLine("Account Not Found!");
                            goto UsernameLog;
                        }
                        account[accountID - 1].LogIn();
                        goto menu;
                    }
                }
                else
                {
                    goto UsernameLog;
                }
            }

            // EXIT PROGRAM
            else
            {
                newDesign.Terminate();
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
