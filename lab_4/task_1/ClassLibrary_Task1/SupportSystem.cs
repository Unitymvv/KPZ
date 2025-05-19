using System;

namespace ClassLibrary_Task1
{
    public class SupportSystem
    {
        private SupportHandler _handlerChain;

        public SupportSystem()
        {
            var basic = new BasicSupportHandler();
            var tech = new TechnicalSupportHandler();
            var billing = new BillingSupportHandler();
            var operatorHandler = new OperatorSupportHandler();

            basic.SetNext(tech);
            tech.SetNext(billing);
            billing.SetNext(operatorHandler);

            _handlerChain = basic;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nВиберіть тип підтримки:");
                Console.WriteLine("1 - Базова підтримка");
                Console.WriteLine("2 - Технічна підтримка");
                Console.WriteLine("3 - Фінансова підтримка");
                Console.WriteLine("4 - З'єднати з оператором");
                Console.Write("Ваш вибір: ");
                string input = Console.ReadLine();

                bool handled = _handlerChain.Handle(input);

                if (handled)
                {
                    Console.WriteLine("Дякуємо за звернення!");
                    break;
                }
                else
                {
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                }
            }
        }
    }
}
