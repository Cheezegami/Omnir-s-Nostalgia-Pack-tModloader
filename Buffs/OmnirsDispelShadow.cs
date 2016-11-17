//using System;
//using Terraria;
//using Terraria.ID;
//using Terraria.ModLoader;

//namespace OmnirsNosPak.Buffs
//{
//    public class OmnirsDispelShadow : ModBuff
//    {
//        public override void Effects(NPC npc, int index)
//        {
//            if (npc.name == "OmnirsWitchking" || npc.name == "OmnirsNazgul" || npc.name == "OmnirsSauron")
//            {
//                npc.defense -= 3000;
//                if (npc.defense < 0)
//                {
//                    npc.defense = 0;
//                }
//            }
//        }
//    }
//}