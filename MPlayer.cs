using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak
{
    public class MPlayer : ModPlayer //Shield code by Yorai
    {
        public static bool dragoonJump = false;
        public static bool dragoonJump2 = false;

        MPlayer p = (MPlayer)player.GetModPlayer(mod, "MPlayer");
        if(p.dragoonJump)player.jumpSpeedBoost += 10f;

    }
//        //public int observedDefense;
//        //public override void PostItemCheck()
//        //{
//        //    if (player.heldProj != -1 && Main.projectile[player.heldProj].subClass is ModProjectileShield)
//        //    {
//        //        observedDefense += ((ModProjectileShield)Main.projectile[player.heldProj].subClass).DefenseBonus();
//        //        //Main.NewText("observedDefense", 175, 75, 255);
//        //    }
//        //    if (observedDefense > 0)
//        //    {
//        //        Main.NewText("observedDefense", 175, 75, 255);
//        //    }
//        //}

    public override void ResetEffects() // runs every update to reset all custom effects on a player, otherwise they persist
	{
			jumpToggle = jumpToggle = (Main.GetKeyState((int)Microsoft.Xna.Framework.Input.Keys.Z) == 1); //this is how i re-did the jump boots, feel free to use
	}

//        public override void MidUpdate()
//        {
//            //player.statDefense += observedDefense;
//            //observedDefense = 0;
//            if (dragoonJump)
//            {
//                if (Main.GetKeyState((int)Microsoft.Xna.Framework.Input.Keys.Z) > 0)
//                {
//                    dragoonJump2 = true;
//                    //Main.NewText("Dragoon Jump is now active.", 175, 75, 255);
//                }
//                else
//                {
//                    dragoonJump2 = false;
//                    //Main.NewText("Dragoon Jump is now deactivated.", 175, 75, 255);
//                }
//            }
//            else
//            {
//                dragoonJump = false;
//                dragoonJump2 = false;
//                //Main.NewText("Dragoon Jump is now deactivated3.", 175, 75, 255);
//            }
//            dragoonJump = false;
//            if (dragoonJump2)
//            {
//                Player.jumpSpeed += 10f;
//            }

//        }
//    }
}
