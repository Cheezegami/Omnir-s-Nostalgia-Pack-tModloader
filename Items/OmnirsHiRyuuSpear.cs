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
	public class OmnirsHiRyuuSpear : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "HiRyuu Spear";
			item.width = 50;
			item.height = 50;
			item.damage = 68;
			item.knockBack = 7f;
			item.rare = 9;
			item.value = 430000;
            item.toolTip = "Great spear made highly efficient against dragons.";
			item.UseSound = SoundID.Item1;
			item.useStyle = 5;
            item.useTime = 21; //4;
            item.useAnimation = 21; //13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("OmnirsHiRyuuSpear");
            item.shootSpeed = 2; //7;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (target.type == 87 || target.type == 88 || target.type == 89 || target.type == 90 || target.type == 170 || target.type == 171 || target.type == 370 /*|| (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsAncientDragon"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsAncientGreatDragon"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsHydra"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsTheWindFiendTiamat"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsTibianDragon"].type)) ||
                (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsTibianDragonLord"].type)) || (NPC.AnyNPCs(NPCDef.byName["OmnirsNosPak:OmnirsFabledWyvern"].type))*/) damage *= 3;
        }
    }
}