using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsBardsTunicBottoms : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Bards Tunic Bottoms";
            item.width = 20;
            item.height = 20;
            AddTooltip("Tunic with ancient verse embroidered in its sleeves.");
            AddTooltip2("+3% movement, -7% mana cost.");
            item.value = 1000000;
            item.rare = 8;
            item.defense = 9;
        }
        public override void UpdateEquip(Player player)
        {
            player.manaCost -= 0.07f;
            player.moveSpeed += 0.03f;
        }
    }
}