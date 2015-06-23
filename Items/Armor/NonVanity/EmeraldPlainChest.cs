using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;  

namespace LRPMod.Items
{
    public class EmeraldPlainChest : ModItem
    {
        public override void Effects(Player p) 
        {
            p.meleeDamage += 0.08f
        }
		
		public override void ArmorSetBonus(Player p)
		{
			p.setBonus = "Emerald, getting better all the time!";
			p.meleeSpeed += 0.08f
		}
    }
}