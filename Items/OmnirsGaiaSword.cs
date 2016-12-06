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
    public class OmnirsGaiaSword : ModItem
	{
		public override void SetDefaults()
		{
            item.name = "Gaia Sword";
            item.width = 50;
            item.height = 50;
            item.damage = 105;
            item.knockBack = 6;
            item.scale = 1.1f;
            item.rare = 7;
            item.toolTip = "A blade that can make the earth tremble.";
            item.value = 170000;
            item.UseSound = SoundID.Item1;
            item.useStyle = 1;
            item.useTime = 15;
            item.useAnimation = 24;
            item.melee = true;
		}
	}
}