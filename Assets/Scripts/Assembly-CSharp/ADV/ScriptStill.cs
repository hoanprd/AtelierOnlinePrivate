using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ADV
{
	public class ScriptStill : ScriptBase
	{
		private enum EStep
		{
			eFADEOUT = 0,
			eDISP = 1,
			eFADEIN = 2,
			eUNLOAD = 3
		}

		private string m_sPicturePath;

		private EStep m_eStep;

		private bool m_bLoadEnd;

		private string GetImagePath(int id)
		{
			return null;
		}

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

		[DebuggerHidden]
		private IEnumerator LoadPicture()
		{
			return null;
		}

		private void SetPicture()
		{
		}
	}
}
