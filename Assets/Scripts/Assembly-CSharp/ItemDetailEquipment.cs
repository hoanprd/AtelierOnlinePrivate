using UnityEngine;

public class ItemDetailEquipment : ItemDetailBase
{
	private enum EStatusKind
	{
		ePARAM = 0,
		eELEMENT = 1
	}

	public GameObject m_goSkillPrefab;

	public EquipParamList m_sParam;

	public EquipParamList m_sElement;

	private EStatusKind m_eStatusKind;

	[SerializeField]
	private UITexture m_DesignatedEquCharaIcon;

	public override void Init(int itemID, int lv, int quality, int qualitylimt, int trt, bool recipe, int fav, bool exist)
	{
	}

	public void OnChangeStatus()
	{
	}
}
