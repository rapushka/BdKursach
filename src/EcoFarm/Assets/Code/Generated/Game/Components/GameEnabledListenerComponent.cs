//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EnabledListenerComponent enabledListener { get { return (EnabledListenerComponent)GetComponent(GameComponentsLookup.EnabledListener); } }
    public bool hasEnabledListener { get { return HasComponent(GameComponentsLookup.EnabledListener); } }

    public void AddEnabledListener(System.Collections.Generic.List<IEnabledListener> newValue) {
        var index = GameComponentsLookup.EnabledListener;
        var component = (EnabledListenerComponent)CreateComponent(index, typeof(EnabledListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEnabledListener(System.Collections.Generic.List<IEnabledListener> newValue) {
        var index = GameComponentsLookup.EnabledListener;
        var component = (EnabledListenerComponent)CreateComponent(index, typeof(EnabledListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEnabledListener() {
        RemoveComponent(GameComponentsLookup.EnabledListener);
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

    static Entitas.IMatcher<GameEntity> _matcherEnabledListener;

    public static Entitas.IMatcher<GameEntity> EnabledListener {
        get {
            if (_matcherEnabledListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EnabledListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEnabledListener = matcher;
            }

            return _matcherEnabledListener;
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

    public void AddEnabledListener(IEnabledListener value) {
        var listeners = hasEnabledListener
            ? enabledListener.value
            : new System.Collections.Generic.List<IEnabledListener>();
        listeners.Add(value);
        ReplaceEnabledListener(listeners);
    }

    public void RemoveEnabledListener(IEnabledListener value, bool removeComponentWhenEmpty = true) {
        var listeners = enabledListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveEnabledListener();
        } else {
            ReplaceEnabledListener(listeners);
        }
    }
}