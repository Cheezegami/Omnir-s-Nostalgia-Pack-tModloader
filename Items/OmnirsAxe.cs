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
    public class OmnirsAxe : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Club";
			item.width = 30;
			item.height = 30;
			item.damage = 16;
			item.knockBack = 3;
			item.scale = 1;
			item.axe = 25;
			item.value = 4500;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 25;
			item.melee = true;
		}
	}
}