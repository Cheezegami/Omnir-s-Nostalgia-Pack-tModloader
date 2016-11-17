using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDemonHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Demon Helmet";
			item.width = 20;
			item.height = 26;
            item.toolTip = "You hear an evil whispering from inside.";
            AddTooltip2("+10% magic critical chance.");
			item.value = 2500000;
			item.rare = 8;
			item.defense = 10;
		}

        public override void UpdateEquip(Player player)
        {
            player.magicCrit += 10;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsDemonArmor") && legs.type == mod.ItemType("OmnirsDemonGreaves");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+5% magic damage, +60 mana";
            player.magicDamage += 0.5f;
            player.statManaMax2 += 60;
        }
	}
}