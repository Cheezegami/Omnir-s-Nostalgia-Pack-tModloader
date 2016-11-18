using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OmnirsNosPak.Items
{
    public class OmnirsScaleArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Scale Armor";
            item.width = 20;
            item.height = 20;
            item.value = 2080;
            item.rare = 1;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("OmnirsBrassHelmet") && legs.type == mod.ItemType("OmnirsBrassGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+3 Defense";
            player.statDefense += 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OmnirsRedesignedScaleArmor", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}