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
    public class OmnirsRagnarok : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Ragnarok";
			item.width = 52;
			item.height = 52;
			item.damage = 145;
			item.knockBack = 10;
            item.rare = 8;
            item.scale = 1.3f;
			item.value = 4200000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 15;
			item.melee = true;
		}
	}
}