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
    public class OmnirsKotetsu : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Kotetsu";
			item.width = 38;
			item.height = 40;
			item.damage = 43;
			item.knockBack = 4;
			item.scale = 1;
            item.autoReuse = true;
            item.reuseDelay = 15;
            item.rare = 4;
            item.value = 80000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 14;
			item.melee = true;
		}
	}
}