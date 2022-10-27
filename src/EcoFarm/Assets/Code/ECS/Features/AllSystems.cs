﻿using Code.ECS.Systems.Product.Fruit;
using Code.ECS.Systems.Tree;
using Code.ECS.Systems.View;
using Code.Services.Interfaces;

namespace Code.ECS.Features
{
	public sealed class AllSystems : Feature
	{
		public AllSystems(IAllServices services)
			: base(nameof(AllSystems))
		{
			var contexts = Contexts.sharedInstance;
			Add(new ServicesRegistrationSystems(contexts, services));

			Add(new EmitPositionsForTreeSpawnSystem(contexts));
			Add(new SpawnTreeSystem(contexts));
			Add(new FruitSpawnSystem(contexts));
			Add(new SpawnBedsPlugsSystem(contexts));
			
			Add(new LoadViewForEntitySystem(contexts));
			Add(new StartGrowingSystem(contexts));
			
			Add(new GrowingSystem(contexts));
			Add(new IsGrowthSystem(contexts));
		}

		public void OnUpdate()
		{
			Execute();
			Cleanup();
		}
	}
}