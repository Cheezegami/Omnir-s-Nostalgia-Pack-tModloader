using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsRedLeggings : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Red Jacket";
            item.width = 20;
            item.height = 20;
            AddTooltip("Red Equipment made from the strongest leather.");
            AddTooltip2("20% chance not to consume ammo.");
            item.value = 9000000;
            item.rare = 10;
            item.defense = 14;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.1f;
            player.rangedDamage += 0.05f;
        }
    }
}