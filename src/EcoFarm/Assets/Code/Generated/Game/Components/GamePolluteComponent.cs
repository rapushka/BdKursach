//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.PolluteComponent pollute { get { return (Code.ECS.Components.PolluteComponent)GetComponent(GameComponentsLookup.Pollute); } }
    public bool hasPollute { get { return HasComponent(GameComponentsLookup.Pollute); } }

    public void AddPollute(int newValue) {
        var index = GameComponentsLookup.Pollute;
        var component = (Code.ECS.Components.PolluteComponent)CreateComponent(index, typeof(Code.ECS.Components.PolluteComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePollute(int newValue) {
        var index = GameComponentsLookup.Pollute;
        var component = (Code.ECS.Components.PolluteComponent)CreateComponent(index, typeof(Code.ECS.Components.PolluteComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePollute() {
        RemoveComponent(GameComponentsLookup.Pollute);
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

    static Entitas.IMatcher<GameEntity> _matcherPollute;

    public static Entitas.IMatcher<GameEntity> Pollute {
        get {
            if (_matcherPollute == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Pollute);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPollute = matcher;
            }

            return _matcherPollute;
        }
    }
}
