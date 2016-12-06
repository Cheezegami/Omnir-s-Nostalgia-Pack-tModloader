using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items // Code modified from Zero-Exodus's code :)
{
    public class OmnirsWereBane : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Were Bane";
			item.width = 42;
			item.height = 42;
			item.damage = 18;
			item.knockBack = 5;
			item.scale = 1;
			item.rare = 2;
            item.toolTip = "A sword used to kill were-beasts.";
			item.value = 40000;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 21;
			item.melee = true;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            //if (NPC.AnyNPCs(NPCDef.byName["Werewolf"].type)) damage *= 4;
            if (target.type == 104 || target.type == 343)
            {
                damage *= 4;
            }
        }
    }
}