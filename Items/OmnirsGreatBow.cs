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
    public class OmnirsGreatBow : ModItem
	{
		public override void SetDefaults()
		{
            item.name = "Great Bow";
			item.width = 16;
			item.height = 58;
			item.useTime = 25;
			item.useAnimation = 25;
			item.reuseDelay = 15;
			item.useStyle = 5;
			item.useSound = 5;
			item.useAmmo = 14;
			item.damage = 25;
			item.knockBack = 5;
			item.noMelee = true;
			item.ranged = true;
			item.autoReuse = true;
			item.value = 18000;
			item.rare = 3;
			item.shoot = 14;
			item.shootSpeed = 8;
		}
	}
}