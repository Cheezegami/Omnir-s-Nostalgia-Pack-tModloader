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
    public class OmnirsCoralSword : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Coral Sword";
			item.width = 36;
			item.height = 36;
			item.damage = 19;
			item.knockBack = 5;
			item.scale = 0.9f;
			item.rare = 3;
			item.value = 11000;
            item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 23;
			item.useAnimation = 23;
			item.melee = true;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (target.type == 55 || target.type == 57 || target.type == 58 || target.type == 63 || target.type == 64 || target.type == 65 || target.type == 103 || target.type == 220 || target.type == 221 || target.type == 224 || target.type == 230 || target.type == 370 /*(|| (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsSahagin"].type)) ||
               NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsSahaginChief"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsSahaginPrince"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsQuaraConstrictor"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsQuaraHydromancer"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsQuaraMantassin"].type)) ||
               (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsQuaraPincher"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsQuaraPredator"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsTheWaterFiendKraken"].type))*/) damage *= 4;
        } 
    }
    }