using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsGiantGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Giant Greaves";
            item.width = 20;
            item.height = 20;
            AddTooltip("Become unnnstopable");
            AddTooltip2("Adds 6% to melee damage");
            item.value = 100000;
            item.rare = 8;
            item.defense = 21;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.06f;
        }
    }
}