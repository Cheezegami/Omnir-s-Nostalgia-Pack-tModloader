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
	public class OmnirsImpHalberd : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Imp Halberd";
			item.width = 50;
			item.height = 50;
			item.damage = 60;
			item.knockBack = 7;
			item.rare = 8;
			item.value = 3500000;
            item.toolTip = "Crude crescent shaped fishing spear used by imps.";
            item.UseSound = SoundID.Item1;
			item.useStyle = 5;
			item.useTime = 26; //4;
			item.useAnimation = 26; //13;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("OmnirsImpHalberd");
            item.shootSpeed = 3;//7;
		}
	}
}