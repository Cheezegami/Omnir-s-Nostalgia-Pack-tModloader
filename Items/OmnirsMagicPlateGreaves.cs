using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsMagicPlateGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Magic Plate Leggings";
            item.width = 20;
            item.height = 20;
            AddTooltip("The long forgotten greaves.");
            AddTooltip2("+20% movement.");
            item.value = 5000000;
            item.rare = 10;
            item.defense = 14;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.2f;
        }
    }
}