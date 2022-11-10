﻿namespace Code.Data.Config.Editor
{
	public static class EditorExtensions
	{
		public static void OnPress(this bool @this, System.Action action)
		{
			if (@this)
			{
				action.Invoke();
			}
		}
	}
}