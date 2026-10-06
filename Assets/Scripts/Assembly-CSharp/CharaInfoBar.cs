using UnityEngine;

public class CharaInfoBar : MonoBehaviour
{
	public enum eSprite
	{
		HostIcon = 0,
		CharaMark = 1,
		Base = 2,
		EnumMax = 3
	}

	public enum eLabel
	{
		Level = 0,
		Name = 1,
		DgnName = 2,
		DgnFloor = 3,
		Degreea = 4,
		EnumMax = 5
	}

	private enum eButton
	{
		Alter = 0,
		Detail = 1,
		EnumMax = 2
	}

	private static readonly int[] sr_iBaseHeightAry;

	private MultiPlay_CharaData m_clsChara;

	[SerializeField]
	private UISprite[] m_scrSpriteAry;

	[SerializeField]
	private UILabel[] m_scrLabelAry;

	[SerializeField]
	private UIButton[] m_scrButtonAry;

	[SerializeField]
	private UISlider m_scrHpSlider;

	[SerializeField]
	private CharaInfoBarSubHPList m_scrHpBarList;

	[SerializeField]
	private GameObject[] m_goDispAry;

	[SerializeField]
	private Transform m_trDegreeRoot;

	private DegreeIcon m_scrDegree;

	private bool m_bRef;

	private bool m_bModeChange;

	public int PlayerID
	{
		get
		{
			return 0;
		}
	}

	public bool IsActive
	{
		get
		{
			return false;
		}
	}

	public bool IsRef
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void UpdateData(MultiPlay_CharaData clsChara, bool bForce, int iMode)
	{
	}

	public void ChangeMode(int iMode, bool bForce = false)
	{
	}

	private void Awake()
	{
	}

	private void OnAlter()
	{
	}

	private void OnDetail()
	{
	}

	private void SetLabel(MultiPlay_CharaData clsChara, DungeonInfo clsDgnMaster)
	{
	}

	private void SetLabelText(eLabel eKind, string strText)
	{
	}

	private UISprite GetSprite(eSprite eKind)
	{
		return null;
	}

	private void SetSpriteName(eSprite eKind, string strName)
	{
	}

	private void SetSpriteActive(eSprite eKind, bool bActive)
	{
	}

	private void SetSpriteColor(eSprite eKind, Color cColor)
	{
	}

	private void SetSpriteHeight(eSprite eKind, int iHeight)
	{
	}

	private void SetButtonActive(eButton eKind, bool bActive)
	{
	}
}
