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
    public class OmnirsStoneCuttersAxe : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Stone Cutter's Axe";
			item.width = 48;
			item.height = 46;
			item.damage = 366;
			item.knockBack = 6;
			item.scale = 1;
			item.rare = 10;
			item.value = 9000000;
            item.toolTip = "You feel the power of this mighty axe.";
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 15;
			item.useAnimation = 21;
			item.melee = true;
            item.autoReuse = true;
		}
	}
}