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
    public class OmnirsKikuichimonji : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Kikuichimonji";
			item.width = 38;
			item.height = 52;
			item.damage = 35;
			item.knockBack = 4;
			item.scale = 1;
            item.toolTip = "It's scabbard is adorned with a chrysanthemum.";
            item.rare = 6;
			item.value = 38000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 15;
			item.melee = true;
		}
	}
}