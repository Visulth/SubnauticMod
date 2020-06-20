using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SubnauticMod.Content.Items.Accessories {

	[AutoloadEquip(EquipType.Back)]
	public class OxygenTank2 : OxygenTank {

		public OxygenTank2() {
			oxygenCapacityIncrease = 400;
			displayName = $"High Capacity {SubnauticMod.O2} Tank";
			toolTip = "Increases Oxygen significantly";
			value = 1000;
			rarity = ItemRarityID.Green;
		}

	}
}
