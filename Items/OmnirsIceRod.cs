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
    public class OmnirsIceRod : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Ice Rod";
			item.width = 26;
			item.height = 26;
			item.damage = 20;
			item.knockBack = 7;
			item.scale = 1;
            item.toolTip = "Randomly casts Ice 2.";
            item.shoot = mod.ProjectileType("OmnirsSpellIce2Ball");
			item.value = 450000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 21;
			item.useAnimation = 27;
			item.melee = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            MPlayer p = (MPlayer)player.GetModPlayer(mod, "MPlayer");
            if (p.dualCast)
                Projectile.NewProjectile(position.X, position.Y - 20, speedX * .9f, speedY * .9f, type, damage, knockBack, Main.myPlayer, 1, mod.ProjectileType("OmnirsSpellIce2Ball"));
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer, 1, mod.ProjectileType("OmnirsSpellIce2Ball"));
            return false;
        }
	}
}