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
	public class OmnirsRadiantLance : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Radiant Lance";
			item.width = 50;
			item.height = 50;
			item.damage = 23;
			item.knockBack = 6.5f;
			item.rare = 3;
			item.value = 1500000;
            item.toolTip = "A light glows from this great spear.";
			item.useSound = 1;
			item.useStyle = 5;
            item.useTime = 26;// 4;
            item.useAnimation = 26;// 13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("OmnirsRadiantLance");
            item.shootSpeed = 2;// 7;
		}
	}
}