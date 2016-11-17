using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDwarvenGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Dwarven Leggings";
            item.width = 20;
            item.height = 20;
            AddTooltip("Known to be treasured by dwarves.");
            AddTooltip2("+15% movement.");
            item.value = 24000;
            item.rare = 3;
            item.defense = 4;
        }
    }
}