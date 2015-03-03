using Terraria;
using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;

namespace LRPMod.Items
{
public class UnleashBlade : ModItem
    {
        public override void DamageNPC(Player owner, NPC npc, int hitDir, ref int damage, ref float knockback, ref bool crit, ref float critMult)
        {
            npc.AddBuff (39, 300, true); 
		}

    }
}