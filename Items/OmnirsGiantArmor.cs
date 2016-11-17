using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
	public class OmnirsGiantArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Giant Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("Wut r u casul?!?1");
            AddTooltip2("Adds 8% to melee damage");
            item.value = 170000;
            item.rare = 8;
            item.defense = 22;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.08f;
        }
	}
}