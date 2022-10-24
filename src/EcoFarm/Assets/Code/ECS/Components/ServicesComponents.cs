﻿using Code.Services.Interfaces;
using Code.Utils.ComponentsTemplates;
using Entitas.CodeGeneration.Attributes;

namespace Code.ECS.Components
{
	[Services] [Unique] public sealed class ResourcesServiceComponent : ValueComponent<IResourcesService> { }

	[Services] [Unique] public sealed class SceneObjectsServiceComponent : ValueComponent<ISceneObjectsService> { }

	[Services] [Unique] public sealed class StorageServiceComponent : ValueComponent<IStorageService> { }
	
	[Services] [Unique] public sealed class ConfigServiceComponent : ValueComponent<IConfigService> { }
}