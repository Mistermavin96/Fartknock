using System;
using Terraria;
using TAPI;

namespace LRPMod.Buffs 
{

	public class FrostDevilBuff : ModBuff
	{
	
		public override void Start(Player player, int index)
		{
		
			player.buffTime[index] = 3600;
			
		}

		public override void MidUpdate(Player player)
		{
	
			bool flag = false;
		
			for(int k = 0; k < 1000; k++)
			{
		
				if(Main.projectile[k].active && Main.projectile[k].owner == player.whoAmI && Main.projectile[k].type == ProjDef.byName["LRPMod:FrostDevilProj"].type)
				{
			
					flag = true;
				
					break;
				
				}
			
			}
		
			LRPlayer modPlayer = player.GetSubClass<LRPlayer>();
		
			if(flag)
			{
		
				modPlayer.FrostDevilProj = true;
			
			}
		
			int type = BuffDef.byName["LRPMod:FrostDevilBuff"];
		
			int index = -1;
		
			for(int k = 0; k < player.maxBuffs; k++)
			{
		
				if(player.buffType[k] == type)
				{
			
					index = k;
				
					break;
				
				}
			
			}
		
			if(index < 0)
			{
		
				return;
			
			}
		
			if(!modPlayer.FrostDevilProj)
			{
		
				player.DelBuff(index);
			
			}
		
			else
			{
		
				player.buffTime[index] = 18000;
			
			}
		
		}

		public override void End(Player player, int index)
		{
	
			player.GetSubClass<LRPlayer>().FrostDevilProj = false;
		
		}
	
	}

}