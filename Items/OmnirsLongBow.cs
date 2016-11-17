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
    public class OmnirsLongBow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Long Bow";
			item.width = 12;
			item.height = 28;
			item.useTime = 25;
			item.useAnimation = 25;
			item.reuseDelay = 15;
			item.useStyle = 5;
			item.useSound = 5;
			item.useAmmo = 14;
			item.damage = 16;
			item.knockBack = 4;
			item.noMelee = true;
			item.ranged = true;
			item.value = 400;
			item.rare = 1;
			item.shoot = 14;
			item.shootSpeed = 25;
		}
	}
}