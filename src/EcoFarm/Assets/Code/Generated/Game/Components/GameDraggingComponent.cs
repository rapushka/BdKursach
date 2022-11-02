//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.DraggingComponent dragging { get { return (Code.ECS.Components.DraggingComponent)GetComponent(GameComponentsLookup.Dragging); } }
    public bool hasDragging { get { return HasComponent(GameComponentsLookup.Dragging); } }

    public void AddDragging(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.Dragging;
        var component = (Code.ECS.Components.DraggingComponent)CreateComponent(index, typeof(Code.ECS.Components.DraggingComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDragging(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.Dragging;
        var component = (Code.ECS.Components.DraggingComponent)CreateComponent(index, typeof(Code.ECS.Components.DraggingComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDragging() {
        RemoveComponent(GameComponentsLookup.Dragging);
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

    static Entitas.IMatcher<GameEntity> _matcherDragging;

    public static Entitas.IMatcher<GameEntity> Dragging {
        get {
            if (_matcherDragging == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Dragging);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDragging = matcher;
            }

            return _matcherDragging;
        }
    }
}
