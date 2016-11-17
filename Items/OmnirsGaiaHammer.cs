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
    public class OmnirsGaiaHammer : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Gaia Hammer";
			item.width = 50;
			item.height = 50;
			item.damage = 125;
			item.knockBack = 10;
			item.scale = 1.25f;
			item.hammer = 150;
			item.rare = 7;
            item.toolTip = "Enchanted with the power of the Earth.";
			item.value = 190000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 15;
			item.useAnimation = 30;
			item.melee = true;
		}
	}
}