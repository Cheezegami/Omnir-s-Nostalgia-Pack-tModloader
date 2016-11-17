using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsSauronsGreaves : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Greaves of Sauron";
            item.width = 20;
            item.height = 20;
            AddTooltip("The great Maia of Craft forged these.");
            AddTooltip2("+25% Movement Speed, Fire Walking.");
            item.value = 15000000;
            item.rare = 10;
            item.defense = 25;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.25f;
            player.fireWalk = true;
        }
    }
}