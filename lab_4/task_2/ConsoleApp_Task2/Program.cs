using DesignPatterns.Mediator;

namespace ConsoleApp_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var runways = new[]
                    {
            new Runway(),
            new Runway()
        };

            var aircrafts = new[]
            {
            new Aircraft("Boeing 737"),
            new Aircraft("Airbus A320"),
            new Aircraft("Embraer 190")
        };

            var commandCentre = new CommandCentre(runways, aircrafts);

            commandCentre.RequestLanding(aircrafts[0]);
            commandCentre.RequestLanding(aircrafts[1]);
            commandCentre.RequestLanding(aircrafts[2]);

            commandCentre.RequestTakeOff(aircrafts[0]);

            commandCentre.RequestLanding(aircrafts[2]);
        }
    }
}
