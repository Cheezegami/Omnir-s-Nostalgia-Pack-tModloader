using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsEasterlingsGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Greaves of the Easterlings";
            item.width = 20;
            item.height = 20;
            AddTooltip("Enchanted armor of the Easterlings.");
            AddTooltip2("+2% Movement Speed.");
            item.value = 35000;
            item.rare = 2;
            item.defense = 5;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.02f;
        }
    }
}