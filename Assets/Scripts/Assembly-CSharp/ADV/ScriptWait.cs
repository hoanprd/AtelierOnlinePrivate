using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class ScriptWait : ScriptBase
	{
		protected float m_fWaitTime;
		private bool m_bSkipOK;

		public override bool Init(List<string> param, bool skip)
		{
			SetParam(param);
			m_fWaitTime = GetFloat(param, 0, 0f);
			m_bSkipOK = GetBool(param, 1, true);
			return m_bSkipOK && skip;
		}

		public override bool Exec(bool tap, bool skip)
		{
			if (m_bSkipOK && skip)
			{
				return true;
			}
			m_fWaitTime -= Time.deltaTime;
			return m_fWaitTime <= 0f;
		}
	}
}
