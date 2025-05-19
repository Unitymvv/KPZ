using ClassLibrary_Task3;
using System;

namespace ConsoleApp_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var auth1 = Authenticator.Instance;
            var auth2 = Authenticator.Instance;

            auth1.Authenticate("admin");

            Console.WriteLine($"Are both instances the same? {object.ReferenceEquals(auth1, auth2)}");
        }
    }
}
