using System.Collections.Generic;
using UnityEngine;

namespace ADV
{
	public class ScriptNPCPop2 : ScriptBase
	{
		private static readonly float s_waitTime;

		private float m_waitTime;

		private Game_Gimmick_NPCBase m_npc;

		private MakeCharaData m_makeData;

		public override void SetParam(List<string> param)
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

		protected virtual void MakeNPC(int no, int npcId, Vector3 pos, float rotY, bool isDefault)
		{
		}

		protected void RemoveNPC(int no)
		{
		}

		public override bool Exec(bool tap, bool skip)
		{
			return false;
		}
	}
}
