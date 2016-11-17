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
	public class PearlSpear : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Pearl Spear";
			item.width = 58;
			item.height = 58;
			item.damage = 52;
			item.knockBack = 7;
			item.rare = 4;
			item.value = 9000000;
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 1;
			item.useAnimation = 15;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("PearlSpear");
			item.shootSpeed = 7;
		}
	}
}