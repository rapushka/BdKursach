using Code.Unity.ViewListeners.UI;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.EntityBehaviours
{
	public class ResourceRenewButtonBehaviour : EntityBehaviour
	{
		[SerializeField] private ProgressBarView _progressBarView;

		protected override bool ReadyForInitialization() => _progressBarView.Entity != null;

		protected override void Initialize() => _progressBarView.Entity.Do((e) => e.AddText(e.renewPrice));
	}
}