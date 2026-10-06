using UnityEngine;

public class Game_UI_MA_EnemyInfo : MonoBehaviour
{
	public enum eLabel
	{
		Lv = 0,
		Name = 1,
		EnumMax = 2
	}

	private static readonly string c_strLavelHead;

	[SerializeField]
	private UILabel[] m_scrLabelArray;

	[SerializeField]
	private UISprite m_sBossMark;

	[SerializeField]
	private WeakIcon m_sWeak;

	protected virtual void SetLabelText(eLabel eLabel, string strText)
	{
	}

	protected virtual bool IsExistLabel(int iIndex)
	{
		return false;
	}

	public void SetEnemy(string strName, int iLevel, bool boss, EElement weak)
	{
	}

	public void ChangeColor(Color cColor)
	{
	}
}
