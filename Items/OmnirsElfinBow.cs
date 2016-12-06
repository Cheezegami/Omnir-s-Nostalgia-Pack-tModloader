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
	public class OmnirsElfinBow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Elfin Bow";
			item.width = 24;
			item.height = 60;
			item.useTime = 25;
			item.useAnimation = 25;
			item.reuseDelay = 15;
			item.useStyle = 5;
			item.UseSound = SoundID.Item5;
			item.useAmmo = 14;
			item.damage = 85;
			item.knockBack = 5;
			item.noMelee = true;
			item.ranged = true;
			item.autoReuse = true;
			item.value = 800000;
			item.rare = 7;
			item.shoot = 14;
			item.shootSpeed = 20;
		}
	}
}