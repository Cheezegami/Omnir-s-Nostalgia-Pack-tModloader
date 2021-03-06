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
    public class OmnirsBloodLance : ModItem
	{
		public override void SetDefaults()
		{
            item.name = "Blood Lance";
			item.width = 50;
			item.height = 50;
			item.damage = 19;
			item.knockBack = 5;
			item.rare = 3;
			item.value = 15000;
            //item.toolTip = "Drains the enemy of their life.";
            item.UseSound = SoundID.Item1;
			item.useStyle = 5;
			item.useTime = 4;
			item.useAnimation = 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
            item.shoot = mod.ProjectileType("OmnirsBloodLance");
			item.shootSpeed = 7;
		}
	}
}