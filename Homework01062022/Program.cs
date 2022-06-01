using System;

namespace Homework01062022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adamin username ini daxil ele: ");
            string username = Console.ReadLine();
            User adam = new User(username);

            Console.Write("Adamin passwordunu daxil ele: ");
            string password = Console.ReadLine();
            adam.Password = password;


        }
    }
}

