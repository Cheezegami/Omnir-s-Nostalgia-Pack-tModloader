using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsGoldenGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Golden Leggings";
            item.width = 20;
            item.height = 20;
            AddTooltip("A lost prince's greaves");
            AddTooltip2("+10% movement.");
            item.value = 180000;
            item.rare = 8;
            item.defense = 9;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += .10f;
        }
    }
}