using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class ScriptFieldPicture : ScriptBase
	{
		public enum EParamKind
		{
			eFIELD_ID = 0
		}

		public enum EStep
		{
			eLOAD = 0,
			eEXEC = 1
		}

		private GameObject m_goObject;

		private Animation m_sAnim;

		private bool m_bFade;

		private string m_sPrefabPath;

		private EStep m_eStep;

		public override List<string> GetNeedAsset()
		{
			return null;
		}

		public override bool Init(List<string> param, bool skip)
		{
			return false;
		}

		public override bool Exec(bool tap, bool skip)
		{
			return false;
		}
	}
}
