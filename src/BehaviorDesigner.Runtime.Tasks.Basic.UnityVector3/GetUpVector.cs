using System;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	[TaskCategory("Basic/Vector3"), TaskDescription("Stores the up vector value.")]
	public class GetUpVector : BehaviorDesigner.Runtime.Tasks.Action
	{
		[RequiredField, BehaviorDesigner.Runtime.Tasks.Tooltip("The stored result")]
		public SharedVector3 storeResult;

		public override TaskStatus OnUpdate()
		{
			this.storeResult.Value = Vector3.up;
			return TaskStatus.Success;
		}

		public override void OnReset()
		{
			this.storeResult = Vector3.zero;
		}
	}
}
