//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GeneratorEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IGeneratorListener> _listenerBuffer;

    public GeneratorEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IGeneratorListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.Generator)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasGenerator && entity.hasGeneratorListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.generator;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.generatorListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnGenerator(e, component.Value);
            }
        }
    }
}
