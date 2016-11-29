using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items.Armors
{
    public class OmnirsBardsHood : ModItem
	{
        /// <summary>
        /// All the Armors are to be placed in the Armors Subfolder.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="texture"></param>
        /// <param name="equips"></param>
        /// <returns>Armors</returns>
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Bards Hood";
			item.width = 20;
			item.height = 26;
            item.toolTip = "+15% magic critical chance, +60 max mana.";
			item.value = 1000000;
			item.rare = 8;
			item.defense = 9;
		}

        public override void UpdateEquip(Player player)
        {
            player.magicCrit += 15;
            player.statManaMax2 += 60;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
            return body.type == mod.ItemType("OmnirsBardsTunicTop") && legs.type == mod.ItemType("OmnirsBardsTunicBottoms");
		}

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+15% magic damage";
            player.magicDamage += 0.15f;
        }
	}
}