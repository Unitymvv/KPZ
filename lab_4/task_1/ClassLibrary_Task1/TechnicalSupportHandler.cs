using System;

namespace ClassLibrary_Task1
{
    public class TechnicalSupportHandler : SupportHandler
    {
        public override bool Handle(string input)
        {
            if (input == "2")
            {
                Console.WriteLine("Технічна підтримка: вирішуємо вашу технічну проблему.");
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
