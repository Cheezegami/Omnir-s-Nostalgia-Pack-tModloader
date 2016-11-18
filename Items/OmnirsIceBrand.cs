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
    public class OmnirsIceBrand : ModItem
	{
		public override void SetDefaults() 
		{
            item.name = "Ice Brand";
			item.width = 42;
			item.height = 42;
			item.damage = 72;
			item.knockBack = 5;
			item.scale = 1.05f;
            item.rare = 8;
            item.toolTip = "Randomly casts Ice 2.";
            item.shoot = mod.ProjectileType("OmnirsSpellIce2Ball");
			item.value = 2100000;
			item.useSound = 1;
			item.useStyle = 1;
			item.useTime = 15;
			item.useAnimation = 22;
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