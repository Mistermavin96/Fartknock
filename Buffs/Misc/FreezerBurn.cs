using System;
using System.Collections.Generic;
using System.Text;

using Terraria;
using TAPI;

namespace LRPMod.Buffs.Misc
{
    public class FreezerBurn : ModBuff
    {
        
        public override void Effects(Player player, int index)
		{
			 player.AddBuff (39, 0, true);
			 player.AddBuff (44, 0, true);
		}
	}
}