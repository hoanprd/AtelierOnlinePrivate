using System.Collections.Generic;

namespace ADV
{
	public class ScriptBGM : ScriptBase
	{
		public override List<string> GetNeedAsset()
		{
			return null;
		}

		public override bool Init(List<string> param, bool skip)
		{
			SetParam(param);
			int musicId = GetInt(param, 0, -1);
			if (musicId >= 0)
			{
				Sound_Manager inst = Sound_Manager.GetInst();
				if (inst != null)
				{
					inst.PlayMusic_ADV((eMusicID)musicId, true);
				}
			}
			return true;
		}

		public override bool Exec(bool tap, bool skip)
		{
			return true;
		}
	}
}
