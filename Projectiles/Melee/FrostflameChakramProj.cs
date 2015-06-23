using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using TAPI;
using Terraria;
namespace LRPMod.Projectiles
{
    
	public class FrostflameChakramProj : ModProjectile
	{
		
		public override void AI()
		{
			projectile.light = 0.9f; //LIGHT!
			projectile.rotation += (float)projectile.direction * 0.8f; //ROTATIONS!
			int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, 36, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, default(Color), 0.75f); //DUST!
			Main.dust[DustID].noGravity = true;	//ANTIGRAVITY DUST!!
			
		}
		
		public override bool OnTileCollide(ref Vector2 velocityChange) //This is the part with bouncing
        {
		
            if (projectile.velocity.X != velocityChange.X)
            {
                projectile.velocity.X = -velocityChange.X/2;
            }
			
            if (projectile.velocity.Y != velocityChange.Y)
            {
                projectile.velocity.Y = -velocityChange.Y/2;
            }
			
            return false;
			
        }
		
		public override void DealtNPC(NPC n, int hitDir, int dmgDealt, float knockback, bool crit)
		{
			n.AddBuff (39, 420); 
			n.AddBuff (44, 420);
		}
		
	}
	
}