//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServicesContext {

    public ServicesEntity storageServiceEntity { get { return GetGroup(ServicesMatcher.StorageService).GetSingleEntity(); } }
    public Code.ECS.Components.StorageServiceComponent storageService { get { return storageServiceEntity.storageService; } }
    public bool hasStorageService { get { return storageServiceEntity != null; } }

    public ServicesEntity SetStorageService(Code.Services.Interfaces.IStorageService newValue) {
        if (hasStorageService) {
            throw new Entitas.EntitasException("Could not set StorageService!\n" + this + " already has an entity with Code.ECS.Components.ConfigServiceComponent!",
                "You should check if the context already has a storageServiceEntity before setting it or use context.ReplaceStorageService().");
        }
        var entity = CreateEntity();
        entity.AddStorageService(newValue);
        return entity;
    }

    public void ReplaceStorageService(Code.Services.Interfaces.IStorageService newValue) {
        var entity = storageServiceEntity;
        if (entity == null) {
            entity = SetStorageService(newValue);
        } else {
            entity.ReplaceStorageService(newValue);
        }
    }

    public void RemoveStorageService() {
        storageServiceEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServicesEntity {

    public Code.ECS.Components.StorageServiceComponent storageService { get { return (Code.ECS.Components.StorageServiceComponent)GetComponent(ServicesComponentsLookup.StorageService); } }
    public bool hasStorageService { get { return HasComponent(ServicesComponentsLookup.StorageService); } }

    public void AddStorageService(Code.Services.Interfaces.IStorageService newValue) {
        var index = ServicesComponentsLookup.StorageService;
        var component = (Code.ECS.Components.StorageServiceComponent)CreateComponent(index, typeof(Code.ECS.Components.StorageServiceComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStorageService(Code.Services.Interfaces.IStorageService newValue) {
        var index = ServicesComponentsLookup.StorageService;
        var component = (Code.ECS.Components.StorageServiceComponent)CreateComponent(index, typeof(Code.ECS.Components.StorageServiceComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStorageService() {
        RemoveComponent(ServicesComponentsLookup.StorageService);
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
public sealed partial class ServicesMatcher {

    static Entitas.IMatcher<ServicesEntity> _matcherStorageService;

    public static Entitas.IMatcher<ServicesEntity> StorageService {
        get {
            if (_matcherStorageService == null) {
                var matcher = (Entitas.Matcher<ServicesEntity>)Entitas.Matcher<ServicesEntity>.AllOf(ServicesComponentsLookup.StorageService);
                matcher.componentNames = ServicesComponentsLookup.componentNames;
                _matcherStorageService = matcher;
            }

            return _matcherStorageService;
        }
    }
}
