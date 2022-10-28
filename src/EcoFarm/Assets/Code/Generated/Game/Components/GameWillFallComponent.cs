//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.ECS.Components.WillFallComponent willFallComponent = new Code.ECS.Components.WillFallComponent();

    public bool isWillFall {
        get { return HasComponent(GameComponentsLookup.WillFall); }
        set {
            if (value != isWillFall) {
                var index = GameComponentsLookup.WillFall;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : willFallComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherWillFall;

    public static Entitas.IMatcher<GameEntity> WillFall {
        get {
            if (_matcherWillFall == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WillFall);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWillFall = matcher;
            }

            return _matcherWillFall;
        }
    }
}
