//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PlayerEntity {

    public Code.Global.LevelChoice.UnlockedLevelsCountComponent unlockedLevelsCount { get { return (Code.Global.LevelChoice.UnlockedLevelsCountComponent)GetComponent(PlayerComponentsLookup.UnlockedLevelsCount); } }
    public bool hasUnlockedLevelsCount { get { return HasComponent(PlayerComponentsLookup.UnlockedLevelsCount); } }

    public void AddUnlockedLevelsCount(int newValue) {
        var index = PlayerComponentsLookup.UnlockedLevelsCount;
        var component = (Code.Global.LevelChoice.UnlockedLevelsCountComponent)CreateComponent(index, typeof(Code.Global.LevelChoice.UnlockedLevelsCountComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceUnlockedLevelsCount(int newValue) {
        var index = PlayerComponentsLookup.UnlockedLevelsCount;
        var component = (Code.Global.LevelChoice.UnlockedLevelsCountComponent)CreateComponent(index, typeof(Code.Global.LevelChoice.UnlockedLevelsCountComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveUnlockedLevelsCount() {
        RemoveComponent(PlayerComponentsLookup.UnlockedLevelsCount);
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
public sealed partial class PlayerMatcher {

    static Entitas.IMatcher<PlayerEntity> _matcherUnlockedLevelsCount;

    public static Entitas.IMatcher<PlayerEntity> UnlockedLevelsCount {
        get {
            if (_matcherUnlockedLevelsCount == null) {
                var matcher = (Entitas.Matcher<PlayerEntity>)Entitas.Matcher<PlayerEntity>.AllOf(PlayerComponentsLookup.UnlockedLevelsCount);
                matcher.componentNames = PlayerComponentsLookup.componentNames;
                _matcherUnlockedLevelsCount = matcher;
            }

            return _matcherUnlockedLevelsCount;
        }
    }
}
