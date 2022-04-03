using System;
using System.Collections.Generic;
using System.Text;

namespace _1422ClassWork
{
    class User:IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isUpper { get; set; }
        public bool isLower { get; set; }
        public bool isDigit { get; set; }


        public User(string fullname,string email,string password)
        {
            FullName = fullname;
            Email = email;
            Password = password;
        }
        bool IAccount.PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (Char.IsUpper( item))
                    {
                        isUpper = true;
                    }
                    if (Char.IsLower(item))
                    {
                        isLower = true;
                    }
                   if (Char.IsDigit( item))
                    {
                        isDigit = true;
                    }
                   
                   
                }
                if (isUpper && isLower && isDigit)
                {
                    Console.WriteLine("Successful login ");
                }
                else
                {
                    Console.WriteLine("Attention! Password must contain at least one digit,one uppercase letter and one lowercase letter.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Attention! Password must be at least 8 characters.");
                return false;
            }

            return true;
        }

        void IAccount.ShowInfo()
        {
            Console.WriteLine($"Full Name: {FullName} \nEmail:{Email}");
        }
    }
}
