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
    public class OmnirsDualHaken : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Dual Haken";
			item.width = 62;
			item.height = 62;
			item.damage = 122;
			item.knockBack = 7;
			item.scale = 1.2f;
			item.axe = 37;
			item.rare = 9;
			item.value = 1450000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 17;
			item.useAnimation = 32;
			item.melee = true;
            item.autoReuse = false;
		}
	}
}