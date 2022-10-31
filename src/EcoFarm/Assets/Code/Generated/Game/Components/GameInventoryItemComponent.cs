//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.InventoryItemComponent inventoryItem { get { return (Code.ECS.Components.InventoryItemComponent)GetComponent(GameComponentsLookup.InventoryItem); } }
    public bool hasInventoryItem { get { return HasComponent(GameComponentsLookup.InventoryItem); } }

    public void AddInventoryItem(Code.ECS.Components.ComplexComponentTypes.Item newValue) {
        var index = GameComponentsLookup.InventoryItem;
        var component = (Code.ECS.Components.InventoryItemComponent)CreateComponent(index, typeof(Code.ECS.Components.InventoryItemComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceInventoryItem(Code.ECS.Components.ComplexComponentTypes.Item newValue) {
        var index = GameComponentsLookup.InventoryItem;
        var component = (Code.ECS.Components.InventoryItemComponent)CreateComponent(index, typeof(Code.ECS.Components.InventoryItemComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveInventoryItem() {
        RemoveComponent(GameComponentsLookup.InventoryItem);
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

    static Entitas.IMatcher<GameEntity> _matcherInventoryItem;

    public static Entitas.IMatcher<GameEntity> InventoryItem {
        get {
            if (_matcherInventoryItem == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InventoryItem);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInventoryItem = matcher;
            }

            return _matcherInventoryItem;
        }
    }
}