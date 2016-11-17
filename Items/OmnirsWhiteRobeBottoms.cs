using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsWhiteRobeBottoms : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "White Robe Bottoms";
            item.width = 20;
            item.height = 20;
            AddTooltip("Robe made for those who use white magic.");
            AddTooltip2("+10% movement, -5% mana cost, fire walking.");
            item.value = 7000000;
            item.rare = 10;
            item.defense = 12;
        }

        public override void UpdateEquip(Player player)
        {
            player.manaCost -= 0.05f;
            player.moveSpeed += 0.10f;
            player.fireWalk = true;
        }
    }
}