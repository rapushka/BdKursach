//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameEventSystems : Feature {

    public GameEventSystems(Contexts contexts) {
        Add(new CoinsCountEventSystem(contexts)); // priority: 0
        Add(new EnabledEventSystem(contexts)); // priority: 0
        Add(new InventoryItemEventSystem(contexts)); // priority: 0
        Add(new PositionEventSystem(contexts)); // priority: 0
        Add(new ProportionalScaleEventSystem(contexts)); // priority: 0
        Add(new SliderMaxValueEventSystem(contexts)); // priority: 0
        Add(new SliderValueEventSystem(contexts)); // priority: 0
        Add(new SpriteEventSystem(contexts)); // priority: 0
        Add(new TextEventSystem(contexts)); // priority: 0
        Add(new WateringEventSystem(contexts)); // priority: 0
    }
}
