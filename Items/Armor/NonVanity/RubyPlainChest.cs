using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;  

namespace LRPMod.Items
{
    public class RubyPlainChest : ModItem
    {
        public override void Effects(Player p) 
        {
            p.meleeDamage += 0.09f
        }
		
		public override void ArmorSetBonus(Player p)
		{
			p.setBonus = "Ruby, quite good? Quite!";
			p.meleeSpeed += 0.09f
		}
    }
}