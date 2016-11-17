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
    public class OmnirsSabre : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Sabre";
			item.width = 34;
			item.height = 38;
			item.damage = 6;
			item.knockBack = 4;
			item.scale = 1;
			item.value = 90;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 13;
			item.melee = true;
		}
	}
}