﻿namespace GVRP.Module.Players.Buffs
{
    public class PlayerBuffs
    {
        public int DrugsInfected { get; set; }
        public int JointBuff { get; set; }
        public int Cocain { get; set; }
        public int GCocain { get; set; }
        public int DrugBuff { get; set; }
        public int DrugBuildUsed { get; set; }
        public uint LastDrugId { get; set; }

        public PlayerBuffs()
        {
            DrugsInfected = 0;
            JointBuff = 0;
            Cocain = 0;
            GCocain = 0;
            DrugBuff = 0;
            DrugBuildUsed = 0;
            LastDrugId = 0;
        }
    }
}