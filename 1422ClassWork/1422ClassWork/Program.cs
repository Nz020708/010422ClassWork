using System;

namespace _1422ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("Naz Mzadeh", "7QD1XHL@code.edu.az", "Cf6DJDJH");
            IAccount obj;
            obj = user1;
            obj.ShowInfo();
          var a=  obj.PasswordChecker("jSgd3jhsh");
            Console.WriteLine(a);
        }
    }
}
