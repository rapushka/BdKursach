//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.Roslyn.CodeGeneration.Plugins.CleanupSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class PlayerCleanupSystems : Feature {

    public PlayerCleanupSystems(Contexts contexts) {
        Add(new DestroyDestroyPlayerSystem(contexts));
    }
}
