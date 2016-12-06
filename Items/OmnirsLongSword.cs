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
    public class OmnirsLongSword : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Long Sword";
			item.width = 34;
			item.height = 34;
			item.damage = 24;
			item.knockBack = 6;
			item.scale = 1.1f;
			item.value = 4500;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 15;
			item.useAnimation = 22;
			item.melee = true;
		}
	}
}