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
	public class Longinus : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Longinus";
			item.width = 50;
			item.height = 50;
			item.damage = 200;
			item.knockBack = 9f;
			item.rare = 5;
			item.value = 1880000;
			item.toolTip = "Legendary spear fabled to hold sway over the world.\nIncreases attack damage by 50% when falling.";
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 1;
			item.useAnimation = 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("Longinus");
			item.shootSpeed = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gungnir);
			recipe.AddIngredient(null, "GuardianSoul", 3);
			recipe.AddIngredient(null, "SoulofAttraidies");
			recipe.AddIngredient(null, "DarkSoul", 160000);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}