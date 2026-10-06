using System.Collections.Generic;
using UnityEngine;

public class Game_UI_OverHeadIcon : MonoBehaviour
{
	public enum eParent
	{
		ADV = 0,
		MapArea = 1,
		BattleArea = 2
	}

	private class StalkObj
	{
		private static readonly string[] sr_strIconPath;

		private static readonly Vector3[] sr_v3OffsetPos;

		public GameObject goStalkObj;

		public Vector3 v3StalkPos_Log;

		public GameObject goIcon;

		public eOverHeadIcon eIcon;

		public EEmoticon eEmote;

		public eOverHeadPos ePos;

		public Emoticon scrEmote;

		public eParent eIconParent;

		public StalkObj(GameObject goStalk, eOverHeadIcon eIcon, eOverHeadPos ePos, eParent eParent)
		{
		}

		public StalkObj(GameObject goStalk, GameObject goEmotePrefab, EEmoticon eEmote, eOverHeadPos ePos, eParent eParent)
		{
		}

		public string GetIconPath(eOverHeadIcon eIcon)
		{
			return null;
		}

		public Vector3 GetOffsetPos(eOverHeadPos ePos)
		{
			return default(Vector3);
		}

		private void MakeIcon(GameObject goEmotePrefab = null)
		{
		}

		public void ChangeIcon(eOverHeadIcon eNextIcon)
		{
		}

		public void ChangeEmote(EEmoticon eNextEmote, GameObject goEmotePrefab = null)
		{
		}

		public void Stalk()
		{
		}

		public void SetIconPos(Vector3 v3Position, Vector3 v3Offset)
		{
		}

		public bool IsExist_StalkObj()
		{
			return false;
		}

		public bool IsExistIcon()
		{
			return false;
		}

		public void DestroyIcon(bool bEmoteKill = false)
		{
		}

		public bool IsReplaceOK(GameObject goStalkObj, eOverHeadPos ePos)
		{
			return false;
		}

		public bool IsMatch(GameObject goStalkObj, eOverHeadPos ePos)
		{
			return false;
		}

		public void SetActive(bool bActive)
		{
		}
	}

	private List<StalkObj> m_clsStalkObjList;

	private List<StalkObj> m_clsRemoveObjList;

	[SerializeField]
	private GameObject m_goEmotePrefab;

	private void LateUpdate()
	{
	}

	private void RemoveStalkIcon(StalkObj clsStalk)
	{
	}

	public GameObject SetObj(bool bAdd, GameObject goStalkObj, eOverHeadPos ePos, eOverHeadIcon eIcon = eOverHeadIcon.EnumMax, eParent eParent = eParent.MapArea)
	{
		return null;
	}

	public GameObject SetObj(bool bAdd, GameObject goStalkObj, eOverHeadPos ePos, EEmoticon eEmote = EEmoticon.eNONE, eParent eParent = eParent.MapArea)
	{
		return null;
	}

	public GameObject AddObj(GameObject goStalkObj, eOverHeadPos ePos, eOverHeadIcon eIcon, eParent eParent = eParent.MapArea)
	{
		return null;
	}

	public GameObject AddObj(GameObject goStalkObj, eOverHeadPos ePos, EEmoticon eEmote, eParent eParent = eParent.MapArea)
	{
		return null;
	}

	public void RemoveObj(GameObject goStalkObj, eOverHeadPos ePos)
	{
	}

	public void RemoveObj(eParent eIconParent)
	{
	}

	public void SetActiveIcon(bool bActive, GameObject goStalkObj, eOverHeadPos ePos)
	{
	}
}
