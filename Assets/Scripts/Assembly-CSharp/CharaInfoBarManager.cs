using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CharaInfoBarManager : MonoBehaviour
{
	public enum eMode
	{
		CharaInfo = 0,
		DungeonInfo = 1,
		EnumMax = 2
	}

	private static readonly float[] sr_fModeDispTime;

	private static CharaInfoBarManager s_Instance;

	private Dictionary<int, CharaInfoBar> m_scrBarDic;

	private List<int> m_iRemoveKeyList;

	[SerializeField]
	private UITable m_scrTable;

	[SerializeField]
	private GameObject m_goBarPrefab;

	private bool m_bInited;

	private float m_fWaitTime;

	private int m_iModeNow;

	private PlayerDetailManager m_scrDetailWindow;

	private Coroutine m_cCoroutine;

	public static CharaInfoBarManager Instance
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void UpdateList(Dictionary<int, MultiPlay_CharaData> clsCharaList)
	{
	}

	public void DispDetail(int iCharaId, long lUserId)
	{
	}

	[DebuggerHidden]
	private IEnumerator RequestOthersProfile(int iCharaId, long lUserId, bool bMoveOK)
	{
		return null;
	}
}
