using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class ScriptCameraTarget : ScriptBase
	{
		protected bool m_bWait;

		public override bool Init(List<string> param, bool skip)
		{
			return false;
		}

		protected virtual bool SetTarget(Transform target, bool skip)
		{
			return false;
		}

		public override bool Exec(bool tap, bool skip)
		{
			return false;
		}
	}
}
