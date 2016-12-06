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
    public class OmnirsTwoHandedSword : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Two Handed Sword";
			item.width = 50;
			item.height = 50;
			item.damage = 15;
			item.knockBack = 7;
			item.scale = 1.3f;
			item.rare = 2;
			item.value = 950;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 24;
			item.melee = true;
		}
	}
}