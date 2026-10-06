using UnityEngine;

[ExecuteInEditMode]
public abstract class ShopMenuBase : MonoBehaviour
{
	public enum EKind
	{
		eNONE = 0,
		eSELECT = 1,
		eSHOP = 2,
		eGACHA = 3,
		eEXIT = 4
	}

	[SerializeField]
	private EKind m_eKind;

	[SerializeField]
	private AnimationController[] m_sAnim;

	protected bool m_bError;

	protected bool m_bInit;

	protected EKind m_eNext;

	public const float cfWAIT_TIME = 18f;

	public bool IsInit
	{
		get
		{
			return false;
		}
	}

	public bool IsError
	{
		get
		{
			return false;
		}
	}

	public EKind Kind
	{
		get
		{
			return EKind.eNONE;
		}
	}

	public EKind Next
	{
		get
		{
			return EKind.eNONE;
		}
	}

	public bool IsAnimEnd
	{
		get
		{
			return false;
		}
	}

	public void Cancel()
	{
	}

	public virtual bool IsDispBadge()
	{
		return false;
	}

	public abstract void Init();

	public virtual void Bringin()
	{
	}

	public virtual void Dismiss()
	{
	}

	private void Awake()
	{
	}
}
