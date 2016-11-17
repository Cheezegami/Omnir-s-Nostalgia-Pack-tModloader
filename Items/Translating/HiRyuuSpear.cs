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
	public class HiRyuuSpear : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "HiRyuu Spear";
			item.width = 50;
			item.height = 50;
			item.damage = 78;
			item.knockBack = 7;
			item.rare = 5;
			item.value = 430000;
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 1;
			item.useAnimation = 15;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("HiRyuuSpear");
			item.shootSpeed = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteGlaive);
			recipe.AddIngredient(null, "DarkSoul", 45000);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}