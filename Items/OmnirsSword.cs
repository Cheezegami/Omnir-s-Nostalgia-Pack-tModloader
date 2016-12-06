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
    public class OmnirsSword : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Sword";
			item.width = 44;
			item.height = 44;
			item.damage = 7;
			item.knockBack = 5;
			item.scale = 1;
			item.rare = 1;
			item.value = 170;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 17;
			item.melee = true;
		}
	}
}