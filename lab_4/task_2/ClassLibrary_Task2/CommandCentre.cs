using System;
using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Dictionary<Aircraft, Runway> _assignments = new Dictionary<Aircraft, Runway>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            Console.WriteLine($"\nAircraft {aircraft.Name} requesting landing...");

            foreach (var runway in _runways)
            {
                if (!runway.IsBusy)
                {
                    runway.MarkAsBusy();
                    _assignments[aircraft] = runway;
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {runway.Id}.");
                    return;
                }
            }

            Console.WriteLine($"No available runway for aircraft {aircraft.Name}.");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"\nAircraft {aircraft.Name} requesting takeoff...");

            if (_assignments.TryGetValue(aircraft, out var runway))
            {
                runway.MarkAsFree();
                _assignments.Remove(aircraft);
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {runway.Id}.");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not assigned to any runway.");
            }
        }
    }
}