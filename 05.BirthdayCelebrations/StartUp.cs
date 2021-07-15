using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command;
            List<IBirthable> populations = new List<IBirthable>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Robot")
                {
                    continue;
                }
                else if (tokens[0] == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthday = tokens[4];
                    IBirthable citizen = new Citizen(name, age, id, birthday);
                    populations.Add(citizen);
                }
                else
                {
                    string name = tokens[1];
                    string birthday = tokens[2];
                    IBirthable pet = new Pet(name, birthday);
                    populations.Add(pet);
                }
            }

            string year = Console.ReadLine();
            List<string> birthdays = populations
                .Where(x=>x.Birthdate.EndsWith(year))
                .Select(x => x.Birthdate)
                .ToList();

            if (!birthdays.Any())
            {
                Console.WriteLine("<empty output>");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, birthdays));
            }
        }
    }
}
