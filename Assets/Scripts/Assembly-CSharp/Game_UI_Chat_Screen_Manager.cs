using System.Collections.Generic;
using UnityEngine;

public class Game_UI_Chat_Screen_Manager : MonoBehaviour
{
	public enum eOffset
	{
		None = 0,
		Field = 1,
		Battle = 2
	}

	public class BaloonInfo
	{
		private static readonly float sc_fDispTime;

		private float fWaitTime;

		private Game_UI_Chat_Chara_Baloon scrBaloon;

		private bool bBroken;

		private UIGrid scrGrid;

		public eBaloonArrow eArrow;

		public Game_UI_Chat_Manager.eMode eMode;

		public long lUserId;

		public BaloonInfo(Game_UI_Chat_Chara_Baloon scrBaloon, int iMode, long UserId)
		{
		}

		private bool IsExist()
		{
			return false;
		}

		public bool IsRemove(float fDeltaTime)
		{
			return false;
		}

		public void BreakBaloon(bool bSoon)
		{
		}

		public void Stalk(Vector3 v3LocalPos, eBaloonArrow eArrow, bool bStartTween, bool bStalk)
		{
		}

		public void OuterGrid(Transform trParent)
		{
		}

		public void IntoGrid(UIGrid scrGrid, eBaloonArrow eArrow, bool bStartTween)
		{
		}

		public void SetRemarkerUI(bool bActive)
		{
		}

		public Vector2 GetBaloonSize()
		{
			return default(Vector2);
		}
	}

	public class BaloonPos
	{
		public Vector3 v3Pos;

		public eBaloonArrow eArrow;
	}

	public enum eBaloonArrow
	{
		Up = 0,
		Down = 1,
		Right = 2,
		Left = 3,
		EnumMax = 4
	}

	private Dictionary<int, BaloonInfo> m_clsBaloonDic;

	private List<int> m_iRemoveIdList;

	[SerializeField]
	private GameObject m_goBaloonRoot;

	[SerializeField]
	private GameObject m_goBaloonBase;

	[SerializeField]
	private Game_UI_Chat_Screen_PosCaluc m_scrPosCaluc;

	[SerializeField]
	private Transform m_trDummy;

	[SerializeField]
	private GameObject[] m_goOutFieldArray;

	[SerializeField]
	private UIGrid m_scrGrid;

	private const float EXQRoom_DefPosX = 130f;

	private const float EXQRoom_AddPosX = 235f;

	private const float EXQRoom_DefPosY = -100f;

	private const float EXQRoom_DefPosZ = -100f;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetActive(bool bActive)
	{
	}

	public void AddRemark(MultiPlay_ChatData clsChat)
	{
	}

	private void Stalk(int iRemarkerId, BaloonInfo clsBaloon, bool bStartTween = false)
	{
	}

	private void SetOutField(int iRoomIndex, out bool bStalk, out Vector3 v3CharaPos, out eOffset eOffsetMode)
	{
		bStalk = default(bool);
		v3CharaPos = default(Vector3);
		eOffsetMode = default(eOffset);
	}

	private GameObject GetOutFieldObj(int iRoomIndex)
	{
		return null;
	}
}
