using System;
using System.Collections.Generic;
using System.Text;

namespace Sign_up_and_Login_Application
{
    class Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public int Barangay { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public void SignUp()
        {
            Boolean complete = false;
            while (!complete)
            {
                // ACCOUNT VERIFICATION
            Username:
                Console.Write("Username: ");
                this.Username = Console.ReadLine();
                if (this.Username.Length < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto Username;
                }

            Password:
                Console.Write("Password: ");
                this.Password = Console.ReadLine();
                if (this.Password.Length < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto Password;
                }
                // Password Strength
                if (this.Password.Length < 5) Console.WriteLine("WEAK PASSWORD");
                else if (this.Password.Length < 8) Console.WriteLine("MEDIUM PASSWORD");
                else Console.WriteLine("STRONG PASSWORD");

                ConfirmPassword:
                Console.Write("Confirm Password: ");
                this.ConfirmPassword = Console.ReadLine();
                if (this.Password != this.ConfirmPassword)
                {
                    Console.WriteLine("Please MATCH the password!");
                    goto ConfirmPassword;
                }
                if (this.ConfirmPassword.Length < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto ConfirmPassword;
                }

            Email:
                Console.Write("Email: ");
                this.Email = Console.ReadLine();
                if (!this.Email.Contains("@") || !this.Email.Contains(".com"))
                {
                    Console.WriteLine("Please ENTER a valid Email Address!");
                    goto Email;
                }

                HouseNumber:
                Console.Write("House Number: ");
                this.HouseNumber = Int32.Parse(Console.ReadLine());
                if (this.HouseNumber < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto HouseNumber;
                }

                Street:
                Console.Write("Street: ");
                this.Street = Console.ReadLine();
                if (this.Street.Length < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto Street;
                }

                Barangay:
                Console.Write("Barangay: ");
                this.Barangay = Int32.Parse(Console.ReadLine());
                if (this.Barangay < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto Barangay;
                }

                City:
                Console.Write("City: ");
                this.City = Console.ReadLine();
                if (this.City.Length < 3)
                {
                    Console.Write("Length should be GREATER than 3!");
                    goto City;
                }

                ZipCode:
                Console.Write("Zip Code: ");
                this.ZipCode = Int32.Parse(Console.ReadLine());
                if (this.ZipCode < 3)
                {
                    Console.WriteLine("Length should be GREATER than 3!");
                    goto ZipCode;
                }

                // If verification is done complete = true
                complete = true;
                if (complete == true)
                {
                    break;
                }

            }
        }

        // Display Account
        public void LogIn()
        {
            Console.WriteLine("Username: {0}", this.Username);
            Console.WriteLine("Email: {0}", this.Email);
            Console.WriteLine("House Number: {0}", this.HouseNumber);
            Console.WriteLine("Street: {0}", this.Street);
            Console.WriteLine("Barangay: {0}", this.Barangay);
            Console.WriteLine("City: {0}", this.City);
            Console.WriteLine("Zip Code: {0}", this.ZipCode);
        }

   
    }
}
