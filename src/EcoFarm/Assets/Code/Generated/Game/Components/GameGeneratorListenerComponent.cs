//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GeneratorListenerComponent generatorListener { get { return (GeneratorListenerComponent)GetComponent(GameComponentsLookup.GeneratorListener); } }
    public bool hasGeneratorListener { get { return HasComponent(GameComponentsLookup.GeneratorListener); } }

    public void AddGeneratorListener(System.Collections.Generic.List<IGeneratorListener> newValue) {
        var index = GameComponentsLookup.GeneratorListener;
        var component = (GeneratorListenerComponent)CreateComponent(index, typeof(GeneratorListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGeneratorListener(System.Collections.Generic.List<IGeneratorListener> newValue) {
        var index = GameComponentsLookup.GeneratorListener;
        var component = (GeneratorListenerComponent)CreateComponent(index, typeof(GeneratorListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGeneratorListener() {
        RemoveComponent(GameComponentsLookup.GeneratorListener);
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

    static Entitas.IMatcher<GameEntity> _matcherGeneratorListener;

    public static Entitas.IMatcher<GameEntity> GeneratorListener {
        get {
            if (_matcherGeneratorListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GeneratorListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGeneratorListener = matcher;
            }

            return _matcherGeneratorListener;
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

    public void AddGeneratorListener(IGeneratorListener value) {
        var listeners = hasGeneratorListener
            ? generatorListener.value
            : new System.Collections.Generic.List<IGeneratorListener>();
        listeners.Add(value);
        ReplaceGeneratorListener(listeners);
    }

    public void RemoveGeneratorListener(IGeneratorListener value, bool removeComponentWhenEmpty = true) {
        var listeners = generatorListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGeneratorListener();
        } else {
            ReplaceGeneratorListener(listeners);
        }
    }
}
