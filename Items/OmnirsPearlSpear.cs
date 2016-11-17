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
    public class OmnirsPearlSpear : ModItem
	{
		public override void SetDefaults()
		{
            item.name = "Pearl Spear";
			item.width = 50;
			item.height = 50;
			item.damage = 52;
			item.knockBack = 5;
			item.rare = 8;
			item.value = 2500000;
            //item.toolTip = "Drains the enemy of their life.";
			item.useSound = 1;
			item.useStyle = 5;
			item.useTime = 26;//4;
			item.useAnimation = 26;//13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
            item.shoot = mod.ProjectileType("OmnirsPearlSpear");
            item.shootSpeed = 2;// 7;
		}
	}
}