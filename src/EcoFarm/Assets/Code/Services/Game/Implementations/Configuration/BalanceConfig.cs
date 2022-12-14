using System;
using Code.Services.Game.Implementations.Configuration.BalanceConfigs;
using Code.Services.Game.Interfaces.Config;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration
{
	[Serializable]
	public class BalanceConfig : IBalanceConfig
	{
		[SerializeField] private WateringConfig _watering;
		[SerializeField] private TreeConfig _tree;
		[SerializeField] private BucketConfig _bucket;
		[SerializeField] private WarehouseConfig _warehouse;
		[SerializeField] private FruitConfig _fruit;
		[SerializeField] private ResourceConfig _water;
		[SerializeField] private ResourceConfig _energy;
		[SerializeField] private FactoryConfig _factory;

		public IWateringConfig Watering => _watering;

		public ITreeConfig Tree => _tree;

		public IBucketConfig Bucket => _bucket;

		public IWarehouseConfig Warehouse => _warehouse;

		public IFruitConfig Fruit => _fruit;

		public IResourceConfig Water => _water;

		public IResourceConfig Energy => _energy;

		public IFactoryConfig Factory => _factory;
	}
}