using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Weapons.Bows // Code modified from Zero-Exodus's code :)
{
	public class OmnirsArtemisBow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Artemis Bow";
			item.width = 24;
			item.height = 60;
			item.toolTip = "A beautiful bow said to be the Moon-goddess'.";
			item.useTime = 20;
			item.useAnimation = 20;
			item.reuseDelay = 15;
			item.useStyle = 5;
			item.UseSound = SoundID.Item5;
			item.useAmmo = 14;
			item.damage = 400;
			item.knockBack = 19;
			item.noMelee = true;
			item.ranged = true;
			item.autoReuse = true;
			item.value = 41000000;
			item.rare = 10;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.shootSpeed = 20;
		}
	}
}