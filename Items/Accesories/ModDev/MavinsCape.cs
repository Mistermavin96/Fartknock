using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TAPI;
using Terraria;
namespace LRPMod.Items
{

	public class MavinsCape : ModItem
	{
		
		public override void Effects(Player p)
		
		{
		
		p.drawGlow = true;
		p.dripping = true;
		
		}
		
	}
	
}