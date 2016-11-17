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
    public class OmnirsDragoonLance : ModItem
	{
		public override void SetDefaults()
		{
            item.name = "Dragoon Lance";
			item.width = 50;
			item.height = 50;
			item.damage = 145;
			item.knockBack = 6.5f;
			item.rare = 8;
			item.value = 210000;
            item.toolTip = "A spear forged of metal and wyrmscale.";
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
            item.shoot = mod.ProjectileType("OmnirsDragoonLance");
			item.shootSpeed = 7;
		}
	}
}