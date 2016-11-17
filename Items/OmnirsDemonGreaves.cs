using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDemonGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Demon Leggings";
            item.width = 20;
            item.height = 20;
            AddTooltip("A rare piece, indeed.");
            AddTooltip2("+25% movement, can walk on heated grounds.");
            item.value = 100000;
            item.rare = 9;
            item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.25f;
            player.fireWalk = true;
        }
    }
}