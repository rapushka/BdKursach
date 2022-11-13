﻿using System;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration.BalanceConfigs
{
	[Serializable]
	public class WateringConfig : IWateringConfig
	{
		[field: SerializeField] public float DroughtDuration { get; private set; } = 10f;
		[field: SerializeField] public int   DroughtStep     { get; private set; } = 1;
		[field: SerializeField] public int   WateringStep    { get; private set; } = 1;
	}
}