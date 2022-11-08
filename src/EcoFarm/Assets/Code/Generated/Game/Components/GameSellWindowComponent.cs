//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.ECS.Components.SellWindowComponent sellWindowComponent = new Code.ECS.Components.SellWindowComponent();

    public bool isSellWindow {
        get { return HasComponent(GameComponentsLookup.SellWindow); }
        set {
            if (value != isSellWindow) {
                var index = GameComponentsLookup.SellWindow;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : sellWindowComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherSellWindow;

    public static Entitas.IMatcher<GameEntity> SellWindow {
        get {
            if (_matcherSellWindow == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SellWindow);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSellWindow = matcher;
            }

            return _matcherSellWindow;
        }
    }
}