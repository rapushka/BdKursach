﻿using Code.ECS.Features.Features;
using Code.Global.PlayerContexts.Systems;
using Code.Services.Interfaces;
using Code.Utils.Extensions.Entitas;

namespace Code.Global.PlayerContexts.Features
{
	public sealed class GlobalSystems : Feature
	{
		public GlobalSystems(IGlobalServices services)
		{
			var contexts = Contexts.sharedInstance;

			Add(new GlobalServicesRegistrationSystems(contexts, services));

			Add(new LoadPlayersSystem(contexts));
			Add(new InitializePlayerContextSystem(contexts));
			
			Add(new OnSessionEndSystem(contexts));

			Add(new PlayerEventSystems(contexts));
			Add(new PlayerCleanupSystems(contexts));

		}
		public void OnUpdate() => this.ExecuteAnd().Cleanup();
	}
}