using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Weapons.Hammers // Code modified from Zero-Exodus's code :)
{
    public class OmnirsClub : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Club";
			item.width = 32;
			item.height = 28;
			item.damage = 13;
			item.knockBack = 7;
			item.scale = 1;
			item.hammer = 25;
			item.value = 50;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 33;
            item.reuseDelay = 10;
			item.useAnimation = 27;
			item.melee = true;
            item.autoReuse = true;
		}
	}
}