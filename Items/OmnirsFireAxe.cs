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
	public class OmnirsFireAxe : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Fire Axe";
			item.width = 40;
			item.height = 32;
			item.damage = 47;
			item.knockBack = 6;
			item.rare = 4;
			item.value = 98000;
            item.toolTip = "The blade is a magic flame.";
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 15;
			item.useAnimation = 29;
			item.melee = true;
		}
	}
}