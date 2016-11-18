using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OmnirsNosPak.Hostile
{
    public class OmnirsAncientDemon : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Ancient Demon";
			npc.displayName = "Ancient Demon";
			npc.width = 50;
			npc.height = 120;
			npc.damage = 100;
			npc.defense = 30;
			npc.lifeMax = 8200;
			npc.soundHit = 1;
			npc.soundKilled = 5;
			npc.value = 41000f;
			npc.npcSlots = 100;
			npc.knockBackResist = 0.1f;
			Main.npcFrameCount[npc.type] = 16;
			animationType = 28;
			npc.lavaImmune = true;
			npc.buffImmune[BuffID.Venom] = true;
			npc.buffImmune[BuffID.Confused] = true;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.OnFire] = true;
		}
		public override float CanSpawn(NPCSpawnInfo s) 
		{
			int x = s.spawnTileX;
			int y = s.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
			Player p = s.player;
			if(p.ZoneDungeon)return .5f;
			return 0f;
		}
		public void teleport(bool pre)
		{
			if (Main.netMode != 2)
			{
				Main.PlaySound(2, (int)npc.Center.X, (int)npc.Center.Y, 8);
				for (int m = 0; m < 25; m++)
				{
					int dustID = Dust.NewDust(npc.position, npc.width, npc.height, 6, 0, 0, 100, Color.White, 2f);
					Main.dust[dustID].noGravity = true;
					Main.dust[dustID].velocity = new Vector2(MathHelper.Lerp(-1f, 1f, (float)Main.rand.NextDouble()), MathHelper.Lerp(-1f, 1f, (float)Main.rand.NextDouble()));
					Main.dust[dustID].velocity *= 7f;
				}
			}
		}
		float spawnLimit = 0;
		public override void AI()  //  warrior ai
		{
			bool enraged = (npc.life < (float)npc.lifeMax*.2f);  //  speed up at low life
			int shotRate = enraged?100:70;
			float accel=enraged?.14f:.11f;  //  how fast it can speed up
			float topSpeed=enraged?6f:2f;  //  max walking speed, also affects jump length
			for (int j = 0; j < 2; j++)
			{
				int dustID = Dust.NewDust(npc.position, npc.width, npc.height, 6, npc.velocity.X * 0.025f, npc.velocity.Y * 0.025f, 100, default(Color), 2.2f);
				Main.dust[dustID].noGravity = true;
				Main.dust[dustID].velocity.Y--;
			}
			DSNPC.teleporterAI
			(
				npc, 
				ref npc.ai, 
				false, 		// immobile		Whether or not this NPC should move while its teleporting.
				20, 		// tpRadius		Radius around the player where the NPC will try to move.
				13,			// distToPlayer	Minimum distance to keep from the player as the NPC teleports.
				60,			// tpInterval	How often the NPC will try to teleport, tied to npc.ai[3].
				true, 		// aerial		Whether or not an NPC will try to move to an airborne position.
				teleport	// tpEffect		The effect that the NPC will create as it moves.
			);
			DSNPC.fighterAI
			(
				npc, 
				ref npc.ai,
				false,		// nocturnal  	If true, flees when it is daytime.
				true,		// focused 		If true, npc wont get interrupted when hit or confused.
				60, 		// boredom 		The amount of ticks until the npc gets 'bored' following a target.
				2, 			// knockPower 	0 == do not interact with doors, attempt to open the doors by this value, negative numbers will break instead
				accel, 		// accel 		The rate velocity X increases by when moving.
				topSpeed,	// topSpeed 	the maximum velocity on the X axis.
				2, 			// leapReq 		-1 npc wont jump over gaps, more than 0 npc will leap at players
				3, 			// leapSpeed	The max tiles it can jump across and over, horizontally. 
				4, 			// leapHeight 	The max tiles it can jump across and over, vertically. 
				100,		// leapRangeX 	The distance from a player before the npc initiates leap, horizontally. 
				50,			// leapRangeY 	The distance from a player before the npc initiates leap, vertically. 
				0, 			// shotType 	If higher than 0, allows an npc to fire a projectile, archer style.
				40,			// shotRate 	The rate of fire of the projectile, if there is one.
				70,			// shotPow 		The projectile's damage, if -1 it will use the projectile's default.
				14			// shotSpeed	The projectile's velocity.
			);
			if (npc.lavaWet) npc.velocity.Y-=2;
			float distance = npc.Distance(Main.player[npc.target].Center);
			if (distance < 600 && Main.netMode != 1 && !Main.player[npc.target].dead)
			{
				npc.localAI[3] += (Main.rand.Next(2, 5) * 0.1f) * npc.scale;
				if (npc.localAI[3] >= 10f)
				{
					npc.TargetClosest(true);
					if (spawnLimit < 7 && Main.rand.Next(3500)==1)
					{
						int spawn = NPC.NewNPC((int) npc.position.X+(npc.width/2), (int) npc.position.Y+(npc.height/2), 104, 0);
						Main.npc[spawn].velocity.Y = -8;
						Main.npc[spawn].velocity.X = Main.rand.Next(-10,10)/10;
						spawnLimit += 1f;
						if (Main.netMode == 2) NetMessage.SendData(23, -1, -1, "Werewolf", spawn, 0f, 0f, 0f, 0);
					}
					Vector2 angle = Main.player[npc.target].Center - npc.Center;
					angle.Y = angle.Y - (Math.Abs(angle.X)*.1f);
					angle.X += (float)Main.rand.Next(-20, 21);
					angle.Y += (float)Main.rand.Next(-20, 21);
					angle.Normalize();
					if ((angle.X < 0f && npc.velocity.X < 0f) || (angle.X > 0f && npc.velocity.X > 0f))
					{
						if (Main.rand.Next(1550)==1)
						{
							angle *= 26f;
							int damage = 50;
							int type = mod.ProjectileType("PoisonCrystalFire");
							int proj = Projectile.NewProjectile(npc.Center.X, npc.Center.Y-5, angle.X, angle.Y, type, damage, 0f, Main.myPlayer);
							Main.projectile[proj].timeLeft = 330;
							Main.projectile[proj].aiStyle=18;
							Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 0x11);
							npc.localAI[3] = 1f;
							npc.netUpdate=true;
						}
						if (Main.rand.Next(800)==1)
						{
							angle *= 8f;
							int damage = 100;
							int type = mod.ProjectileType("GreatEnergyBeam1");
							int proj = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, angle.X, angle.Y, type, damage, 0f, Main.myPlayer);
							Main.projectile[proj].timeLeft = 0;
							Main.projectile[proj].aiStyle=1;
							Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 0x11);
							npc.localAI[3] = 1f;
							npc.netUpdate=true;
						}
						if (Collision.CanHit(npc.position, npc.width, npc.height, Main.player[npc.target].position, Main.player[npc.target].width, Main.player[npc.target].height))
						{
							if (Main.rand.Next(70)==1)
							{
								angle *= 8f;
								int damage = 100;
								int type = mod.ProjectileType("FireBreath");
								int proj = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, angle.X, angle.Y, type, damage, 0f, Main.myPlayer);
								Main.projectile[proj].timeLeft = 100;
								Main.projectile[proj].aiStyle=23;
								Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 0x11);
								npc.localAI[3] = 1f;
								npc.netUpdate=true;
							}
							if (Main.rand.Next(200)==1)
							{
								angle *= 8f;
								int damage = 70;
								int type = mod.ProjectileType("GreatFireball1");
								int proj = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, angle.X, angle.Y, type, damage, 0f, Main.myPlayer);
								Main.projectile[proj].timeLeft = 100;
								Main.projectile[proj].aiStyle=23;
								Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 0x11);
								npc.localAI[3] = 1f;
								npc.netUpdate=true;
							}
							if (Main.rand.Next(150)==1)
							{
								angle *= 13f;
								int damage = 90;
								int type = mod.ProjectileType("BlackFire");
								int proj = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, angle.X, angle.Y, type, damage, 0f, Main.myPlayer);
								Main.projectile[proj].timeLeft = 400;
								Main.projectile[proj].aiStyle=23;
								Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 0x11);
								npc.localAI[3] = 1f;
								npc.netUpdate=true;
							}
							if (Main.rand.Next(140)==1)
							{
								angle *= 8f;
								int damage = 150;
								int type = mod.ProjectileType("GreatAttack");
								int proj = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, angle.X, angle.Y, type, damage, 0f, Main.myPlayer);
								Main.projectile[proj].timeLeft = 10;
								Main.projectile[proj].aiStyle=1;
								Main.PlaySound(2, (int) npc.position.X, (int) npc.position.Y, 0x11);
								npc.localAI[3] = 1f;
								npc.netUpdate=true;
							}
						}
					}
					if (npc.velocity.Y == 0f && Main.rand.Next(550) == 1)
					{
						Vector2 vector8 = new Vector2(npc.position.X + (npc.width * 0.5f), npc.position.Y + (npc.height / 2));
						float rotation = (float)Math.Atan2(vector8.Y - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), vector8.X - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
						npc.velocity.X = (float)(Math.Cos(rotation) * 7) * -1;
						npc.velocity.Y = (float)(Math.Sin(rotation) * 7) * -1;
						npc.localAI[3] = 1f;
						npc.netUpdate = true;
					}
				}
			}
		}
		public override void NPCLoot()
		{
            //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ADHead"), 1f);
            //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ADArm"), 1f);
            //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ADArm"), 1f);
            //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ADLeg"), 1f);
            //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ADLeg"), 1f);
				
            //DSNPC.DropItem(npc,mod.ItemType("DarkSoul"),40,100);
			
            //DSNPC.DropItem(npc,ItemID.IronskinPotion,1,100);
            //DSNPC.DropItem(npc,ItemID.ManaRegenerationPotion,1,100);
            //DSNPC.DropItem(npc,ItemID.ArcheryPotion,1,100);
			
            //DSNPC.DropItem(npc,mod.ItemType("PiercingPotion"),1,60);
            //DSNPC.DropItem(npc,mod.ItemType("FiresoulPotion"),1,60);
            //DSNPC.DropItem(npc,mod.ItemType("CrimsonPotion"),1,50);
            //DSNPC.DropItem(npc,mod.ItemType("StrengthPotion"),1,40);
            //DSNPC.DropItem(npc,mod.ItemType("BattlefrontPotion"),1,40);
            //DSNPC.DropItem(npc,mod.ItemType("AttractionPotion"),1,40);
            //DSNPC.DropItem(npc,mod.ItemType("ShockwavePotion"),1,20);
			
            //DSNPC.DropItem(npc,mod.ItemType("BandOfGreatCosmicPower"),1,10);
            //DSNPC.DropItem(npc,mod.ItemType("BarrierRing"),1,10);
            //DSNPC.DropItem(npc,mod.ItemType("EyeOfTheGods"),1,10);
		}
	}
}
