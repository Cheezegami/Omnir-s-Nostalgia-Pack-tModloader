using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsGrandCirclet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Grand Circlet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Headwear infused with magical power.";
            AddTooltip2("+20% magic critical chance.");
			item.value = 7000000;
			item.rare = 10;
			item.defense = 12;
		}

        public override void UpdateEquip(Player player)
        {
            player.magicCrit += 20;
            player.statManaMax2 += 100;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return (body.type == mod.ItemType("OmnirsBlackRobeTop") && legs.type == mod.ItemType("OmnirsBlackRobeBottoms"))
            || (body.type == mod.ItemType("OmnirsWhiteRobeTop") && legs.type == mod.ItemType("OmnirsWhiteRobeBottoms"));
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+25% magic damage";
            player.magicDamage += 0.25f;
        }
	}
}