using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class ScriptFade : ScriptBase
	{
		public enum EParamKind
		{
			eONOFF = 0,
			eWAIT = 1,
			eDURATION = 2,
			COLOR = 3
		}

		private bool m_bFadeIn;
		private bool m_bWait;

		public override bool Init(List<string> param, bool skip)
		{
			SetParam(param);
			m_bFadeIn = GetBool(param, (int)EParamKind.eONOFF, true);
			m_bWait = GetBool(param, (int)EParamKind.eWAIT, true);
			float duration = GetFloat(param, (int)EParamKind.eDURATION, 0.5f);
			int colorIdx = GetInt(param, (int)EParamKind.COLOR, 0);

			if (skip)
			{
				duration = 0.1f;
			}

			Color fadeColor = Color.black;
			switch (colorIdx)
			{
				case 1: fadeColor = Color.white; break;
				case 2: fadeColor = Color.red; break;
				case 3: fadeColor = Color.green; break;
				case 4: fadeColor = Color.magenta; break;
				case 5: fadeColor = Color.yellow; break;
			}

			if (!m_bFadeIn)
			{
				LoadingManager.Enable(fadeColor, duration);
			}
			else
			{
				LoadingManager.Disable(duration);
			}

			return !m_bWait;
		}

		public override bool Exec(bool tap, bool skip)
		{
			if (skip || !m_bWait) return true;
			return m_bFadeIn ? LoadingManager.IsEnd : LoadingManager.IsBlackOut;
		}
	}
}
