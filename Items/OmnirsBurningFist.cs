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
    public class OmnirsBurningFist : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Burning Fist";
			item.width = 22;
			item.height = 18;
			item.damage = 122;
			item.knockBack = 5;
			item.scale = 1;
            item.autoReuse = true;
            item.reuseDelay = 15;
            item.toolTip = "Randomly casts Fire 2.";
            item.shoot = mod.ProjectileType("OmnirsSpellFire2Ball");
			item.value = 3500000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 12;
			item.melee = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            //MPlayer p = (MPlayer)player.GetModPlayer(mod, "MPlayer");
            MPlayer p = new MPlayer();
            if (p.dualCast)
                Projectile.NewProjectile(position.X, position.Y - 20, speedX * .9f, speedY * .9f, type, damage, knockBack, Main.myPlayer, 1, mod.ProjectileType("OmnirsSpellFire2Ball"));
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer, 1, mod.ProjectileType("OmnirsSpellFire2Ball"));
            return false;
        }
	}
}