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
    public class OmnirsKaiserKnuckles : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Kaiser Knuckles";
			item.width = 21;
			item.height = 23;
			item.damage = 25;
			item.knockBack = 3;
			item.scale = 1;
            item.autoReuse = true;
            item.reuseDelay = 15;
            item.toolTip = "Great spiked knuckles";
            item.rare = 3;
			item.value = 100000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 8;
			item.melee = true;
            item.autoReuse = true;
        }
	}
}