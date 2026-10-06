using System;
using System.Collections.Generic;

[Serializable]
public class MasterQuestInfo : MasterRecordDFBase
{
	[Serializable]
	public class Npc_fd
	{
		public int DF;

		public int STEP;

		public string MESSAGE;

		public int FD;

		public int POS;

		public string ADV;

		public int PLC;

		public int PLC_ID;

		public int CHA_ID;

		public bool IsMatch(ENPCPlace place, int placeId)
		{
			return false;
		}

		public bool IsArea(int areaId)
		{
			return false;
		}

		public bool IsTown(int townId)
		{
			return false;
		}
	}

	[Serializable]
	public class Rwd_item
	{
		public int DF;

		public int QTY;

		public int TRT;

		public int CNT;

		public int EX_DF0;

		public int EX_QTY0;

		public int EX_TRT0;

		public int EX_CNT0;

		public int EX_DF1;

		public int EX_QTY1;

		public int EX_TRT1;

		public int EX_CNT1;

		public int EX_DF2;

		public int EX_QTY2;

		public int EX_TRT2;

		public int EX_CNT2;

		public int EX_DF3;

		public int EX_QTY3;

		public int EX_TRT3;

		public int EX_CNT3;

		public int EX_DF4;

		public int EX_QTY4;

		public int EX_TRT4;

		public int EX_CNT4;
	}

	[Serializable]
	public class Rwd_wth
	{
		public int DF;

		public int CNT;
	}

	[Serializable]
	public class Flg_on
	{
		public int DF;
	}

	[Serializable]
	public class Target
	{
		public int DF;

		public int CATEG;

		public int BDR;

		public int QTY;

		public int AREA;
	}

	[Serializable]
	public class UnlockTitle
	{
		public int DF;

		public int STP;
	}

	public EQuestCategory CATEG;

	public EQuestType TYPE;

	public EQuestGroup GROUP;

	public string NAME;

	public string KANA;

	public string DESC;

	public string CONDITION;

	public int QUEST_NO;

	public int QUEST_SUB_NO;

	public int CHAPTER;

	public int CHARA;

	public int NPC;

	public int DESTINATION;

	public int AREA;

	public int RNK_PT;

	public List<UnlockTitle> UNLOCK;

	public bool LAST;

	public bool INVISIBLE;

	public bool IMPORTANT;

	public int PARTY_IN;

	public int KEY_QUEST;

	public bool OFFICIAL_EXAMINATION;

	public bool CHALLENGE;

	public CostInfo COST;

	public int EVENT;

	public Npc_fd[] NPC_FD;

	public Rwd_item[] RWD_ITEM;

	public Rwd_wth[] RWD_WTH;

	public Flg_on[] FLG_ON;

	public Target[] ENM;

	public Target[] BTL;

	public Target[] QST;

	public Target[] MIX;

	public Target[] SKL;

	public Target[] ACT_SKL;

	public Target[] DLV;

	public Target[] ALC;

	public Target[] GET;

	public Target[] PIC;

	public Target[] REG;

	public Target[] DUN;

	public Target[] ARR;

	public Target[] SPE;

	public Target[] VIL;

	public Target[] TALK;

	public Target[] ARA;

	public void Order()
	{
	}

	public void Discard()
	{
	}

	public Npc_fd GetNpcFD(EQuestSTP stp)
	{
		return null;
	}

	public bool IsArea(int areaId)
	{
		return false;
	}

	public Target[] GetTargetList()
	{
		return null;
	}

	public bool IsNeedCost()
	{
		return false;
	}

	public bool IsRetryOK()
	{
		return false;
	}

	public bool IsMainFirst()
	{
		return false;
	}

	public void MakeTutorialData(int df)
	{
	}

	public void SetNotSelectedData()
	{
	}

	public Npc_fd GetNPCInfo(EQuestSTP step)
	{
		return null;
	}
}
