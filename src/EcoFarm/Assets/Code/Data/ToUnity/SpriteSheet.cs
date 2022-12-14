using System.Collections.Generic;
using System.Linq;
using Code.Data.StorageJson;
using EcoFarmModel;
using UnityEngine;
using Code.Utils.Extensions;

namespace Code.Data.ToUnity
{
	[CreateAssetMenu(fileName = "SpriteSheet", menuName = "ScriptableObject/SpriteSheet")]
	public class SpriteSheet : ScriptableObject
	{
		[SerializeField] private List<Association> _products;
		[SerializeField] private List<Association> _buildings;

		public Dictionary<string, Sprite> Products => _products.ToDictionary((x) => x.Title, (x) => x.Sprite);

		public Dictionary<string, Sprite> Buildings => _buildings.ToDictionary((x) => x.Title, (x) => x.Sprite);

		public void UpdateResources()
			=> new StorageAccess()
			   .Storage
			   .Do((e) => e.Products.ForEach(AddNew, @if: IsNotAlreadyInDictionary))
			   .Do((e) => e.Buildings.ForEach(AddNew, @if: IsNotAlreadyInDictionary));

		private bool IsNotAlreadyInDictionary(Building building) => _buildings.All((b) => building.Title != b.Title);

		private bool IsNotAlreadyInDictionary(Product product) => _products.All((p) => product.Title != p.Title);

		private void AddNew(Building building) => _buildings.Add(new Association(building.Title));

		private void AddNew(Product product) => _products.Add(new Association(product.Title));
	}
}