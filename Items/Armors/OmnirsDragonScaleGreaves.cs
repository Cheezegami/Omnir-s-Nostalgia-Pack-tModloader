using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Armors
{
    public class OmnirsDragonScaleGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Dragon Scale Leggings";
            item.width = 20;
            item.height = 20;
            AddTooltip("Known to be treasured by dwarves.");
            AddTooltip2("+15% movement.");
            item.value = 4800000;
            item.rare = 9;
            item.defense = 10;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.15f;
        }
    }
}