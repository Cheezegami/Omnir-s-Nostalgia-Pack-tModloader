using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Weapons.Axes
{
    public class OmnirsBattleAxe : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Battle Axe";
			item.width = 30;
			item.height = 44;
			item.damage = 27;
			item.knockBack = 7;
			item.scale = 1;
			item.axe = 10;
			item.rare = 2;
			item.value = 6500;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 25;
			item.useAnimation = 28;
			item.melee = true;
            item.autoReuse = true;
		}
	}
}