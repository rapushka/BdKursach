//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.ECS.Components.ClearChildrensComponent clearChildrensComponent = new Code.ECS.Components.ClearChildrensComponent();

    public bool isClearChildrens {
        get { return HasComponent(GameComponentsLookup.ClearChildrens); }
        set {
            if (value != isClearChildrens) {
                var index = GameComponentsLookup.ClearChildrens;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : clearChildrensComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherClearChildrens;

    public static Entitas.IMatcher<GameEntity> ClearChildrens {
        get {
            if (_matcherClearChildrens == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ClearChildrens);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherClearChildrens = matcher;
            }

            return _matcherClearChildrens;
        }
    }
}
