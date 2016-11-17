using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsHornedHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Horned Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "+10% critical chance.";
            AddTooltip2("Part of the Magic Plate set.");
			item.value = 8000000;
			item.rare = 10;
			item.defense = 11;
		}

        public override void UpdateEquip(Player player)
        {
            player.rangedCrit += 10;
            player.meleeCrit += 10;
            player.magicCrit += 10;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsMagicPlateArmor") && legs.type == mod.ItemType("OmnirsMagicPlateGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% damage, +80 mana";
            player.meleeDamage += 0.20f;
            player.magicDamage += 0.20f;
            player.rangedDamage += 0.20f;
            player.statManaMax2 += 80;
        }
	}
}