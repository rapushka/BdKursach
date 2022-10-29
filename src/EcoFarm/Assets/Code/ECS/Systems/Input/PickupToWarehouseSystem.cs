﻿using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants.Balance.Warehouse;

namespace Code.ECS.Systems.Input
{
	public sealed class PickupToWarehouseSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public PickupToWarehouseSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private Vector2 WarehousePosition => _contexts.services.sceneObjectsService.Value.WarehouseSpawnPosition;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollectorAllOf(GameMatcher.Picked, GameMatcher.Position);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(StartMoving);

		private void StartMoving(GameEntity entity) => entity.Do((e) => e.AddTargetPosition(WarehousePosition))
		                                                     .Do((e) => e.AddDuration(PickupDuration));
	}
}