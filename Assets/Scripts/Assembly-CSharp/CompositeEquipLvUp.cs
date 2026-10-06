using System.Collections.Generic;
using UnityEngine;

public class CompositeEquipLvUp : MonoBehaviour
{
	public GameObject m_prfStateItem;

	public UIGrid m_itemRoot;

	private List<GameObject> m_oldObjList;

	private static readonly EParamKind[] scPARAM_KIND_LIST;

	public void Init(EquipParam befor, EquipParam after)
	{
	}
}
