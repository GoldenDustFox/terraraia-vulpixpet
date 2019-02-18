using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VulpixPet.Items
{
    public class VulpixEggAlola : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alolan Vulpix Egg");
            Tooltip.SetDefault("Summons an Alolan Vulpix to follow you.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LizardEgg);
            item.shoot = mod.ProjectileType<Projectiles.AlolaVulpixPet>();
            item.buffType = mod.BuffType<Buffs.AlolaVulpixBuff>();
            item.rare = -11;
            item.value = Item.sellPrice(gold: 1);
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}