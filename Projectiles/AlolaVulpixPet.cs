using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace VulpixPet.Projectiles
{
    public class AlolaVulpixPet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.PetLizard);
            aiType = ProjectileID.PetLizard;
            Main.projFrames[projectile.type] = 10;
            Main.projPet[projectile.type] = true;
            projectile.scale = 0.8f;
            projectile.width = 30;
            projectile.height = 49;
        }
 
        public override void AI()
        {
			Player player = Main.player[projectile.owner];
			VulpixPlayer modPlayer = player.GetModPlayer<VulpixPlayer>(mod);
            if (player.dead)
            {
                modPlayer.AlolaVulpixPet = false;
            }
            if (modPlayer.AlolaVulpixPet)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}