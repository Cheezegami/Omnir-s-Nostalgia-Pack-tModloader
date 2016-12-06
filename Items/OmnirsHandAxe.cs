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
    public class OmnirsHandAxe : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Hand Axe";
			item.width = 32;
			item.height = 26;
			item.damage = 5;
			item.knockBack = 6;
			item.scale = 1;
			item.rare = 2;
			item.value = 800;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 13;
			item.melee = true;
		}
	}
}