using UnityEngine;

public class Game_UI_Launcher_SubMenu : MonoBehaviour
{
	public enum ELauncherKind
	{
		eALTER = 0,
		eQUEST = 1,
		eCHARA = 2,
		eITEM = 3,
		eOPTION = 4,
		eUSEITEM = 5,
		eEQUIP = 6
	}

	[SerializeField]
	protected ELauncherKind m_eKind;

	[SerializeField]
	protected AnimationController m_sAnim;

	[SerializeField]
	protected UIGrid m_sGrid;

	[SerializeField]
	protected UISprite[] m_asBackground;

	private float[] m_afOffset;

	protected bool m_bUpdateState;

	public ELauncherKind Kind
	{
		get
		{
			return ELauncherKind.eALTER;
		}
	}

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	public virtual void UpdateState()
	{
	}

	protected void Resize(int count)
	{
	}

	public virtual void Bringin()
	{
	}

	public virtual void Dismiss()
	{
	}

	public virtual bool IsEndAnimation()
	{
		return false;
	}

	private void OnClose()
	{
	}

	private void LateUpdate()
	{
	}

	protected void RemoveButton(GameObject button)
	{
	}
}
