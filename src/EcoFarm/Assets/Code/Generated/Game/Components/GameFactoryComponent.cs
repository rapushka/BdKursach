//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.ECS.Components.FactoryComponent factory { get { return (Code.ECS.Components.FactoryComponent)GetComponent(GameComponentsLookup.Factory); } }
    public bool hasFactory { get { return HasComponent(GameComponentsLookup.Factory); } }

    public void AddFactory(EcoFarmModel.FactoryBuilding newValue) {
        var index = GameComponentsLookup.Factory;
        var component = (Code.ECS.Components.FactoryComponent)CreateComponent(index, typeof(Code.ECS.Components.FactoryComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceFactory(EcoFarmModel.FactoryBuilding newValue) {
        var index = GameComponentsLookup.Factory;
        var component = (Code.ECS.Components.FactoryComponent)CreateComponent(index, typeof(Code.ECS.Components.FactoryComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveFactory() {
        RemoveComponent(GameComponentsLookup.Factory);
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

    static Entitas.IMatcher<GameEntity> _matcherFactory;

    public static Entitas.IMatcher<GameEntity> Factory {
        get {
            if (_matcherFactory == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Factory);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherFactory = matcher;
            }

            return _matcherFactory;
        }
    }
}
