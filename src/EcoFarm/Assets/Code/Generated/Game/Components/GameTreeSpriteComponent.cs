//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.TreeSpriteComponent treeSprite { get { return (Code.ECS.Components.TreeSpriteComponent)GetComponent(GameComponentsLookup.TreeSprite); } }
    public bool hasTreeSprite { get { return HasComponent(GameComponentsLookup.TreeSprite); } }

    public void AddTreeSprite(UnityEngine.Sprite newValue) {
        var index = GameComponentsLookup.TreeSprite;
        var component = (Code.ECS.Components.TreeSpriteComponent)CreateComponent(index, typeof(Code.ECS.Components.TreeSpriteComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTreeSprite(UnityEngine.Sprite newValue) {
        var index = GameComponentsLookup.TreeSprite;
        var component = (Code.ECS.Components.TreeSpriteComponent)CreateComponent(index, typeof(Code.ECS.Components.TreeSpriteComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTreeSprite() {
        RemoveComponent(GameComponentsLookup.TreeSprite);
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

    static Entitas.IMatcher<GameEntity> _matcherTreeSprite;

    public static Entitas.IMatcher<GameEntity> TreeSprite {
        get {
            if (_matcherTreeSprite == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TreeSprite);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTreeSprite = matcher;
            }

            return _matcherTreeSprite;
        }
    }
}