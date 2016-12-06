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
    public class OmnirsHalberd : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Halberd";
			item.width = 60;
			item.height = 60;
			item.damage = 17;
			item.knockBack = 6.5f;
			item.rare = 3;
			item.value = 4000;
			item.UseSound = SoundID.Item1;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("OmnirsHalberd");
			item.shootSpeed = 7;
		}
	}
}