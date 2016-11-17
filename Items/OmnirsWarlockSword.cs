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
    public class OmnirsWarlockSword : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Warlock Sword";
			item.width = 48;
			item.height = 48;
			item.damage = 220;
			item.knockBack = 6;
			item.scale = 1;
			item.rare = 10;
			item.value = 9000000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 21;
			item.melee = true;
            item.autoReuse = true;
		}
	}
}