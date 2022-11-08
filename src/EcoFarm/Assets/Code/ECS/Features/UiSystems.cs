﻿using Code.ECS.Systems.UI;

namespace Code.ECS.Features
{
	public sealed class UiSystems : Feature
	{
		public UiSystems(Contexts contexts)
			: base(nameof(UiSystems))
		{
			Add(new InitializeSellWindowSystem(contexts));
			Add(new InitializeSellButtonSystem(contexts));
			Add(new OnSellButtonClickSystem(contexts));
			Add(new OnToggleActivityButtonClickSystem(contexts));
		}
	}
}