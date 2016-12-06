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
	public class OmnirsGuardianUltimaWeapon : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Guardian Ultima Weapon";
			item.width = 50;
			item.height = 50;
			item.damage = 100;
			item.knockBack = 15;
			item.rare = 10;
			item.value = 49999999;
			item.toolTip = "A sword that draws from the power of the wielder. Scales with current HP.";
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 30;
			item.useAnimation = 40;
			item.melee = true;
			item.autoReuse = true;
            item.scale = 2;
        }
		public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
		{
			damage = (player.statLife);
		}
	}
}