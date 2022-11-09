//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class TextEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<ITextListener> _listenerBuffer;

    public TextEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<ITextListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.Text)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasText && entity.hasTextListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.text;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.textListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnText(e, component.Value);
            }
        }
    }
}