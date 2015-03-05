using Terraria;
using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TAPI;

namespace LRPMod.Items
{
public class CursedScythe : ModItem
    {
        public override void DamageNPC(Player owner, NPC npc, int hitDir, ref int damage, ref float knockback, ref bool crit, ref float critMult)
        {
            npc.AddBuff (39, 300, true); //first number is debuff ID, this time Cursed Inferno. Second number is frames it lasts, in this case, 5 seconds
		}

    }
}