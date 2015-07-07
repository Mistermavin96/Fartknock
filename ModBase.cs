using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;

namespace LRPMod.Items
{
    public class Modbase : ModBase
    {
        public override void OnLoad()
        {
			
			
			//This is for the Grappling Hook to Amethyst Hook upgrade at the Anvil
            Recipe.newRecipe.createItem.SetDefaults(1236, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(84, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(181, false));
            Recipe.newRecipe.requiredItem[1].stack = 7;
            Recipe.newRecipe.requiredTile.Add(16);
            Recipe.AddRecipe();
			//This is for the Amethyst Hook to Topaz Hook upgrade at the Anvil
			Recipe.newRecipe.createItem.SetDefaults(1237, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1236, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(180, false));
            Recipe.newRecipe.requiredItem[1].stack = 7;
            Recipe.newRecipe.requiredTile.Add(16);
            Recipe.AddRecipe();
			//This is for the Topaz Hook to Sapphire Hook upgrade at the Anvil		
			Recipe.newRecipe.createItem.SetDefaults(1238, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1237, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(177, false));
            Recipe.newRecipe.requiredItem[1].stack = 7;
            Recipe.newRecipe.requiredTile.Add(16);
            Recipe.AddRecipe();
			//This is for the Sapphire Hook to Emerald Hook upgrade at the Anvil			
			Recipe.newRecipe.createItem.SetDefaults(1239, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1238, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(179, false));
            Recipe.newRecipe.requiredItem[1].stack = 7;
            Recipe.newRecipe.requiredTile.Add(16);
            Recipe.AddRecipe();
			//This is for the Emerald Hook to Ruby Hook upgrade at the Anvil
			Recipe.newRecipe.createItem.SetDefaults(1240, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1239, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(178, false));
            Recipe.newRecipe.requiredItem[1].stack = 7;
            Recipe.newRecipe.requiredTile.Add(16);
            Recipe.AddRecipe();			
			//This is for the Ruby Hook to Diamond Hook upgrade at the Anvil
			Recipe.newRecipe.createItem.SetDefaults(1241, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1240, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(182, false));
            Recipe.newRecipe.requiredItem[1].stack = 7;
            Recipe.newRecipe.requiredTile.Add(16);
            Recipe.AddRecipe();			
			
			
			//This is for the Amethyst Robe to Topaz Robe upgrade at the Loom
			Recipe.newRecipe.createItem.SetDefaults(1283, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1282, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(180, false));
            Recipe.newRecipe.requiredItem[1].stack = 5;
            Recipe.newRecipe.requiredTile.Add(86);
			Recipe.AddRecipe();
			//This is for the Topaz Robe to Sapphire Robe upgrade at the Loom
			Recipe.newRecipe.createItem.SetDefaults(1284, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1283, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(177, false));
            Recipe.newRecipe.requiredItem[1].stack = 5;
            Recipe.newRecipe.requiredTile.Add(86);
			Recipe.AddRecipe();
			//This is for the Sapphire Robe to Emerald Robe upgrade at the Loom
			Recipe.newRecipe.createItem.SetDefaults(1285, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1284, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(179, false));
            Recipe.newRecipe.requiredItem[1].stack = 5;
            Recipe.newRecipe.requiredTile.Add(86);
			Recipe.AddRecipe();
			//This is for the Emerald Robe to Ruby Robe upgrade at the Loom
			Recipe.newRecipe.createItem.SetDefaults(1286, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1285, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(178, false));
            Recipe.newRecipe.requiredItem[1].stack = 5;
            Recipe.newRecipe.requiredTile.Add(86);
			Recipe.AddRecipe();
			//This is for the Ruby Robe to Diamond Robe upgrade at the Loom
			Recipe.newRecipe.createItem.SetDefaults(1287, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1286, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(182, false));
            Recipe.newRecipe.requiredItem[1].stack = 5;
            Recipe.newRecipe.requiredTile.Add(86);
			Recipe.AddRecipe();
			
			
			//This is for the Coin Gun recipe at the Mythril Anvil
			Recipe.newRecipe.createItem.SetDefaults(905, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(533, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(324, false));
            Recipe.newRecipe.requiredItem[1].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(74, false));
            Recipe.newRecipe.requiredItem[2].stack = 2;
            Recipe.newRecipe.requiredTile.Add(134);
			Recipe.AddRecipe();
			//This is for the Gatligator recipe at the Mythril Anvil
			Recipe.newRecipe.createItem.SetDefaults(2270, false);
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(533, false));
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(324, false));
            Recipe.newRecipe.requiredItem[1].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(534, false));
            Recipe.newRecipe.requiredItem[2].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
			Recipe.AddRecipe();
			//This is for the The Axe recipe at the Mythril Anvil
            Recipe.newRecipe.createItem.SetDefaults(1305, false); //The Axe
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(204, false));//Molten Hamaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(217, false));//Meteor Hamaxe
            Recipe.newRecipe.requiredItem[1].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1507, false));//Spectre Hamaxe
            Recipe.newRecipe.requiredItem[2].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
			//This is for the Bananarang recipe at the Mythril Anvil
            Recipe.newRecipe.createItem.SetDefaults(1324, false);//Bananarangs
            Recipe.newRecipe.createItem.stack = 5;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(561, false)); //Light Discs
            Recipe.newRecipe.requiredItem[0].stack = 5;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1006, false)); //This is a placeholder for Choloroplasm Bars- Chlrophte Bars
            Recipe.newRecipe.requiredItem[1].stack = 10;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1508, false));//This is also a placeholder for Chloroplasm Bars- Ectoplasm
            Recipe.newRecipe.requiredItem[2].stack = 10;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1513, false));//Paladin's Hammer
            Recipe.newRecipe.requiredItem[3].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
			//This is for the Turtle upgrade from Chlorophte, this one is for the helmet
            Recipe.newRecipe.createItem.SetDefaults(1316, false);//Turtle Helmet
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1328, false));//Turtle Shell
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1001, false));//Chlorophyte Mask
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
			//This is for the Turtle upgrade from Chlorophte, this one is for the Scale Mail
            Recipe.newRecipe.createItem.SetDefaults(1317, false);//Turtle Scale Mail
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1328, false));//Turtle Shell
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1004, false));//Chlorophyte Plate Mail
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
			//This is for the Turtle upgrade from Chlorophte, this one is for the Leggings
            Recipe.newRecipe.createItem.SetDefaults(1318, false);//Turtle Leggings
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1328, false));//Turtle Shell
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1005, false));//Chlorophyte Greaves
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
			//This is for the Spectre upgrade from Chlorophte, this one is for the Hood
            Recipe.newRecipe.createItem.SetDefaults(1503, false);//Spectre Hood
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1508, false));//Ectoplasm
            Recipe.newRecipe.requiredItem[0].stack = 12;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1002, false));//Chlorophyte Helmet
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
			//This is for the Spectre upgrade from Chlorophte, this one is for the Robe
            Recipe.newRecipe.createItem.SetDefaults(1504, false);//Spectre Robe
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1508, false));//Ectoplasm
            Recipe.newRecipe.requiredItem[0].stack = 24;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1004, false));//Chlorophyte Plate Mail
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
			//This is for the Spectre upgrade from Chlorophte, this one is for the Pants
            Recipe.newRecipe.createItem.SetDefaults(1505, false);//Spectre Pants
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1508, false));//Ectoplasm
            Recipe.newRecipe.requiredItem[0].stack = 18;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1005, false));//Chlorophyte Greaves
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
			//This is for the Spectre upgrade from Chlorophte, this one is for the Mask
            Recipe.newRecipe.createItem.SetDefaults(2189, false);//Spectre Mask
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1508, false));//Ectoplasm
            Recipe.newRecipe.requiredItem[0].stack = 12;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1002, false));//Chlorophyte Helmet
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(134);
            Recipe.AddRecipe();
						//This is for the Shroomite upgrade from Chlorophte, this one is for the Headgear
            Recipe.newRecipe.createItem.SetDefaults(1546, false);//Shroomite Headgear
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(183, false));//Glowing Mushrooms
            Recipe.newRecipe.requiredItem[0].stack = 180;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1003, false));//Chlorophyte Headgear
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(247);
            Recipe.AddRecipe();
			//This is for the Shroomite upgrade from Chlorophte, this one is for the Mask
            Recipe.newRecipe.createItem.SetDefaults(1547, false);//Shroomite Mask
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(183, false));//Glowing Mushrooms
            Recipe.newRecipe.requiredItem[0].stack = 180;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1003, false));//Chlorophyte Headgear
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(247);
            Recipe.AddRecipe();
			//This is for the Shroomite upgrade from Chlorophte, this one is for the Helmet
            Recipe.newRecipe.createItem.SetDefaults(1548, false);//Shroomite Helmet
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(183, false));//Glowing Mushrooms
            Recipe.newRecipe.requiredItem[0].stack = 180;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1003, false));//Chlorophyte Headgear
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(247);
            Recipe.AddRecipe();
			//This is for the Shroomite upgrade from Chlorophte, this one is for the Breastplate
            Recipe.newRecipe.createItem.SetDefaults(1549, false);//Shroomite Breastplate
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(183, false));//Glowing Mushrooms
            Recipe.newRecipe.requiredItem[0].stack = 360;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1004, false));//Chlorophyte Plate Mail
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(247);
            Recipe.AddRecipe();
			//This is for the Shroomite upgrade from Chlorophte, this one is for the Mask
            Recipe.newRecipe.createItem.SetDefaults(1550, false);//Shroomtie Breastplate
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(183, false));//Glowing Mushrooms
            Recipe.newRecipe.requiredItem[0].stack = 270;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1005, false));//Chlorophyte Greaves
            Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(247);
            Recipe.AddRecipe();
			
			
			//This is the crafting for Copper to Tin
            Recipe.newRecipe.createItem.SetDefaults(703, false);//Tin Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Tin to Copper
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(703, false));//Tin Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
			Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Iron to Lead
            Recipe.newRecipe.createItem.SetDefaults(704, false);//Lead Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(22, false));//Iron Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Lead to Iron
            Recipe.newRecipe.createItem.SetDefaults(22, false);//Iron Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(704, false));//Laed Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Silver to Tungsten
            Recipe.newRecipe.createItem.SetDefaults(705, false);//Tungsten Bar
            Recipe.newRecipe.createItem.stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(21, false));//Silver Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Tungsten to Silver
            Recipe.newRecipe.createItem.SetDefaults(21, false);//Silver Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(705, false));//Tungsten Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Gold to Platinum
            Recipe.newRecipe.createItem.SetDefaults(706, false);//Platinum Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(19, false));//Gold Rar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Platinum to Gold
            Recipe.newRecipe.createItem.SetDefaults(19, false);//Gold Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(706, false));//Platinum Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Demonite to Crimtane
            Recipe.newRecipe.createItem.SetDefaults(1257, false);//Crimtane Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(57, false));//Demonite Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Crimtane to Demonite
            Recipe.newRecipe.createItem.SetDefaults(57, false);//Demonite Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1257, false));//Crimtane Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Copper to Tin
            Recipe.newRecipe.createItem.SetDefaults(703, false);//Tin Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Tin to Copper
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(703, false));//Tin Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
			Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Iron to Lead
            Recipe.newRecipe.createItem.SetDefaults(704, false);//Lead Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(22, false));//Iron Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Lead to Iron
            Recipe.newRecipe.createItem.SetDefaults(22, false);//Iron Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(704, false));//Laed Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Silver to Tungsten
            Recipe.newRecipe.createItem.SetDefaults(705, false);//Tungsten Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(21, false));//Silver Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Tungsten to Silver
            Recipe.newRecipe.createItem.SetDefaults(21, false);//Silver Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(705, false));//Tungsten Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Gold to Platinum
            Recipe.newRecipe.createItem.SetDefaults(706, false);//Platinum Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(19, false));//Gold Rar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Platinum to Gold
            Recipe.newRecipe.createItem.SetDefaults(19, false);//Gold Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(706, false));//Platinum Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Demonite to Crimtane
            Recipe.newRecipe.createItem.SetDefaults(1257, false);//Crimtane Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(57, false));//Demonite Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Crimtane to Demonite
            Recipe.newRecipe.createItem.SetDefaults(57, false);//Demonite Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1257, false));//Crimtane Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:AlchemyCatalyst"].type, false));//Alchemy Cat-A-List
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:AlchemyAnvilTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Cobalt to Palladium
            Recipe.newRecipe.createItem.SetDefaults(1184, false);//Palladium Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(381, false));//Cobalt Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:DarkMatter"].type, false));//Dark Matter
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Palladium to Cobalt
            Recipe.newRecipe.createItem.SetDefaults(381, false);//Cobalt Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1184, false));//Palladium Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:DarkMatter"].type, false));//Dark Matter
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Mythril to Orichalcum
            Recipe.newRecipe.createItem.SetDefaults(1191, false);//Orichalcum Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(382, false));//Mythril Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:DarkMatter"].type, false));//Dark Matter
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Orichalcum to Mythril
            Recipe.newRecipe.createItem.SetDefaults(382, false);//Mythril Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1191, false));//Orichalcum Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:DarkMatter"].type, false));//Dark Matter
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Adamantite to Titanium
            Recipe.newRecipe.createItem.SetDefaults(1198, false);//Titanium Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(391, false));// Adamantite Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:DarkMatter"].type, false));//Dark Matter
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			//This is the crafting for Titanium to Adamantite
            Recipe.newRecipe.createItem.SetDefaults(391, false);//Adamantite Bar
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(1198, false));//Titanium Bar
            Recipe.newRecipe.requiredItem[0].stack = 1;
			Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults( ItemDef.byName["LRPMod:DarkMatter"].type, false));//Dark Matter
			Recipe.newRecipe.requiredItem[1].stack = 1;
            Recipe.newRecipe.requiredTile.Add(TileDef.byName["LRPMod:PhilMetalStatTile"]);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Copper Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Shortsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Shortsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Broadsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Broadsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Hammer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Hammer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Watch
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Watch
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Chainmail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Chainmail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Copper Chandelier
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Copper Chandelier
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Amethyst Staff
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Copper Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Amethyst Staff
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Tin Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Shortsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Shortsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Broadsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Broadsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Hammer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Hammer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Watch
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Watch
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Chainmail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Chainmail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tin Chandelier
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tin Chandelier
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Topaz Staff
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tin Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Topaz Staff
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Iron Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Shortsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Shortsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Broadsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Broadsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Hammer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Hammer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Chainmail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Chainmail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Anvil
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Anvil
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Chain
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Chain
            Recipe.newRecipe.requiredItem[0].stack = 10;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Ancient Iron Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Ancient Iron Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Door
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Door
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Iron Fence
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Iron Fence
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Lead Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Shortsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Iron Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Shortsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Broadsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Broadsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Hammer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Hammer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Chainmail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Chainmail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Anvil
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Anvil
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Door
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Door
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Lead Fence
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Lead Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Lead Fence
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Silver Chandelier
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Chandelier
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Shortsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Shortsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Broadsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Broadsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Hammer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Hammer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Chainmail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Chainmail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Watch
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Watch
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Silver Bullet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Silver Bullet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Sapphire Staff
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Silver Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Sapphire Staff
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
		

			//This is the temporary Furnace smelting for Tungsten Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Shortsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Shortsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Broadsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Broadsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Hammer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Hammer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Watch
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Watch
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Chainmail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Chainmail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Tungsten Chandelier
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tungsten Chandelier
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Emerald Staff
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Tungsten Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Emerald Staff
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Gold Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Shortsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Shortsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Broadsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Broadsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Hammer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Hammer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Watch
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Watch
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Chainmail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Chainmail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Chandelier
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Chandelier
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Ruby Staff
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Ruby Staff
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Crown
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Crown
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Ancient Gold Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Ancient Gold Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Chest
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Chest
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Gold Key
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gold Key
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Chair
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Chair
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Toilet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Toilet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Door
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Door
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Table
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Table
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Bed
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Bed
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Lamp
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Lamp
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Bookcase
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Bookcase
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Chandelier
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Chandelier
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Lanturn
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Lanturn
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Candelabra
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Candelabra
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Candle
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Candle
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Grandfather Clock
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Grandfather Clock
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Piano
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Piano
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Dresser
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Dresser
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Sofa
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Sofa
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Golden Bathtub
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Golden Bathtub
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Throne
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Throne
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Candelabra
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Candelabra
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Candle
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Gold Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Candle
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Platinum Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Shortsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Shortsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Broadsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Broadsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Hammer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Hammer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Watch
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Watch
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Chainmail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Chainmail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Chandelier
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Chandelier
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Diamond Staff
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Diamond Staff
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Crown
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Crown
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Throne
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Throne
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Candelabra
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Candelabra
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Platinum Candle
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Platinum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Platinum Candle
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Demon Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Demon Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for War Axe Of The Night
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//War Axe Of The Night
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Light's Bane
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Light's Bane
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Fisher Of Souls
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Fisher Of Souls
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Shadow Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Shadow Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Shadow Scalemail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Shadow Scalemail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Shadow Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Shadow Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Nightmare Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Nightmare Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for The Breaker
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Demonite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//The Breaker
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			
			
			//This is the temporary Furnace smelting for Tendon Bow
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Tendon Bow
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Blood Lust Cluster
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Blood Lust Cluster
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Blood Butcherer
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Blood Butcherer
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Fleshcatcher
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Fleshcatcher
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Crimson Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Crimson Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Crimson Scalemail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Crimson Scalemail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Crimson Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Crimson Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Deathbringer Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimson Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Deathbringer Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Flesh Grinder
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Flesh Grinder
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for The Meatball
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Crimtane Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//The Meatball
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();						
			
			
			//This is the temporary Furnace smelting for Meteor Hamaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Meteor Hamaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Space Gun
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Space Gun
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Star Cannon
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Star Cannon
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Meteor Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Meteor Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Meteor Suit
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Meteor Suit
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Meteor Leggings
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Meteor Leggings
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Meteor Shot
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Meteor Shot
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Blue Phaseblade
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Blue Phaseblade
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Red Phaseblade
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Red Phaseblade
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Green Phaseblade
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Green Phaseblade
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();	
			//This is the temporary Furnace smelting for Purple Phaseblade
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Purple Phaseblade
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for White Phaseblade
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//White Phaseblade
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();
			//This is the temporary Furnace smelting for Yellow Phaseblade
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Meteorite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Yellow Phaseblade
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(17);
            Recipe.AddRecipe();	
			
			
			//This is the temporary Hell Forge smelting for Fiery Greatsword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Fiery Greatsword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Flamarang
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Flamarang
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Molten Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Molten Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Molten Breastplate
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Molten Breastplate
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Molten Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Molten Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Hellfire Arrows
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Hellfire Arrows
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Molten Fury
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Molten Fury
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Molten Hamaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Molten Hamaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Molten Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Molten Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Phoenix Blaster
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Phoenix Blaster
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Imp Staff
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hellstone Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Imp Staff
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			
			
			//This is the temporary Hell Forge smelting for Cobalt Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Mask
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Mask
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Hat
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Hat
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Cobalt Breastplate
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Breastplate
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Leggings
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Leggings
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Drill
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Drill
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Chainsaw
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Chainsaw
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Waraxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Waraxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Cobalt Repeater
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Repeater
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Sword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Sword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Cobalt Naginata
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Cobalt Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Cobalt Naginata
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			
			
			//This is the temporary Hell Forge smelting for Palladium Mask
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Mask
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Headgear
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Headgear
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Palladium Breastplate
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Breastplate
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Leggings
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Leggings
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Drill
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Drill
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Chainsaw
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Chainsaw
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Waraxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Waraxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Palladium Repeater
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Repeater
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Sword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Sword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Palladium Pike
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Palladium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Palladium Pike
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			
			//This is the temporary Hell Forge smelting for Mythril Anvil
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Anvil
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Hat
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Hat
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Hood
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Hood
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Mythril Breastplate
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Breastplate
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Leggings
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Leggings
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Drill
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Drill
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Chainsaw
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Chainsaw
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Waraxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Waraxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Mythril Repeater
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Repeater
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Sword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Sword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Mythril Halberd
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Mythril Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Mythril Halberd
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			
			
			//This is the temporary Hell Forge smelting for Orichalcum Anvil
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Anvil
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Mask
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Mask
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Headgear
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Headgear
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Orichalcum Breastplate
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Breastplate
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Leggings
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Leggings
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Drill
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Drill
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Chainsaw
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Chainsaw
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Waraxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Waraxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();	
			//This is the temporary Hell Forge smelting for Orichalcum Repeater
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Repeater
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Sword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Sword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			//This is the temporary Hell Forge smelting for Orichalcum Halberd
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Orichalcum Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Orichalcum Halberd
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(77);
            Recipe.AddRecipe();
			
			
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Headgear
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Headgear
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Mask
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Mask
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();	
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Breastplate
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Breastplate
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Leggings
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Leggings
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Drill
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Drill
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Chainsaw
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Chainsaw
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Waraxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Waraxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();	
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Repeater
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Repeater
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Sword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Sword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Adamantite Glaive
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Adamantite Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Adamantite Glaive
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			
			
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Mask
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Mask
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Headgear
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Headgear
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();	
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Breastplate
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Breastplate
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Leggings
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Leggings
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Drill
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Drill
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Pickaxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Pickaxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Chainsaw
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Chainsaw
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Waraxe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Waraxe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();	
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Repeater
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Repeater
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Sword
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Sword
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Titanium Trident
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Titanium Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Titanium Trident
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			
			
			//This is the temporary Adamantite/Titanium Forge smelting for Hallowed Mask
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Hallowed Mask
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Hallowed Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Hallowed Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Hallowed Headgear
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Hallowed Headgear
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();	
			//This is the temporary Adamantite/Titanium Forge smelting for Hallowed Plate Mail
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Hallowed Plate Mail
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Hallowed Greaves
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Hallowed Greaves
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Drax
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Drax
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Pickaxe Axe
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Pickaxe Axe
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Hallowed Repeater
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Hallowed Repeater
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Excalibur
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Excalibur
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();	
			//This is the temporary Adamantite/Titanium Forge smelting for Gungnir
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Gungnir
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Light Disc
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Light Disc
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Optic Staff
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Optic Staff
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Frost Helmet
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Frost Helmet
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();	
			//This is the temporary Adamantite/Titanium Forge smelting for Frost Breastplate
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Frost Breastplate
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Frost Leggings
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Frost Leggings
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
			//This is the temporary Adamantite/Titanium Forge smelting for Pumpkin Moon Medalion
            Recipe.newRecipe.createItem.SetDefaults(20, false);//Hallowed Bars
            Recipe.newRecipe.createItem.stack = 1;
            Recipe.newRecipe.requiredItem.Add(new Item().SetDefaults(20, false));//Pumpkin Moon Medalion
            Recipe.newRecipe.requiredItem[0].stack = 1;
            Recipe.newRecipe.requiredTile.Add(133);
            Recipe.AddRecipe();
        }
    }
}