using System.Collections.Generic;

namespace ADV
{
	public class ScriptTalk : ScriptBase
	{
		private enum EStep
		{
			eWIN_OUT = 0,
			eWIN_IN = 1,
			eDELAY = 2,
			eINIT = 3,
			eMOVE = 4,
			eWAIT = 5,
			eWIN_OUT_SKIP = 6
		}

		private enum EParamKind
		{
			eFACEID = 0,
			eTALKER = 1,
			eCONTENT = 2,
			eEMOTION = 3,
			ePOS = 4,
			eEMOTICON = 5,
			eVOICE = 6
		}

		private string m_sSpeakerName;

		private string m_sContent;

		private int m_iFaceID;

		private EFeel m_eFeel;

		private int m_iEmoticonID;

		private string m_sVoPath;

		private EPosition m_ePos;

		private float m_fWait;

		private Sound_Loop m_sSE;

		private EStep m_eStep;

		public override void SetParam(List<string> param)
		{
		}

		public void SetMemberParam(List<string> param)
		{
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

		private void PlaySound()
		{
		}

		public void UnloadVoice()
		{
		}

		public override int Next(ScriptInfo all, int startIndex, bool skip)
		{
			return 0;
		}
	}
}
