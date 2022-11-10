﻿// ReSharper disable Unity.PerformanceCriticalCodeInvocation - we don't care about performance in the editor
using System.IO;
using UnityEditor;
using UnityEngine;
using static Code.Data.Config.Editor.EditorGUILayoutUtils;
using static UnityEngine.GUILayout;

namespace Code.Data.Config.Editor
{
	public class DataLoaderWindow : EditorWindow
	{
		private string _pathToDll;
		
		[MenuItem("Tools/Eco-Farm/Data Loader Window")]
		private static void ShowWindow()
		{
			var window = GetWindow<DataLoaderWindow>();
			window.titleContent = new GUIContent("Data Loader");
			window.Show();
		}

		private void OnGUI()
		{
			AsHorizontalGroup(DrawOpenDll);
		}

		private void DrawOpenDll()
		{
			Label("Dll path", new GUIStyle(GUI.skin.label), Width(50));
			_pathToDll = TextField(_pathToDll);
			Button("Open file", new GUIStyle(GUI.skin.button), Width(75)).OnPress(GetPathToDll);
		}

		private void GetPathToDll() => _pathToDll = EditorUtility.OpenFilePanel("Open file", string.Empty, "dll");
	}
}