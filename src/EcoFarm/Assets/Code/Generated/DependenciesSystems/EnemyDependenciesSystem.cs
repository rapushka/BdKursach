//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EcoFarmCustomGenerator.CodeGeneration.Plugins.ResolveDependenciesSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using Entitas;

public sealed class ResolveEnemyDependenciesSystem : ReactiveSystem<GameEntity>
{
	public ResolveEnemyDependenciesSystem(Contexts contexts) : base(contexts.game) { }

	protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
		=> context.CreateCollector(GameMatcher.Enemy);

	protected override bool Filter(GameEntity entity) => true;

	protected override void Execute(List<GameEntity> entites)
	{
		foreach (var e in entites)
		{
			e.AddHealth(default);
			e.AddPosition(default);
			e.isMovable = true;
		}
	}
}