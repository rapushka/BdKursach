using System.Collections.Generic;
using Code.Utils.Extensions;
using Unity.VisualScripting;
using UnityEngine;

namespace Code.Utils.Common
{
	public class Vector3Interval : Interval<Vector3>
	{
		private readonly int _direction;

		public Vector3Interval(Vector3 startValue, Vector3 endValue)
			: base(startValue, endValue)
			=> _direction = endValue.Compare(startValue);

		public Vector3 Next(Vector3 current, float step) => current + CalculateScaledStep(step);

		private Vector3 CalculateScaledStep(float step) => Vector3.one * _direction * step;
	}
}