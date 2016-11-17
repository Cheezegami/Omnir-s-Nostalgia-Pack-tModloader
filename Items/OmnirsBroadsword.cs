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
	public class OmnirsBroadsword : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Broadsword";
			item.width = 44;
			item.height = 44;
			item.damage = 13;
			item.knockBack = 6;
			item.rare = 1;
			item.value = 500;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 16;
			item.melee = true;
		}
	}
}