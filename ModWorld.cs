using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TAPI;
using Terraria;

namespace LRPMod
{

	public class Modworld: ModWorld
	{
	
		public override void WorldGenModifyHardmodeTaskList(List<WorldGenTask> list)
		
		{
			list.Add(new WorldGenTask.Action("LRPMod:SoulIceGen", delegate
			{
				for (int amount = 0; amount < 2000; amount++)
				{
					int x = Main.rand.Next(0, 1000000);
					int y = Main.rand.Next(0, (int)Main.hellLayer);
					while (Main.tile[x,y].type == 161)
					{
						WorldGen.OreRunner(x, y, Main.rand.Next(4, 8), Main.rand.Next(4, 8), TileDef.byName["LRPMod:SoulIceTile"]);
					} 
				}
			}));
			
			list.Add(new WorldGenTask.Action("LRPMod:PinkSoulIceGen", delegate
			{
				for (int amount = 0; amount < 2000; amount++)
				{
					int x = Main.rand.Next(0, 1000000);
					int y = Main.rand.Next(0, (int)Main.hellLayer);
					while (Main.tile[x,y].type == 164)
					{
						WorldGen.OreRunner(x, y, Main.rand.Next(4, 8), Main.rand.Next(4, 8), TileDef.byName["LRPMod:PinkSoulIceTile"]);
					} 
				}
			}));
			
			list.Add(new WorldGenTask.Action("LRPMod:RedSoulIceGen", delegate
			{
				for (int amount = 0; amount < 2000; amount++)
				{
					int x = Main.rand.Next(0, 1000000);
					int y = Main.rand.Next(0, (int)Main.hellLayer);
					while (Main.tile[x,y].type == 200)
					{
						WorldGen.OreRunner(x, y, Main.rand.Next(4, 8), Main.rand.Next(4, 8), TileDef.byName["LRPMod:RedSoulIceTile"]);
					} 
				}
			}));
			
			list.Add(new WorldGenTask.Action("LRPMod:PurpleSoulIceGen", delegate
			{
				for (int amount = 0; amount < 2000; amount++)
				{
					int x = Main.rand.Next(0, 1000000);
					int y = Main.rand.Next(0, (int)Main.hellLayer);
					while (Main.tile[x,y].type == 163)
					{
						WorldGen.OreRunner(x, y, Main.rand.Next(4, 8), Main.rand.Next(4, 8), TileDef.byName["LRPMod:PurpleSoulIceTile"]);
					} 
				}
			}));
		}
		
	}
	
}