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
	public class OmnirsWarhammer : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Warhammer";
			item.width = 38;
			item.height = 38;
			item.damage = 26;
			item.knockBack = 9;
			item.scale = 1.25f;
			item.hammer = 65;
			item.rare = 3;
			item.value = 100000;
			item.toolTip = "An old choice for advancing druids.";
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 20;
			item.useAnimation = 40;
			item.melee = true;
		}
	}
}