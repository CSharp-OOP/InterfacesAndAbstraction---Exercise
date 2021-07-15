using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;
using _07.MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MilitaryElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<ISoldier> result = new List<ISoldier>();

            string input;

            while ((input=Console.ReadLine())!="End")
            {
                string[] tokens = input
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string soldierType = tokens[0];
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];

                if (soldierType=="Private")
                {
                    decimal salary = decimal.Parse(tokens[4]);
                    result.Add(new Private(id,firstName,lastName,salary));
                }
                else if (soldierType=="Spy")
                {
                    int codeNumber = int.Parse(tokens[4]);
                    result.Add(new Spy(id,firstName,lastName,codeNumber));
                }
                else if (soldierType=="LeutenantGeneral")
                {
                    decimal salary = decimal.Parse(tokens[4]);
                    List<IPrivate> privates = new List<IPrivate>();

                    foreach (var currentId in tokens[5..])
                    {
                        var currentPrivate = (IPrivate)result
                            .FirstOrDefault(x=>x.Id==int.Parse(currentId));
                        privates.Add(currentPrivate);
                    }

                    result.Add(new LieutenantGeneral(id, firstName, lastName, salary,privates));
                }
                else if (soldierType=="Engineer")
                {
                    decimal salary = decimal.Parse(tokens[4]);
                    Enum.TryParse(tokens[5],false, out SouldierCorpEnum corp);
                    if (corp==default)
                    {
                        continue;
                    }

                    List<IRepair> repairs = new List<IRepair>();

                    for (int i = 0; i < tokens[6..].Length/2; i+=2)
                    {
                        var partName = tokens[i];
                        var workedHours = int.Parse(tokens[i+1]);

                        repairs.Add(new Repair(partName,workedHours));
                    }

                    result.Add(new Engineer(id, firstName, lastName, salary,corp,repairs));
                }
                else
                {
                    decimal salary = decimal.Parse(tokens[4]);
                    Enum.TryParse(tokens[5], false, out SouldierCorpEnum corp);
                    if (corp == default)
                    {
                        continue;
                    }

                    List<IMission> missions = new List<IMission>();

                    for (int i = 0; i < tokens[6..].Length; i++)
                    {
                        var missionState = tokens[i + 1];
                        if (missionState != "inProgress" && missionState != "Finished")
                        {
                            continue;
                        }

                        string missionName = tokens[i];
                        Enum.TryParse(missionState,false,out MissionStateEnum state);
                        if (state!=default)
                        {
                            IMission mission = new Mission(missionName, state);
                            missions.Add(mission);
                        }
                    }

                    result.Add(new Commando(id, firstName, lastName, salary, corp, missions));
                }
            }



            foreach (var soldier in result)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
