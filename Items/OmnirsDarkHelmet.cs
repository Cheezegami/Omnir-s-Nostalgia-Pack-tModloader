using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsDarkHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Dark Helmet";
			item.width = 20;
			item.height = 26;
			item.value = 160;
            AddTooltip("Can be used with the plate legs.");
			item.rare = 2;
			item.defense = 3;
		}
	}
}