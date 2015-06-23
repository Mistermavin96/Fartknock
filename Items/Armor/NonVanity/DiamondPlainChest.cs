using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;  

namespace LRPMod.Items
{
    public class DiamondPlainChest : ModItem
    {
        public override void Effects(Player p) 
        {
            p.meleeDamage += 0.10f
        }
		
		public override void ArmorSetBonus(Player p)
		{
			p.setBonus = "The best of the best! Diamond harder than penis!";
			p.meleeSpeed += 0.10f
		}
    }
}