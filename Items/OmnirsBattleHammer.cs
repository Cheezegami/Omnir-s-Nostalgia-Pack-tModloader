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
	public class OmnirsBattleHammer : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Battle Hammer";
			item.width = 38;
			item.height = 38;
			item.damage = 12;
			item.knockBack = 7;
			item.scale = 1;
			item.hammer = 55;
			item.rare = 2;
			item.value = 350;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 19;
			item.melee = true;
		}
	}
}