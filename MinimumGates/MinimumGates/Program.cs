using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MinimumGatesProblem
{
    public static class MinimumGates
    {
        public static void Main(string[] args)
        {
            int maxNoOfGates = 0;
            //var sr = new StreamReader(args[0]);
            string[] arrivals = "9:00 9:40 9:50 11:00 15:00 18:00".Split(' ');//sr.ReadLine().Split(' ');
            string[] departures = "9:10 12:00 11:20 11:30 19:00 20:00".Split(' ');//sr.ReadLine().Split(' ');

            var planHours = new List<PlanHours>();

            for (int i = 0; i < arrivals.Length; ++i)
            {
                planHours.Add(new PlanHours
                {
                    Arrival = DateTime.Parse(arrivals[i]),
                    Departure = DateTime.Parse(departures[i]),
                });
            }

            planHours.ForEach(arg =>
            {
                var atGateAtArrival = planHours.Count(planHour => planHour.IsAtGate(arg.Arrival));
                var atGateAtDeparture = planHours.Count(planHour => planHour.IsAtGate(arg.Departure));

                if (atGateAtArrival > maxNoOfGates)
                    maxNoOfGates = atGateAtArrival;

                if (atGateAtDeparture > maxNoOfGates)
                    maxNoOfGates = atGateAtDeparture;
            });

            Console.WriteLine("{0}", maxNoOfGates);
        }

        struct PlanHours
        {
            public DateTime Arrival;
            public DateTime Departure;
            public bool IsAtGate(DateTime date)
            {
                return date >= Arrival && date <= Departure;
            }
        }
    }
}
