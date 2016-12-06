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
    public class OmnirsScimitar : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Scimitar";
			item.width = 42;
			item.height = 42;
			item.damage = 9;
			item.knockBack = 4;
			item.scale = 0.9f;
			item.rare = 1;
			item.value = 300;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 15;
			item.melee = true;
		}
	}
}