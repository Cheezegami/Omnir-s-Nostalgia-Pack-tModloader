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
    public class OmnirsMace : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Mace";
			item.width = 28;
			item.height = 28;
			item.damage = 8;
			item.knockBack = 7;
			item.scale = 0.8;
			item.rare = 1;
			item.value = 150;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 23;
			item.melee = true;
		}
	}
}