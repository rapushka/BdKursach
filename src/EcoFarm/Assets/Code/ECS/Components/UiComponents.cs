using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Code.ECS.Components
{
	[Game] [Event(Self)] public sealed class EnabledComponent : ValueComponent<bool> { }

	[Game] [Cleanup(RemoveComponent)] public sealed class ButtonClickComponent : FlagComponent { }

	[Game] public sealed class SellWindowComponent : FlagComponent { }

	[Game] public sealed class ShowOnInvokeComponent : FlagComponent { }
	
	[Game] public sealed class HideOnInvokeComponent : FlagComponent { }

	[Game] public sealed class ProcessedObjectComponent : ValueComponent<GameObject> { }

	[Game] public sealed class TargetActivityComponent : ValueComponent<bool> { }
}