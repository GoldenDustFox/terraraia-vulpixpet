using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VulpixPet.NPCs
{
    public class VanillaNPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:

                    if (Main.hardMode)
                    {}
                    else
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("VulpixEggKanto"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("VulpixEggAlola"));
                        nextSlot++;
                    }

                    break;
            }
        }
    }
}