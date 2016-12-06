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
    public class OmnirsHammer : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Hammer";
			item.width = 38;
			item.height = 38;
			item.damage = 9;
			item.knockBack = 9;
			item.scale = 1;
			item.hammer = 50;
			item.value = 800;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 28;
			item.melee = true;
		}
	}
}