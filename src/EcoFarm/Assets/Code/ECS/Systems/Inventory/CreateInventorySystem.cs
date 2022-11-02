﻿using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Inventory
{
	public sealed class CreateInventorySystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateInventorySystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Inventory"))
			            .Do((e) => e.AddAttachableIndex(e.creationIndex))
			            .Do((e) => e.isInventory = true)
			            .Do((e) => e.AddCoinsCount(0));
	}
}