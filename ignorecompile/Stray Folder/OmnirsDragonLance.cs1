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
	public class OmnirsDragonLance : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Dragon Lance";
			item.width = 50;
			item.height = 50;
			item.damage = 23;
			item.knockBack = 6.5f;
			item.rare = 3;
			item.value = 4500;
            item.toolTip = "Said to pierce any armor, but proven to be false.";
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("OmnirsDragonLance");
			item.shootSpeed = 7;
		}
	}
}