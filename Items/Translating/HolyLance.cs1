using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace DS.Items.Weapons
{
	public class HolyLance : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Holy Lance";
			item.width = 50;
			item.height = 50;
			item.damage = 60;
			item.knockBack = 9.5f;
			item.rare = 5;
			item.value = 20000;
			item.toolTip = "Said to pierce any armor, even through walls.\nHits multiple times.";
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("HolyLance");
			item.shootSpeed = 8;
		}

	}
}