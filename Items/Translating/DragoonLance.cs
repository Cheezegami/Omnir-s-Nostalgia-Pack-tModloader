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
	public class DragoonLance : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Dragoon Lance";
			item.width = 50;
			item.height = 50;
			item.damage = 100;
			item.knockBack = 15f;
			item.rare = 5;
			item.value = 200000;
			item.toolTip = "A spear forged from the fang of the Dragoon Serpent.";
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 1;
			item.useAnimation = 11;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("DragoonLance");
			item.shootSpeed = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gungnir);
			recipe.AddIngredient(null, "GaeBolg", 3);
			recipe.AddIngredient(null, "SoulofAttraidies");
			recipe.AddIngredient(null, "DarkSoul", 80000);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}