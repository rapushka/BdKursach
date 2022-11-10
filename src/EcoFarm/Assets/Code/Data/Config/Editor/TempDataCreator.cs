﻿using System.IO;
using EcoFarmDataModule;
using UnityEngine;

namespace Code.Data.Config.Editor
{
	public static class TempDataCreator
	{
		private const string RelativePath = "Assets/DataModel/SerializedFiles";

		public static void Create()
		{
			var storage = new Storage
			{
				Levels = new[] { new Level { Order = 1, TreesCount = 5 } }
			};

			var json = JsonUtility.ToJson(storage, prettyPrint: true);
			var path = Path.Combine(Directory.GetCurrentDirectory(), RelativePath, "storage.json");
			
			File.WriteAllText(path, json);
			Debug.Log($"File created on {path}");
		}
	}
}