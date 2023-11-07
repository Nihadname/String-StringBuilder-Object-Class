using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder_Object_Class.Models
{
    internal class Account
    {
        public string UserName = "lorem123";
        public string Password = "password123456*";
        public void Login(string Enteredusername, string Enteredpassword)
        {
            if (UserName == Enteredusername && Password == Enteredpassword)
            {
                Console.WriteLine("giris ugurludur");

            }
            else
            {
                Console.WriteLine("email ve ya password sehvdir cixsin.");
            }
        }
    }
}
