using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Buffs
{
    public class OmnirsGreatShield : ModBuff
	{
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Great Shield";
            Main.buffTip[this.Type] = "Adds 84 to defense";
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 84;
        }
	}
}

