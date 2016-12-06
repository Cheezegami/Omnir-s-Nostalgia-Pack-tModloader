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
    public class OmnirsFlameSabre : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Flame Saber";
			item.width = 36;
			item.height = 48;
			item.damage = 123;
			item.knockBack = 4.5f;
			item.scale = 1.1f;
            item.toolTip = "Randomly casts Fire 2.";
            item.shoot = mod.ProjectileType("OmnirsSpellFire2Ball");
			item.value = 1500000;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.useTime = 15;
			item.useAnimation = 12;
			item.melee = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            MPlayer p = (MPlayer)player.GetModPlayer(mod, "MPlayer");
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer, 1, mod.ProjectileType("Fire2"));
            return false;
        }
	}
}