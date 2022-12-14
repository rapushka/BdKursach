using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.CleanupMode;

namespace Code.ECS.Components
{
	[Game] [Cleanup(DestroyEntity)] public sealed class MouseClickComponent : ValueComponent<GameEntity> { }

	[Game] [Cleanup(RemoveComponent)] public sealed class MouseDownComponent : FlagComponent { }
	
	[Game] [Cleanup(RemoveComponent)] public sealed class MouseUpComponent : FlagComponent { }

	// Move to another file
	[Game] public sealed class DraggableComponent : FlagComponent { }

	[Game] public sealed class DraggingComponent : FlagComponent { }

	// Delete
	[Game] public sealed class DraggingStartComponent : ValueComponent<Vector2> { }
	
	[Game] public sealed class DraggingEndComponent : ValueComponent<Vector2> { }
}