using UnityEngine;

public class SetExqRoomSelectListItem : MonoBehaviour
{
	public enum EColorPattern
	{
		eNORMAL = 0,
		eSELECTED = 1
	}

	[SerializeField]
	private UILabel m_lItemName;

	[SerializeField]
	private GameObject[] m_goaBgImages;

	private int m_keyNum;

	public void Init(int keyNum, string textItemName)
	{
	}

	public void Selected()
	{
	}

	private void SetButtonColor(EColorPattern setPattern)
	{
	}

	public int GetKeyNum()
	{
		return 0;
	}
}
