//using VulpixPet.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace VulpixPet
{
	public class VulpixPlayer : ModPlayer
	{
	public bool AlolaVulpixPet = false;
	public bool KantoVulpixPet = false;
		public override void ResetEffects() {
			AlolaVulpixPet = false;
			KantoVulpixPet = false;
		}
	}
}