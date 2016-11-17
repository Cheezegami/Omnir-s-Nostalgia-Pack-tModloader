using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsShellGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Shell Greaves";
            item.width = 20;
            item.height = 20;
            AddTooltip("Armor made from the shell of a legenadry creature.");
            AddTooltip2("+8% movement, +3% ranged damage.");
            item.value = 900000;
            item.rare = 7;
            item.defense = 10;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.08f;
            player.rangedDamage += 0.03f;
        }
    }
}