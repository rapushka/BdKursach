using System.Collections.Generic;
using Code.ECS.Systems.Watering.Bucket;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Watering.Tree
{
	public sealed class CheckTreeUnderWateringSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public CheckTreeUnderWateringSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private Sprite TreeDrySprite => _contexts.GetConfiguration().Resource.Sprite.Tree.Dry;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Watering);

		private int MinWatering => _contexts.GetConfiguration().Balance.Tree.MinWatering;

		protected override bool Filter(GameEntity entity) => entity.hasWatering;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkAsDry, @if: IsOverWatered);

		private bool IsOverWatered(GameEntity entity) => entity.watering <= MinWatering;

		private void MarkAsDry(GameEntity entity)
			=> entity.TreeIsDead(TreeDrySprite);
	}
}