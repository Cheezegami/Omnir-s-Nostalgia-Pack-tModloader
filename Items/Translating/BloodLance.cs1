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
	public class BloodLance : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Blood Lance";
			item.width = 50;
			item.height = 50;
			item.damage = 33;
			item.knockBack = 6.5f;
			item.rare = 2;
			item.value = 15000;
			item.toolTip = "Pierces multiple times on every hit.";
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.material = true;
			item.shoot = mod.ProjectileType("BloodLance");
			item.shootSpeed = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DarkLance);
			recipe.AddIngredient(null, "DarkSoul", 6000);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}