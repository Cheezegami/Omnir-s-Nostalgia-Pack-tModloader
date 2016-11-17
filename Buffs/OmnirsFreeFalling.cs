//using System;
//using System.Collections.Generic;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;

//using Terraria;
//using Terraria.DataStructures;
//using Terraria.ID;
//using Terraria.ModLoader;

//namespace OmnirsNosPak.Buffs
//{
//    public class OmnirsFreeFalling : ModBuff
//    {
//        public static Color buffColor = new Color(254, 200, 175);

//        public override void SetDefaults()
//        {
//            Main.buffName[this.Type] = "Free Falling";
//            Main.buffTip[this.Type] = "You're falling through the Earth!";
//            Main.debuff[Type] = false;
//            Main.pvpBuff[Type] = true;
//        }
//        public override void Update(Player player, ref int buffIndex)
//        {
//            int buffTime = player.buffTime[index];
//            MWorld.CheckingMyCollision = true;
//        }

//        public override void Effects(NPC npc, int index)
//        {
//            npc.noTileCollide = true;
//        }
//    }
//}