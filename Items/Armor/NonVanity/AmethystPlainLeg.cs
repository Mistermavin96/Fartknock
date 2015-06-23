using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;
using Terraria;  

namespace LRPMod.Items
{
    public class AmethystPlainLeg : ModItem
    {
        public override void Effects(Player p) 
        {
            p.meleeDamage += 0.05f
        }
    }
}