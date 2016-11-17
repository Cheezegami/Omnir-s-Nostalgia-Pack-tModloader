using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Buffs
{
    public class OmnirsBrassShield : ModBuff
	{
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Brass Shield";
            Main.buffTip[this.Type] = "Adds 18 to defense";
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 18;
        }
	}
}

