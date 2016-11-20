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
        public bool dualCast = false;

        // Critical Damage Multiplier as used in Cheeze's Content Pack.
        public float critMultiplier = 1.0f; // Base crit multiplier. Critical damage will be damage * this number + damage type modifier.
        public float meleeCritMultiplier = 0.0f; // Melee Crit Multiplier, percentage that will be added onto the critical damage.
        public float rangedCritMultiplier = 0.0f; // Ranged Crit Multiplier, percentage that will be added onto the critical damage.
        public float magicCritMultiplier = 0.0f; // Magic Crit Multiplier, percentage that will be added onto the critical damage.
        public float thrownCritMultiplier = 0.0f; // Thrown Crit Multiplier, percentage that will be added onto the critical damage.

        //MPlayer p = (MPlayer)player.GetModPlayer(mod, "MPlayer");
        //if(p.dragoonJump)player.jumpSpeedBoost += 10f;

        //public int observedDefense;
        //public override void PostItemCheck()
        //{
        //    if (player.heldProj != -1 && Main.projectile[player.heldProj].subClass is ModProjectileShield)
        //    {
        //        observedDefense += ((ModProjectileShield)Main.projectile[player.heldProj].subClass).DefenseBonus();
        //        //Main.NewText("observedDefense", 175, 75, 255);
        //    }
        //    if (observedDefense > 0)
        //    {
        //        Main.NewText("observedDefense", 175, 75, 255);
        //    }
        //}
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



        public override void ModifyHitNPC(Item item, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            if (crit == true) // Critical Damage Multiplier function as found in Cheeze's Content Pack for items.
            {
                if (item.melee == true) // Melee Crit
                {
                    damage = (int)(damage * (critMultiplier + meleeCritMultiplier)); // Damage gets amplified by the crit multiplier.
                }
                else if (item.ranged == true) // Ranged Crit
                {
                    damage = (int)(damage * (critMultiplier + rangedCritMultiplier));
                }
                else if (item.magic == true) // Magic Crit
                {
                    damage = (int)(damage * (critMultiplier + magicCritMultiplier));
                }
                else if (item.thrown == true) // Thrown Crit
                {
                    damage = (int)(damage * (critMultiplier + thrownCritMultiplier));
                }
                else
                {
                    damage = (int)(damage * critMultiplier); // Damage gets amplified by the crit multiplier.
                }
            }
        }

        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            if (crit == true) // Critical Damage Multiplier function as found in Cheeze's Content Pack for projectiles.
            {
                if (proj.melee == true) // Melee Crit
                {
                    damage = (int)(damage * (critMultiplier + meleeCritMultiplier)); // Damage gets amplified by the crit multiplier.
                }
                else if (proj.ranged == true) // Ranged Crit
                {
                    damage = (int)(damage * (critMultiplier + rangedCritMultiplier));
                }
                else if (proj.magic == true) // Magic Crit
                {
                    damage = (int)(damage * (critMultiplier + magicCritMultiplier));
                }
                else if (proj.thrown == true) // Thrown Crit
                {
                    damage = (int)(damage * (critMultiplier + thrownCritMultiplier));
                }
                else
                {
                    damage = (int)(damage * critMultiplier); // Damage gets amplified by the crit multiplier.
                }
            }
        }

        public override void ResetEffects() // runs every update to reset all custom effects on a player, otherwise they persist
        {
            //jumpToggle = jumpToggle = (Main.GetKeyState((int)Microsoft.Xna.Framework.Input.Keys.Z) == 1); //this is how i re-did the jump boots, feel free to use
            dragoonJump = false;
            dragoonJump2 = false;

            this.critMultiplier = 1.00f;
            this.meleeCritMultiplier = 0.0f;
            this.rangedCritMultiplier = 0.0f;
            this.magicCritMultiplier = 0.0f;
            this.thrownCritMultiplier = 0.0f;
        }

    }
}
