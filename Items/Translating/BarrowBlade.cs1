using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace DS.Items.Weapons
{
	public class BarrowBlade : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Barrow Blade";
			item.width = 32;
			item.height = 32;
			item.toolTip = "Wrought with spells of a fierce power.\nDispels the defensive shields of Artorias and the Witchking.";
			item.damage = 26;
			item.knockBack = 5;
			item.rare = 2;
			item.value = 140000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 21;
			item.melee = true;
			item.material = true;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			if(target.name.Contains("Witchking") || target.name.Contains("Artorias"))target.AddBuff(mod.BuffType("Vulnerable"), 10000, false);
		}
	}
}