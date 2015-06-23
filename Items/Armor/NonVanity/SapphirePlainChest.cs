using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;  

namespace LRPMod.Items
{
    public class SapphirePlainChest : ModItem
    {
        public override void Effects(Player p) 
        {
            p.meleeDamage += 0.07f
        }
		
		public override void ArmorSetBonus(Player p)
		{
			p.setBonus = "Sapphire? Sapphire! YES!";
			p.meleeSpeed += 0.07f
		}
    }
}