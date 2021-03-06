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
    public class OmnirsDiamondMace : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Diamond Mace";
			item.width = 36;
			item.height = 36;
			item.damage = 91;
			item.knockBack = 11;
			item.scale = 1.3f;
            item.toolTip = "A mace made of a large diamond.";
            item.hammer = 190;
			item.rare = 9;
			item.value = 1009000;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 26;
			item.useAnimation = 32;
			item.melee = true;
		}
	}
}