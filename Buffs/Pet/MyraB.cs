using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using TAPI;
using Terraria;

namespace LRPMod
{	
	public class MyraB : ModBuff
    {	

		public override void Effects(Player player, int index)
		{
			bool Spawned = false;
			for (int num36 = 0; num36 < 200; num36++)
			{
				if (Main.npc[num36].active && Main.npc[num36].type == NPCDef.byName["LRPMod:DorielleMyra"].type && Main.npc[num36].ai[0] == player.whoAmI)
				{
					Spawned = true;
				}
			}
			if (!Spawned)
			{
				int Aku_Aku = NPC.NewNPC((int) player.position.X+(player.width/2), (int) player.position.Y+(player.height/2), NPCDef.byName["LRPMod:DorielleMyra"].type, 0);
				Main.npc[Aku_Aku].ai[0] = player.whoAmI;
				Main.npc[Aku_Aku].netUpdate = true;
				if (Main.netMode == 2 && Aku_Aku < 200)
				{
					NetMessage.SendData(23, -1, -1, "", Aku_Aku, 0f, 0f, 0f, 0);
				}
			}
		}
	}
}