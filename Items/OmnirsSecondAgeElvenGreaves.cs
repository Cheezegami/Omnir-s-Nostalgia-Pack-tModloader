using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsSecondAgeElvenGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Elven Greaves of the Second Age";
            item.width = 20;
            item.height = 20;
            AddTooltip("Elven greaves present at Sauron's downfall.");
            AddTooltip2("Allows firewalking, +30% movement speed.");
            item.value = 500000;
            item.rare = 9;
            item.defense = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.3f;
            player.fireWalk = true;
        }
    }
}