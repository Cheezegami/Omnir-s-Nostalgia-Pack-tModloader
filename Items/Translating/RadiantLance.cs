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
	public class RadiantLance : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Radiant Lance";
			item.width = 52;
			item.height = 52;
			item.damage = 60;
			item.knockBack = 3;
			item.rare = 3;
			item.value = 1500000;
			item.toolTip = "A light glows from this great spear.";
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 1;
			item.useAnimation = 11;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("RadiantLance");
			item.shootSpeed = 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gungnir);
			recipe.AddIngredient(null, "DarkSoul", 30000);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}