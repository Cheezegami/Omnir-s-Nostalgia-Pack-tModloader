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
    public class OmnirsWarsingerBow : ModItem
	{
		public override void SetDefaults()
		{
            item.name = "Warsinger Bow";
			item.width = 12;
			item.height = 28;
			item.useTime = 25;
			item.useAnimation = 25;
			item.reuseDelay = 15;
			item.useStyle = 5;
			item.UseSound = SoundID.Item5;
			item.useAmmo = 14;
			item.damage = 80;
			item.knockBack = 4;
			item.noMelee = true;
			item.ranged = true;
			item.autoReuse = true;
			item.value = 50000;
			item.rare = 7;
			item.shoot = 14;
			item.shootSpeed = 20;
		}
	}
}