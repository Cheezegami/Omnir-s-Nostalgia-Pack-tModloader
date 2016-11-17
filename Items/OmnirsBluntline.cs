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
	public class OmnirsBluntline : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Bluntline";
			item.width = 24;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 20;
			item.reuseDelay = 15;
			item.useStyle = 5;
			item.useSound = 5;
			item.useAmmo = 14; //14; arrows
			item.damage = 48;
			item.knockBack = 10;
			item.noMelee = true;
			item.ranged = true;
			item.autoReuse = true;
			item.value = 10000;
			item.rare = 6;
			item.shoot = 14; //14; arrows
			item.shootSpeed = 20;
		}
	}
}