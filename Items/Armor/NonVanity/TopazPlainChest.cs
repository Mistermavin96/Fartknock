using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;  

namespace LRPMod.Items
{
    public class TopazPlainChest : ModItem
    {
        public override void Effects(Player p) 
        {
            p.meleeDamage += 0.06f
        }
		
		public override void ArmorSetBonus(Player p)
		{
			p.setBonus = "Topaz, the next best!";
			p.meleeSpeed += 0.06f
		}
    }
}