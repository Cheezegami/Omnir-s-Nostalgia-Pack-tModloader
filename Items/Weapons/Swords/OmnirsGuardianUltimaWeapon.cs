using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Weapons.Swords // Code modified from Zero-Exodus's code :)
{
	public class OmnirsGuardianUltimaWeapon : ModItem
	{
        public float damageMultiplier = 1f;
        public override void SetDefaults()
        {
            item.name = "Guardian Ultima Weapon";
            item.scale = 1.3f;
            item.width = 80;
            item.height = 80;
            item.damage = 80;
            item.knockBack = 15;
            item.rare = 10;
            item.value = 9999999;
            item.toolTip = "A sword that draws from the power of the wielder. Scales with current HP!";
            item.UseSound = SoundID.Item1;
            item.useStyle = 1;
            item.useTime = 30;
            item.useAnimation = 40;
            item.melee = true;
            item.autoReuse = true;

        }
        public override void UpdateInventory(Player player) // Updates the Sword's damage whenever it is in the inventory and dynamically adjusts damage based on modifiers and player hp.
        {
            HoldStats(player);
        }
        public override void HoldItem(Player player) // Syncs weapon damage when held in hand to prevent abuse.
        {
            HoldStats(player);
        }
        public void HoldStats(Player player) // Function to prevent double code in top two functions.
        {
            item.damage = (int)((float)(player.statLife * damageMultiplier));
            //item.scale = 0.65f + 0.6f * ((float)player.statLife / (float)player.statLifeMax2); Seems to mess with Cheat Sheet.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}