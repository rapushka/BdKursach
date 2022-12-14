using Code.ECS.Systems.Input;

namespace Code.ECS.Features.Updatables
{
	public sealed class InputSystems : Feature
	{
		public InputSystems(Contexts contexts)
			: base(nameof(InputSystems))
		{
			Add(new ClickAtPickableSystem(contexts));
			Add(new ClickAtDraggableSystem(contexts));

			Add(new ClickAtSignSystem(contexts));
		}
	}
}