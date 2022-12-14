using Code.ECS.Systems.Inventory;
using Code.ECS.Systems.Inventory.SellDeal;

namespace Code.ECS.Features.Initialization
{
	public sealed class InventoryInitializationSystems : Feature
	{
		public InventoryInitializationSystems(Contexts contexts)
			: base(nameof(InventoryInitializationSystems))
		{
			Add(new CreateInventorySystem(contexts));
			Add(new CreateInventoryItemsSystem(contexts));
			Add(new MarkItemAsCoinsSystem(contexts));
			Add(new InitializeSellDealSystem(contexts));
		}
	}
}