//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ProgressBarListenerComponent progressBarListener { get { return (ProgressBarListenerComponent)GetComponent(GameComponentsLookup.ProgressBarListener); } }
    public bool hasProgressBarListener { get { return HasComponent(GameComponentsLookup.ProgressBarListener); } }

    public void AddProgressBarListener(System.Collections.Generic.List<IProgressBarListener> newValue) {
        var index = GameComponentsLookup.ProgressBarListener;
        var component = (ProgressBarListenerComponent)CreateComponent(index, typeof(ProgressBarListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceProgressBarListener(System.Collections.Generic.List<IProgressBarListener> newValue) {
        var index = GameComponentsLookup.ProgressBarListener;
        var component = (ProgressBarListenerComponent)CreateComponent(index, typeof(ProgressBarListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveProgressBarListener() {
        RemoveComponent(GameComponentsLookup.ProgressBarListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherProgressBarListener;

    public static Entitas.IMatcher<GameEntity> ProgressBarListener {
        get {
            if (_matcherProgressBarListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ProgressBarListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherProgressBarListener = matcher;
            }

            return _matcherProgressBarListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddProgressBarListener(IProgressBarListener value) {
        var listeners = hasProgressBarListener
            ? progressBarListener.value
            : new System.Collections.Generic.List<IProgressBarListener>();
        listeners.Add(value);
        ReplaceProgressBarListener(listeners);
    }

    public void RemoveProgressBarListener(IProgressBarListener value, bool removeComponentWhenEmpty = true) {
        var listeners = progressBarListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveProgressBarListener();
        } else {
            ReplaceProgressBarListener(listeners);
        }
    }
}
