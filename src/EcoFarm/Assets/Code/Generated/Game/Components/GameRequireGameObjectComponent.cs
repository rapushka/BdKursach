//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.RequireGameObjectComponent requireGameObject { get { return (Code.ECS.Components.RequireGameObjectComponent)GetComponent(GameComponentsLookup.RequireGameObject); } }
    public bool hasRequireGameObject { get { return HasComponent(GameComponentsLookup.RequireGameObject); } }

    public void AddRequireGameObject(string newValue) {
        var index = GameComponentsLookup.RequireGameObject;
        var component = (Code.ECS.Components.RequireGameObjectComponent)CreateComponent(index, typeof(Code.ECS.Components.RequireGameObjectComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceRequireGameObject(string newValue) {
        var index = GameComponentsLookup.RequireGameObject;
        var component = (Code.ECS.Components.RequireGameObjectComponent)CreateComponent(index, typeof(Code.ECS.Components.RequireGameObjectComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveRequireGameObject() {
        RemoveComponent(GameComponentsLookup.RequireGameObject);
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

    static Entitas.IMatcher<GameEntity> _matcherRequireGameObject;

    public static Entitas.IMatcher<GameEntity> RequireGameObject {
        get {
            if (_matcherRequireGameObject == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RequireGameObject);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRequireGameObject = matcher;
            }

            return _matcherRequireGameObject;
        }
    }
}