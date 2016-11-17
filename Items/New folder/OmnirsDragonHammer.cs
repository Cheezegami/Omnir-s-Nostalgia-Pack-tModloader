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
    public class OmnirsDragonHammer : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Dragon Hammer";
			item.width = 34;
			item.height = 34;
			item.damage = 48;
			item.knockBack = 4;
			item.scale = 1.25f;
			item.hammer = 100;
			item.rare = 4;
			item.value = 38000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 23;
			item.useAnimation = 28;
			item.melee = true;
		}
	}
}