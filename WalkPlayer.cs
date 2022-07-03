using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Audio;
using WalkMod.Content.Buffs;

namespace WalkMod
{
    public class WalkPlayer : ModPlayer
    {
		public bool walk;
		public int walkSpeed = 3;
		public bool sprint;
		public int manaSprintInterval;
		public bool crawl;
		public bool sit;
		public bool lay;
		public int crawlTimer;
		public int restTimer;
		
		public static WalkPlayer ModPlayer(Player Player)
		{
			return Player.GetModPlayer<WalkPlayer>();
		}
		public override void PostUpdateRunSpeeds()
		{
			if (crawl)
			{
				Player.accRunSpeed *= 0.35f;
				Player.maxRunSpeed *= 0.35f;
			}
			if (sit)
			{
				Player.accRunSpeed *= 0f;
				Player.maxRunSpeed *= 0f;
			}
			if (lay)
			{
				Player.accRunSpeed *= 0f;
				Player.maxRunSpeed *= 0f;
			}
			if (walk)
			{
				if (WalkModConfig.Instance.enableMovementBugFix)
				{
					Player.velocity.X *= 0.95f;
				}
				if (walkSpeed <= 1)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed1;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed1;
				}
				else if (walkSpeed == 2)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed2;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed2;
				}
				else if (walkSpeed == 3)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed3;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed3;
				}
				else if (walkSpeed == 4)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed4;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed4;
				}
				else if (walkSpeed == 5)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed5;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed5;
				}
				else if (walkSpeed == 6)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed6;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed6;
				}
				else if (walkSpeed == 7)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed7;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed7;
				}
				else if (walkSpeed == 8)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed8;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed8;
				}
				else if (walkSpeed == 9)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed9;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed9;
				}
				else if (walkSpeed >= 10)
				{
					Player.accRunSpeed *= WalkModConfigClient.Instance.walkSpeed10;
					Player.maxRunSpeed *= WalkModConfigClient.Instance.walkSpeed10;
				}
			}
			if (sprint && !walk && WalkModConfig.Instance.enableSprint)
			{
				if (WalkModConfig.Instance.enableManaSprint)
				{
					if (Player.velocity.X >= 1f || Player.velocity.X <= -1f)
					{
						if (Player.statMana >= WalkModConfig.Instance.manaSprintMinimum)
						{
							manaSprintInterval -= 1;
							Player.accRunSpeed *= WalkModConfig.Instance.sprintSpeed;
							Player.maxRunSpeed *= WalkModConfig.Instance.sprintSpeed;
							if (manaSprintInterval <= 0)
							{
								manaSprintInterval = 5;
								Player.statMana -= WalkModConfig.Instance.manaSprintAmount;
							}
						}
					}
				}
				else
				{
					Player.accRunSpeed *= WalkModConfig.Instance.sprintSpeed;
					Player.maxRunSpeed *= WalkModConfig.Instance.sprintSpeed;
				}
			}
			
//Controls: Part 1
		//Toggle Walk
			if (WalkMod.WalkToggle.JustPressed)
			{
				walk = !walk;
				if (WalkModConfigClient.Instance.enableToggleSounds)
				{
					SoundEngine.PlaySound(SoundID.MenuTick);
				}
			}
		//Hold Walk
			if (WalkMod.WalkHold.Current)
			{
				walk = true;
			}
			if (WalkMod.WalkHold.JustReleased)
			{
				walk = false;
			}
		//Fast Walk
			if (WalkMod.WalkFast.JustPressed)
			{
				//walkFast = true;
				walkSpeed += WalkModConfigClient.Instance.walkFastSpeed;
			}
			if (WalkMod.WalkFast.JustReleased)
			{
				//walkFast = false;
				walkSpeed -= WalkModConfigClient.Instance.walkFastSpeed;
			}
		//Hold Run
			if (WalkMod.Run.Current)
			{
				walk = false;
			}
			if (WalkMod.Run.JustReleased)
			{
				walk = true;
			}
		//Hold Sprint
			if (WalkMod.Sprint.Current && !crawl)
			{
				sprint = true;
			}
			if (WalkMod.Sprint.JustReleased)
			{
				sprint = false;
			}
		//Change Walk Speed
			if (WalkMod.WalkModeFaster.JustPressed)
			{
				if (walkSpeed >= 10)
				{
					walkSpeed = 10;
				}
				else
				{
					walkSpeed += 1;
					if (WalkModConfigClient.Instance.enablePressSounds)
					{
						SoundEngine.PlaySound(SoundID.MenuTick);
					}
				}
			}
			if (WalkMod.WalkModeSlower.JustPressed)
			{
				if (walkSpeed <= 1)
				{
					walkSpeed = 1;
				}
				else
				{
					walkSpeed -= 1;
					if (WalkModConfigClient.Instance.enablePressSounds)
					{
						SoundEngine.PlaySound(SoundID.MenuTick);
					}
				}
			}
//End of Controls: Part 1
		}
		
		public override void PostUpdateMiscEffects()
		{
			if (lay)
			{
                Player.height = 20;
				Player.position.Y += Player.defaultHeight - Player.height; //This is here so the Player doesn't fly up into the sky when Laying Down.
				if (WalkModConfig.Instance.enableRestLay && restTimer <= WalkModConfig.Instance.restMax)
				{
					restTimer++;
				}
			}
			else if (restTimer > 0)
			{
				restTimer--;
			}
			if (restTimer >= WalkModConfig.Instance.restComfort1)
			{
				Player.AddBuff(ModContent.BuffType<Comfort1>(), WalkModConfig.Instance.comfort1Time);
			}
			if (restTimer >= WalkModConfig.Instance.restComfort2)
			{
				Player.AddBuff(ModContent.BuffType<Comfort2>(), WalkModConfig.Instance.comfort2Time);
			}
			if (crawl)
			{
                Player.height = 20;
				Player.position.Y += Player.defaultHeight - Player.height; //This is here so the Player doesn't fly up into the sky when Crawling.
			}
		}
		public override void PostUpdate() //Animations
		{
//Controls: Part 2
		//Toggle Crawl
			if (WalkMod.CrawlToggle.JustPressed && WalkModConfig.Instance.enableCrawl && !sit && !lay)
			{
				if (crawl) {Player.fullRotation = 0f;} //Why I put this here? It's to fix a bug with Player Rotation.
				crawl = !crawl;
				crawlTimer = 0;
				if (WalkModConfigClient.Instance.enableToggleSounds)
				{
					SoundEngine.PlaySound(SoundID.MenuTick);
				}
			}
			if (WalkMod.CrawlToggle.JustPressed && !WalkModConfig.Instance.enableCrawl && !sit && !lay)
			{
				if (crawl) {Player.fullRotation = 0f;} //Why I put this here? It's to fix a bug with Player Rotation.
				crawl = false;
			}
		//Toggle Sit
			/*if (WalkMod.SitToggle.JustPressed && !lay && !crawl)
			{
				sit = !sit;
				if (WalkModConfigClient.Instance.enableToggleSounds)
				{
					SoundEngine.PlaySound(SoundID.MenuTick);
				}
			}*/
		//Toggle Lay
			if (WalkMod.LayToggle.JustPressed && !sit && !crawl)
			{
				if (lay) {Player.fullRotation = 0f;} //Why I put this here? It's to fix a bug with Player Rotation.
				lay = !lay;
				if (WalkModConfigClient.Instance.enableToggleSounds)
				{
					SoundEngine.PlaySound(SoundID.MenuTick);
				}
			}
		//Getting Up
			if (lay && Player.controlJump)
			{
				{Player.fullRotation = 0f;} //Why I put this here? It's to fix a bug with Player Rotation.
				lay = false;
			}
//End of Controls: Part 2
			if (crawl)
			{
				if (Player.direction == 1)
				{
					Player.fullRotation = 1.58f;
				}
				else if (Player.direction == -1)
				{
					Player.fullRotation = -1.58f;
				}
				if (Player.controlLeft || Player.controlRight)
				{
					crawlTimer++;
				}
				if (crawlTimer >= 20)
				{
					Player.bodyFrame.Y = Player.bodyFrame.Height * 3;
					if (crawlTimer >= 40)
					{
						Player.bodyFrame.Y = Player.bodyFrame.Height * 4;
					}
					if (crawlTimer >= 60)
					{
						crawlTimer = 0;
					}
				}
				else
				{
					Player.bodyFrame.Y = Player.bodyFrame.Height * 2;
				}
				Player.fullRotationOrigin = new Vector2((float)Player.width/2,(float)Player.height*0.55f); //This is here to correct the Player's visual position.
			}
			if (lay)
			{
				if (Player.direction == 1)
				{
					Player.fullRotation = -1.58f;
				}
				else if (Player.direction == -1)
				{
					Player.fullRotation = 1.58f;
				}
				Player.bodyFrame.Y = Player.bodyFrame.Height * WalkModConfigClient.Instance.layBodyFrame;
				Player.legFrame.Y = Player.legFrame.Height * WalkModConfigClient.Instance.layLegFrame;
				Player.fullRotationOrigin = new Vector2((float)Player.width/2,(float)Player.height*0.55f); //This is here to correct the Player's visual position.
			}
			if (sit)
			{
				Player.legFrame.Y = Player.legFrame.Height * 6;
				Player.bodyFrame.Y = Player.bodyFrame.Height * 6;
			}
		}
    }
}