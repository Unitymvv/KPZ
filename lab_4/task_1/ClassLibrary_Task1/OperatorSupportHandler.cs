using System;

namespace ClassLibrary_Task1
{
    public class OperatorSupportHandler : SupportHandler
    {
        public override bool Handle(string input)
        {
            if (input == "4")
            {
                Console.WriteLine("Оператор: з'єднуємо з живим працівником.");
                return true;
            }
            else if (next != null)
            {
                return next.Handle(input);
            }
            return false;
        }
    }
}