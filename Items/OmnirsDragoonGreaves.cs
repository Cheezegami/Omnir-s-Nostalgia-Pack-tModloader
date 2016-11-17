using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDragoonGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Dragoon Greaves";
            item.width = 20;
            item.height = 20;
            AddTooltip("Dragon armor that the Dragoons wear.");
            AddTooltip2("+20% movement.");
            item.value = 350000;
            item.rare = 5;
            item.defense = 8;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.15f;
        }
    }
}