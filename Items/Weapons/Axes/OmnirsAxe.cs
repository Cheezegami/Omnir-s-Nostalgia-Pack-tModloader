using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Weapons.Axes // Code modified from Zero-Exodus's code :)
{
    public class OmnirsAxe : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Axe";
			item.width = 30;
			item.height = 30;
			item.damage = 16;
			item.knockBack = 4f;
			item.scale = 1;
			item.axe = 8; // Real axe power is this * 5
			item.value = 4500;
			item.useSound = 1;
			item.useStyle = 1;
            item.useTime = 28;
			item.useAnimation = 31;
			item.melee = true;
            item.autoReuse = true;
		}
	}
}