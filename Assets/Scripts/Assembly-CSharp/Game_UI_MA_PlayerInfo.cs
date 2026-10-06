using UnityEngine;

public class Game_UI_MA_PlayerInfo : MonoBehaviour
{
	public enum eLabel
	{
		Name = 0,
		EnumMax = 1
	}

	[SerializeField]
	private UILabel[] m_scrLabelArray;

	[SerializeField]
	private AbnormalStateIconList m_scrAbnormalIcon;

	protected virtual void SetLabelText(eLabel eLabel, string strText)
	{
	}

	protected virtual void SetLabelColor(eLabel eLabel, Color col)
	{
	}

	protected virtual bool IsExistLabel(int iIndex)
	{
		return false;
	}

	public void SetPlayer(string strName, Color col)
	{
	}

	public void SetAbnormalState(MultiPlay_CharaData clsData)
	{
	}
}
