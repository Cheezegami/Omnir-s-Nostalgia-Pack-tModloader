using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsBlackRobeBottoms : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Black Robe Bottoms";
            item.width = 20;
            item.height = 20;
            AddTooltip("Robe made for those who use black magic.");
            AddTooltip2("+5% movement, -10% mana cost.");
            item.value = 7000000;
            item.rare = 10;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.manaCost -= 0.10f;
            player.moveSpeed += 0.05f;
        }
    }
}