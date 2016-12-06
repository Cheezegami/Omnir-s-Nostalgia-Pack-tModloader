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
	public class OmnirsKillerBow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Killer Bow";
			item.width = 16;
			item.height = 58;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.UseSound = SoundID.Item5;
			item.useAmmo = 14;
			item.damage = 40;
			item.knockBack = 3;
			item.noMelee = true;
			item.ranged = true;
			item.value = 8000;
			item.rare = 5;
			item.shoot = 14;
            item.shootSpeed = 10;//20;
		}
	}
}