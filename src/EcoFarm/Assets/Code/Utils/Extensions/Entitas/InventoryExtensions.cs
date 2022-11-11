﻿using System;
using System.Collections.Generic;
using Code.ECS.Components.ComplexComponentTypes;
using EcoFarmDataModule;

namespace Code.Utils.Extensions.Entitas
{
	public static class InventoryExtensions
	{
		public static void SetActualDebugName(this GameEntity @this)
			=> @this.ReplaceDebugName(@this.inventoryItem.Value);

		private static void ReplaceDebugName(this GameEntity @this, Item item)
			=> @this.ReplaceDebugName($"Item: {item.Name} ({item.Count})");

		public static GameEntity CreateInventoryItem(this GameContext @this, Product product, int count)
			=> @this.CreateEntity()
			        .Do((e) => e.AddInventoryItem((product.Title, count)))
			        .Do((e) => e.SetActualDebugName())
			        .Do((e) => e.AddProduct(product))
			        .Do((e) => e.AddAttachedTo(@this.inventoryEntity.attachableIndex));

		public static IEnumerable<GameEntity> GetInventoryItems(this GameContext @this)
			=> @this.GetEntitiesWithAttachedTo(@this.inventoryEntity.attachableIndex);

		public static void UpdateInventoryItemCount(this GameEntity @this, Func<int, int> with)
		{
			var item = @this.inventoryItem.Value;
			item.Count = with(item.Count);
			@this.ReplaceInventoryItem(item);
			@this.SetActualDebugName();
		}

		public static void IncreaseCoinsCount(this GameEntity @this, int value)
			=> @this.ReplaceCoinsCount(@this.coinsCount + value);

		public static bool IsSameFruit(this GameEntity @this, GameEntity other)
			=> @this.product.Value == other.product.Value;
	}
}