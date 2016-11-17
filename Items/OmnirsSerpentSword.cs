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
	public class OmnirsSerpentSword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Serpent Sword";
			item.width = 38;
			item.height = 38;
			item.damage = 26;
			item.knockBack = 5;
			item.rare = 4;
			item.value = 6800;
            //item.toolTip = "Has a chance to poison the enemy";
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 15;
			item.useAnimation = 21;
			item.melee = true;
		}
	}
}