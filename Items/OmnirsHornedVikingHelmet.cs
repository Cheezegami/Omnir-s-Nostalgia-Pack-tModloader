using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace OmnirsNosPak.Items
{
    public class OmnirsHornedVikingHelmet : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
            item.name = "Horned Viking Helmet";
			item.width = 20;
			item.height = 26;
            AddTooltip("Can be used with the chain armor and legs.");
			item.value = 1500;
			item.rare = 1;
			item.defense = 2;
		}
	}
}