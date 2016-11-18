using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OmnirsNosPak.Items
{
    public class OmnirsCrystalHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Crystal Full Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Dazzling armor cut from crystal";
            AddTooltip2("+25% critical chance.");
			item.value = 7000000;
			item.rare = 10;
			item.defense = 18;
		}

        public override void UpdateEquip(Player player)
        {
            player.meleeCrit += 20;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsCrystalArmor") && legs.type == mod.ItemType("OmnirsCrystalGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+30% melee damage";
            player.meleeDamage += 0.30f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OmnirsCrystalFullHelmet", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}