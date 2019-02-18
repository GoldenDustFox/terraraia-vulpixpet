using Terraria;
using Terraria.ModLoader;
 
namespace VulpixPet.Buffs
{
    public class AlolaVulpixBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Alolan Vulpix");
            Description.SetDefault("A Vulpix from Alola. It wants to be by your side.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
		public override void Update(Player player, ref int buffIndex) {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<VulpixPlayer>(mod).AlolaVulpixPet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType<Projectiles.AlolaVulpixPet>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
				int i = Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y, 0f, 0f, mod.ProjectileType<Projectiles.AlolaVulpixPet>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}