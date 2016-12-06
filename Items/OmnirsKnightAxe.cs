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
    public class OmnirsKnightAxe : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Knight Axe";
			item.width = 32;
			item.height = 30;
			item.damage = 49;
			item.knockBack = 5;
			item.scale = 1;
			item.rare = 5;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 21;
			item.melee = true;
		}
	}
}