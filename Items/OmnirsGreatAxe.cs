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
    public class OmnirsGreatAxe : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Great Axe";
			item.width = 36;
			item.height = 36;
			item.damage = 42;
			item.knockBack = 9;
			item.scale = 1.1f;
			item.axe = 95;
			item.rare = 4;
			item.value = 14000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 28;
			item.melee = true;
		}
	}
}