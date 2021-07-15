using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command;
            List<IIdentifiable> populations = new List<IIdentifiable>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];

                if (tokens.Length == 2)
                {
                    string id = tokens[1];
                    Robot robot = new Robot(name, id);
                    populations.Add(robot);
                }
                else
                {
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    Citizen citizen = new Citizen(name, age, id);
                    populations.Add(citizen);
                }
            }

            string fakeId = Console.ReadLine();
            List<string> fakeIds = populations
                .Where(x => x.Id.EndsWith(fakeId))
                .Select(x => x.Id)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fakeIds));
        }
    }
}
