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
    public class OmnirsGreatSword : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Great Sword";
			item.width = 48;
			item.height = 48;
			item.damage = 35;
			item.knockBack = 8;
			item.scale = 1.15f;
			item.rare = 4;
            item.toolTip = "A sword used to kill giant-kind.";
            item.value = 12000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 21;
			item.melee = true;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsGigas"].type)) damage *= 2;
            else if ((NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsFireGigas"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsIceGigas"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsIronGiant"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsRockGolem"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsClayGolem"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsIronGolem"].type))) damage *= 4;
        }
    }
}