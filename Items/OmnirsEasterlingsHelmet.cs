using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsEasterlingsHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Helmet of the Easterlings";
			item.width = 20;
			item.height = 26;
            item.toolTip = "Enchanted helmet of the Easterlings.";
            AddTooltip2("Melee critical increased by 3%");
			item.value = 35000;
			item.rare = 2;
			item.defense = 5;
		}

        public override void UpdateEquip(Player player)
        {
            player.meleeCrit += 3;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsEasterlingsGreaves") && legs.type == mod.ItemType("OmnirsEasterlingsArmor");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+10% melee damage, 15% movement speed, Firewalking";
            player.moveSpeed += 0.15f;
            player.meleeDamage += 0.10f;
            player.fireWalk = true;
        }
	}
}