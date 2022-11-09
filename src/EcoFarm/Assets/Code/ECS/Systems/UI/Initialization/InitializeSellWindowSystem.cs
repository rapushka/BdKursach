﻿using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI.Initialization
{
	public sealed class InitializeSellWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeSellWindowSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("SellWindow"))
			            .Do((e) => e.AddEnabled(false))
			            .Do((e) => e.AddView(UI.WindowSell.gameObject))
			            .Do((e) => e.AddSellWindow(UI.WindowSell))
			            .Do((e) => e.AddAttachableIndex(e.creationIndex))
			            .Do((e) => e.isRequirePreparation = true);
	}
}