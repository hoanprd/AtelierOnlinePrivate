using System.Collections.Generic;

namespace ADV
{
	public class ScriptSE : ScriptBase
	{
		private enum EParamKind
		{
			eID = 0,
			eWAIT = 1
		}

		private Sound_OneShot m_sPlaySound;
		private bool m_bWait;

		public override bool Init(List<string> param, bool skip)
		{
			SetParam(param);
			int seId = GetInt(param, (int)EParamKind.eID, -1);
			m_bWait = GetBool(param, (int)EParamKind.eWAIT, false);

			if (!skip && seId >= 0)
			{
				Sound_Manager inst = Sound_Manager.GetInst();
				if (inst != null)
				{
					m_sPlaySound = inst.PlaySound((eSoundID)seId);
				}
			}

			if (skip || !m_bWait)
			{
				return true;
			}

			return false;
		}

		public override bool Exec(bool tap, bool skip)
		{
			if (skip || !m_bWait) return true;
			return m_sPlaySound == null;
		}
	}
}
