using System.Collections.Generic;

namespace ADV
{
	public class ScriptVoiceADVPlayer : ScriptBase
	{
		private string m_sVoPath;

		private bool m_bWait;

		public override void SetParam(List<string> param)
		{
		}

		private void SetParamCommon(List<string> param)
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
	}
}
