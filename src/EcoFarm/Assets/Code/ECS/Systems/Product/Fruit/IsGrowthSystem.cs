﻿using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class IsGrowthSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public IsGrowthSystem(Contexts contexts) => _entities = contexts.game.GetGroup(GameMatcher.Growing);

		public void Execute() => _entities.ForEach(Check);

		private static void Check(GameEntity entity) => entity.Do(RemoveGrowing, @if: IsGrowth);

		private static void RemoveGrowing(GameEntity entity) => entity.RemoveGrowing();

		private static bool IsGrowth(GameEntity entity)
			=> entity.growing.Value.IsContains(entity.GetLocalScale()) == false;
	}
}