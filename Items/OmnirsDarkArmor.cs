using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDarkArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Dark Armor";
            item.width = 20;
            item.height = 20;
            AddTooltip("Can be used with the plate legs.");
            item.value = 12060;
            item.rare = 2;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("OmnirsDarkHelmet") && legs.type == mod.ItemType("OmnirsPlateGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+4 Defense";
            player.statDefense += 4;
        }
	}
}