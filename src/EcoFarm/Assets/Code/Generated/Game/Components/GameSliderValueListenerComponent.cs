//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SliderValueListenerComponent sliderValueListener { get { return (SliderValueListenerComponent)GetComponent(GameComponentsLookup.SliderValueListener); } }
    public bool hasSliderValueListener { get { return HasComponent(GameComponentsLookup.SliderValueListener); } }

    public void AddSliderValueListener(System.Collections.Generic.List<ISliderValueListener> newValue) {
        var index = GameComponentsLookup.SliderValueListener;
        var component = (SliderValueListenerComponent)CreateComponent(index, typeof(SliderValueListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSliderValueListener(System.Collections.Generic.List<ISliderValueListener> newValue) {
        var index = GameComponentsLookup.SliderValueListener;
        var component = (SliderValueListenerComponent)CreateComponent(index, typeof(SliderValueListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSliderValueListener() {
        RemoveComponent(GameComponentsLookup.SliderValueListener);
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

    static Entitas.IMatcher<GameEntity> _matcherSliderValueListener;

    public static Entitas.IMatcher<GameEntity> SliderValueListener {
        get {
            if (_matcherSliderValueListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SliderValueListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSliderValueListener = matcher;
            }

            return _matcherSliderValueListener;
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

    public void AddSliderValueListener(ISliderValueListener value) {
        var listeners = hasSliderValueListener
            ? sliderValueListener.value
            : new System.Collections.Generic.List<ISliderValueListener>();
        listeners.Add(value);
        ReplaceSliderValueListener(listeners);
    }

    public void RemoveSliderValueListener(ISliderValueListener value, bool removeComponentWhenEmpty = true) {
        var listeners = sliderValueListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveSliderValueListener();
        } else {
            ReplaceSliderValueListener(listeners);
        }
    }
}
