﻿using System.Collections.Generic;
using System.Linq;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using EcoFarmDataModule;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class ClickOnFactorySystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		private Dictionary<Product, int> _cash;

		public ClickOnFactorySystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private Dictionary<Product, int> AvailableProducts
			=> _contexts.game.GetInventoryItems()
			            .ToDictionary((i) => i.product.Value, (i) => i.inventoryItem.Value.Count);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Factory, MouseDown));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Handle);

		private void Handle(GameEntity entity)
			=> entity
			   .Do((e) => _cash = e.RequiredProducts())
			   .Do(TakeProducts, @if: IsEnoughOnWarehouse)
		/**/;

		private bool IsEnoughOnWarehouse(GameEntity factory)
			=> _cash.All((p) => AvailableProducts[p.Key] >= _cash[p.Key]);

		private void TakeProducts(GameEntity factory) => _cash.ForEach((p) => CreateRequest(p, factory));

		private void CreateRequest(KeyValuePair<Product, int> product, GameEntity factory)
		{
			_contexts.game.CreateEntity()
			         .Do((e) => e.AddRequireProduct(product.Key))
			         .Do((e) => e.AddPosition(factory.position))
			         .Do((e) => e.AddCount(product.Value))
			         .AttachTo(factory)
				;

			_contexts.game.GetInventoryItem(product.Key)
			         .DecreaseInventoryItemCount(product.Value);
		}
	}
}