using System;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration
{
	[Serializable]
	public class BucketSpritesConfig : IBucketSpritesConfig
	{
		[field: SerializeField] public Sprite Empty  { get; private set; }
		[field: SerializeField] public Sprite Filled { get; private set; }
	}
}