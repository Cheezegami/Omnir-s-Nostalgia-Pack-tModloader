using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsCrystalGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Crystal Greaves";
            item.width = 20;
            item.height = 20;
            AddTooltip("Dazzling armor cut from crystal");
            AddTooltip2("+30% movement.");
            item.value = 7000000;
            item.rare = 10;
            item.defense = 18;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.3f;
        }
    }
}