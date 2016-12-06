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
    public class OmnirsGigantAxe : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Gigant Axe";
			item.width = 46;
			item.height = 44;
			item.damage = 35;
			item.knockBack = 11;
			item.scale = 1;
			item.axe = 95;
			item.rare = 4;
            item.toolTip = "An axe used to kill giant-kind.";
			item.value = 120000;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 23;
			item.useAnimation = 27;
			item.melee = true;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            /*if (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsGigas"].type)) damage *= 2;
            else if ((NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsFireGigas"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsIceGigas"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsIronGiant"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsRockGolem"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsClayGolem"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsIronGolem"].type))) damage *= 4;
        */}
	}
}