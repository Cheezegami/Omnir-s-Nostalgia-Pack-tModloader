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
    public class OmnirsDemonRageSword : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Demon Rage Sword";
			item.width = 42;
			item.height = 42;
			item.damage = 99;
			item.knockBack = 7;
			item.scale = 1.3f;
			item.rare = 8;
			item.value = 1900000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 19;
			item.useAnimation = 29;
			item.melee = true;
		}
	}
}