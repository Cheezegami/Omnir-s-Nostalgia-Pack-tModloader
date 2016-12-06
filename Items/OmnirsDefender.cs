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
    public class OmnirsDefender : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Defender";
			item.width = 48;
			item.height = 48;
			item.damage = 60;
			item.knockBack = 7;
			item.scale = 1;
			item.value = 190000;
item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 15;
			item.melee = true;
		}
	}
}