using Terraria;
using Terraria.ModLoader;
 
namespace VulpixPet.Buffs
{
    public class KantoVulpixBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Kantoian Vulpix");
            Description.SetDefault("A Vulpix from Kanto. It wants to keep you warm.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
 
		public override void Update(Player player, ref int buffIndex) {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<VulpixPlayer>(mod).KantoVulpixPet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType<Projectiles.KantoVulpixPet>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                int i = Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y, 0f, 0f, mod.ProjectileType<Projectiles.KantoVulpixPet>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}