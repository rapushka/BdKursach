//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class FactoryEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IFactoryListener> _listenerBuffer;

    public FactoryEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IFactoryListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.Factory)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasFactory && entity.hasFactoryListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.factory;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.factoryListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnFactory(e, component.Value);
            }
        }
    }
}
