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
	public class OmnirsGiantSword : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Giant Sword";
			item.width = 46;
			item.height = 46;
			item.damage = 97;
			item.knockBack = 10;
			item.scale = 1.25f;
			item.rare = 7;
			item.value = 170000;
            item.toolTip = "Has been forged by ancient giants.";
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 30;
			item.melee = true;
		}
	}
}