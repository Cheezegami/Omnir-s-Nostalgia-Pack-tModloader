using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace OmnirsNosPak.Buffs
{
	public class OmnirsInvincible : ModBuff
	{
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Invincible";
            Main.buffTip[this.Type] = "You are invincible!";
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.immune = true;
		}
	}
}