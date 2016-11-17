using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDragoonArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Dragoon Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("Dragon armor that the Dragoons wear.");
            AddTooltip2("+20% melee speed.");
            item.value = 550000;
            item.rare = 5;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.setBonus = "+15% melee damage, +10 defense.";
            player.meleeDamage += 0.15f;
            player.statDefense += 10;
        }
	}
}