﻿using Code.Unity.CustomTypes;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Code.Menus.UiBehaviours.MainMenu
{
	public class ButtonToScene : MonoBehaviour
	{
		[SerializeField] private Button _button;
		[SerializeField] private SceneField _scene;

		private void OnEnable() => _button.onClick.AddListener(ToGameplayScene);

		private void OnDisable() => _button.onClick.RemoveListener(ToGameplayScene);

		private void ToGameplayScene() => SceneManager.LoadScene(_scene);
	}
}