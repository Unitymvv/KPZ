using System;

namespace ClassLibrary_Task1
{
    public class BillingSupportHandler : SupportHandler
    {
        public override bool Handle(string input)
        {
            if (input == "3")
            {
                Console.WriteLine("Фінансова підтримка: допомагаємо з оплатою.");
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
