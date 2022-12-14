using System;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.BalanceConfigs
{
	[Serializable]
	public class TreeConfig : ITreeConfig
	{
		[field: SerializeField] public int MinWatering     { get; private set; }
		[field: SerializeField] public int MaxWatering     { get; private set; } = 8;
		[field: SerializeField] public int InitialWatering { get; private set; } = 3;
	}
}