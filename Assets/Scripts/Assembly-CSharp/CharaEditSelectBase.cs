using UnityEngine;

public abstract class CharaEditSelectBase : MonoBehaviour
{
	public enum EKind
	{
		eNAME = 0,
		eGENDER = 1,
		eCOLOR = 2,
		eVOICE = 3
	}

	[SerializeField]
	private EKind m_eKind;

	[SerializeField]
	protected EquipmentModel m_sModel;

	public EKind Kind
	{
		get
		{
			return EKind.eNAME;
		}
	}

	public abstract string GetTitle();

	public virtual void UpdateModel()
	{
	}
}
