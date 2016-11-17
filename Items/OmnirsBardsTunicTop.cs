using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsBardsTunicTop : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Bards Tunic Top";
            item.width = 20;
            item.height = 20;
            AddTooltip("Tunic with ancient verse embroidered in its sleeves.");
            AddTooltip2("-12% mana cost, +5% magic damage.");
            item.value = 1000000;
            item.rare = 8;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.manaCost -= 0.12f;
            player.magicDamage += 0.05f;
        }
	}
}