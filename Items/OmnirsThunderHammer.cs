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
    public class OmnirsThunderHammer : ModItem
	{
		public override void SetDefaults() 
		{
			item.name = "Thunder Hammer";
			item.width = 28;
			item.height = 28;
			item.damage = 322;
			item.knockBack = 10;
			item.scale = 1.25f;
			item.hammer = 200;
			item.rare = 10;
			item.value = 1000000;
			item.toolTip = "Said to be blessed";
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 17;
			item.useAnimation = 17;
			item.melee = true;
            item.autoReuse = true;
		}
	}
}