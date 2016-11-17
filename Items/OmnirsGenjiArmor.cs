using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsGenjiArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Genji Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("Armor from the East");
            AddTooltip2("+25% melee speed.");
            item.value = 1200000;
            item.rare = 7;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.25f;
        }
	}
}