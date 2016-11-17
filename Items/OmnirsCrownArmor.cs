using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsCrownArmor : ModItem
	{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Crown Armor";
            item.width = 20;
            item.height = 20;
            item.value = 96000;
            item.rare = 2;
            item.defense = 7;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("OmnirsCrownHelmet") && legs.type == mod.ItemType("OmnirsCrownGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+5% run speed, +3 defense";
            player.statDefense += 3;
            player.moveSpeed += 0.05f;
        }
	}
}