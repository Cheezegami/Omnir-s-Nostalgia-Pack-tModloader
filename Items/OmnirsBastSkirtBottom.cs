using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsBastSkirtBottom : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Bast Skirt";
            item.width = 18;
            item.height = 18;
            item.value = 150;
            item.rare = 3;
            item.defense = 1;
        }
    }
}