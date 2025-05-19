using System;

namespace ClassLibrary_Task1
{
    public class BasicSupportHandler : SupportHandler
    {
        public override bool Handle(string input)
        {
            if (input == "1")
            {
                Console.WriteLine("Базова підтримка: відповідаємо на ваше запитання.");
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
