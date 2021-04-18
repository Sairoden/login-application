using System;
using System.Collections.Generic;
using System.Text;

namespace Sign_up_and_Login_Application
{
    class Design : Form
    {
        public void Show()
        {
            // Main Menu Design
            Console.WriteLine("              ┌────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("              │                                  WELCOME!                                              │");
            Console.WriteLine("              ├──────────────────┬──────────────────────┬─────────────────────┬─────────────┬──────────┤");
            Console.WriteLine("              │  SHOW ACCOUNT(1) │  CREATE ACCOUNT(2)   │ FORGOT PASSWORD(3)  │  LOGIN(4)   │  EXIT(5) │");
            Console.WriteLine("              └──────────────────┴──────────────────────┴─────────────────────┴─────────────┴──────────┘");
        }

        public void EndLine()
        {
            // LINE TERMINATOR
            Console.WriteLine("              ┌──────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("              ├──────────────────┬──────────────────────┬─────────────────────┬──────────────┤");

        }

        public void Terminate()
        {
            // EXIT PROGRAM DESIGN
            Console.WriteLine("              ┌──────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("              │                               THANK YOU FOR THE TIME!                        │");
            Console.WriteLine("              ├──────────────────┬──────────────────────┬─────────────────────┬──────────────┤");
            Console.WriteLine("              └──────────────────┴──────────────────────┴─────────────────────┴──────────────┘");
        }
    }
}
