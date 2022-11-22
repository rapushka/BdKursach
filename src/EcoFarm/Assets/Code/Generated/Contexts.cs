//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts : Entitas.IContexts {

    public static Contexts sharedInstance {
        get {
            if (_sharedInstance == null) {
                _sharedInstance = new Contexts();
            }

            return _sharedInstance;
        }
        set { _sharedInstance = value; }
    }

    static Contexts _sharedInstance;

    public GameContext game { get; set; }
    public InputContext input { get; set; }
    public PlayerContext player { get; set; }
    public ServicesContext services { get; set; }

    public Entitas.IContext[] allContexts { get { return new Entitas.IContext [] { game, input, player, services }; } }

    public Contexts() {
        game = new GameContext();
        input = new InputContext();
        player = new PlayerContext();
        services = new ServicesContext();

        var postConstructors = System.Linq.Enumerable.Where(
            GetType().GetMethods(),
            method => System.Attribute.IsDefined(method, typeof(Entitas.CodeGeneration.Attributes.PostConstructorAttribute))
        );

        foreach (var postConstructor in postConstructors) {
            postConstructor.Invoke(this, null);
        }
    }

    public void Reset() {
        var contexts = allContexts;
        for (int i = 0; i < contexts.Length; i++) {
            contexts[i].Reset();
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EntityIndexGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

    public const string AttachableIndex = "AttachableIndex";
    public const string AttachedTo = "AttachedTo";
    public const string Consumable = "Consumable";
    public const string Consumer = "Consumer";
    public const string ProduceResource = "ProduceResource";
    public const string Resource = "Resource";

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeEntityIndices() {
        game.AddEntityIndex(new Entitas.PrimaryEntityIndex<GameEntity, int>(
            AttachableIndex,
            game.GetGroup(GameMatcher.AttachableIndex),
            (e, c) => ((Code.ECS.Components.AttachableIndexComponent)c).Value));

        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, int>(
            AttachedTo,
            game.GetGroup(GameMatcher.AttachedTo),
            (e, c) => ((Code.ECS.Components.AttachedToComponent)c).Value));

        game.AddEntityIndex(new Entitas.PrimaryEntityIndex<GameEntity, int>(
            Consumable,
            game.GetGroup(GameMatcher.Consumable),
            (e, c) => ((Code.ECS.Components.ConsumableComponent)c).Value));

        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, int>(
            Consumer,
            game.GetGroup(GameMatcher.Consumer),
            (e, c) => ((Code.ECS.Components.ConsumerComponent)c).Value));

        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, int>(
            ProduceResource,
            game.GetGroup(GameMatcher.ProduceResource),
            (e, c) => ((Code.ECS.Components.ProduceResourceComponent)c).Value));

        game.AddEntityIndex(new Entitas.PrimaryEntityIndex<GameEntity, EcoFarmDataModule.Resource>(
            Resource,
            game.GetGroup(GameMatcher.Resource),
            (e, c) => ((Code.ECS.Components.ResourceComponent)c).Value));
    }
}

public static class ContextsExtensions {

    public static GameEntity GetEntityWithAttachableIndex(this GameContext context, int Value) {
        return ((Entitas.PrimaryEntityIndex<GameEntity, int>)context.GetEntityIndex(Contexts.AttachableIndex)).GetEntity(Value);
    }

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithAttachedTo(this GameContext context, int Value) {
        return ((Entitas.EntityIndex<GameEntity, int>)context.GetEntityIndex(Contexts.AttachedTo)).GetEntities(Value);
    }

    public static GameEntity GetEntityWithConsumable(this GameContext context, int Value) {
        return ((Entitas.PrimaryEntityIndex<GameEntity, int>)context.GetEntityIndex(Contexts.Consumable)).GetEntity(Value);
    }

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithConsumer(this GameContext context, int Value) {
        return ((Entitas.EntityIndex<GameEntity, int>)context.GetEntityIndex(Contexts.Consumer)).GetEntities(Value);
    }

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithProduceResource(this GameContext context, int Value) {
        return ((Entitas.EntityIndex<GameEntity, int>)context.GetEntityIndex(Contexts.ProduceResource)).GetEntities(Value);
    }

    public static GameEntity GetEntityWithResource(this GameContext context, EcoFarmDataModule.Resource Value) {
        return ((Entitas.PrimaryEntityIndex<GameEntity, EcoFarmDataModule.Resource>)context.GetEntityIndex(Contexts.Resource)).GetEntity(Value);
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.VisualDebugging.CodeGeneration.Plugins.ContextObserverGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

#if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeContextObservers() {
        try {
            CreateContextObserver(game);
            CreateContextObserver(input);
            CreateContextObserver(player);
            CreateContextObserver(services);
        } catch(System.Exception) {
        }
    }

    public void CreateContextObserver(Entitas.IContext context) {
        if (UnityEngine.Application.isPlaying) {
            var observer = new Entitas.VisualDebugging.Unity.ContextObserver(context);
            UnityEngine.Object.DontDestroyOnLoad(observer.gameObject);
        }
    }

#endif
}
