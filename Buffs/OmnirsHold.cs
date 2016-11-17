using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OmnirsNosPak.Buffs
{
	public class OmnirsHold : ModBuff
	{
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Hold Spell";
            Main.buffTip[this.Type] = "Jerk enemy cast spell that limits your momvent";
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.controlUp = false;
            player.controlDown = false;
            player.controlLeft = false;
            player.controlRight = false;
            player.controlJump = false;
            player.buffTime[buffIndex] = 3;
		}
	}
}

