using System;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.BalanceConfigs
{
	[Serializable]
	public class ResourceConfig : IResourceConfig
	{
		[field: SerializeField] public int MaxValue   { get; private set; } = 100;
		[field: SerializeField] public int StartValue { get; private set; } = 100;
		[field: SerializeField] public int RenewPrice { get; private set; } = 10;
	}
}