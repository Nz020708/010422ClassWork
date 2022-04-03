using System;
using System.Collections.Generic;
using System.Text;

namespace _1422ClassWork
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
