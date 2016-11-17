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
	public class OmnirsFireSword : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Fire Sword";
			item.width = 32;
			item.height = 36;
			item.damage = 52;
			item.knockBack = 5.5f;
			item.rare = 4;
			item.value = 90000;
            item.toolTip = "The blade is a magic flame. \nSets enemies on fire";
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 15;
			item.useAnimation = 21;
			item.melee = true;
			item.autoReuse = true;
		}
        //public override void HoldItem(Player player)
        //{
        //    player.AddBuff(mod.BuffType("Firesoul"), 2);
        //}
	}
}