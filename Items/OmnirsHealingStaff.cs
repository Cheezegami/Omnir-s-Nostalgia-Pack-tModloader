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
    public class OmnirsHealingStaff : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Healing Staff";
			item.width = 46;
			item.height = 44;
			item.damage = 80;
			item.knockBack = 4;
			item.scale = 1;
            item.toolTip = "Randomly casts Heal 2.";
            item.shoot = mod.ProjectileType("OmnirsSpellHeal2Ball");
			item.value = 9600000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 21;
			item.melee = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            MPlayer p = (MPlayer)player.GetModPlayer(mod, "MPlayer");
            if (p.dualCast)
                Projectile.NewProjectile(position.X, position.Y - 20, speedX * .9f, speedY * .9f, type, damage, knockBack, Main.myPlayer, 1, mod.ProjectileType("OmnirsSpellHeal2Ball"));
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer, 1, mod.ProjectileType("OmnirsSpellHeal2Ball"));
            return false;
        }
	}
}