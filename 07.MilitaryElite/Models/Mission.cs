using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, MissionStateEnum missionState)
        {
            CodeName = codeName;
            MissionState = missionState;
        }

        public string CodeName { get; }

        public MissionStateEnum MissionState { get; private set; }

        public void CompleteMission()
        {
            this.MissionState = MissionStateEnum.Finished;
        }
    }
}
