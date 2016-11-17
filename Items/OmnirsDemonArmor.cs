using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDemonArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Demon Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("Given to those who brave Annihilation.");
            AddTooltip2("-15% mana cost.");
            item.value = 2000000;
            item.rare = 8;
            item.defense = 16;
        }

        public override void UpdateEquip(Player player)
        {
            player.manaCost -= 0.15f;
        }
	}
}