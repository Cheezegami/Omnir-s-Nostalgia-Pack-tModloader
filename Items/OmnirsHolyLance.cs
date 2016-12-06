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
	public class OmnirsHolyLance : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Holy Lance";
			item.width = 50;
			item.height = 50;
			item.damage = 57;
			item.knockBack = 6.5f;
			item.rare = 9;
			item.value = 3800000;
            item.toolTip = "Bright Holy Spear.";
            item.UseSound = SoundID.Item1;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("OmnirsHolyLance");
			item.shootSpeed = 7;
		}
	}
}