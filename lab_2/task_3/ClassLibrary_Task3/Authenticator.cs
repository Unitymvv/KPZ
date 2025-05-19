using System;
using System.Threading;

namespace ClassLibrary_Task3
{
    public sealed class Authenticator
    {
        private static Lazy<Authenticator> _authenticator = new Lazy<Authenticator> (() => new Authenticator(), LazyThreadSafetyMode.ExecutionAndPublication);

        private Authenticator()
        {
            Console.WriteLine("Authenticator initialized");
        }

        public static Authenticator Instance => _authenticator.Value;

        public void Authenticate(string user)
        {
            Console.WriteLine($"User '{user}' authenticated.");
        }
    }
}
