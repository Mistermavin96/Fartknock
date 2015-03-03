using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace LRPMod.Projectiles.Ranged
{
    public class ChloroplasmProj : ModItem
    {
      

		public override void DamageNPC(Player owner, NPC npc, int hitDir, ref int damage, ref float knockback, ref bool crit, ref float critMult)
            {
                owner.statLife += (int)(damage *  0.1f);
            }
	}
}