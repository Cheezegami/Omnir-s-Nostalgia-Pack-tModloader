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
    public class OmnirsRapier : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Rapier";
			item.width = 40;
			item.height = 40;
			item.damage = 5;
			item.knockBack = 3;
			item.scale = 1;
			item.rare = 1;
			item.value = 200;
			item.useSound = 1;
			item.useStyle = 3;
			item.useTime = 15;
			item.useAnimation = 13;
			item.melee = true;
		}
	}
}