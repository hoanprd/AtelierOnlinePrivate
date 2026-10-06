using UnityEngine;
using migrate;

public class TakeoverItem : MonoBehaviour
{
	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private GameObject m_goLink;

	[SerializeField]
	private GameObject m_goUnLink;

	[SerializeField]
	private UIButton m_sButton;

	[SerializeField]
	private GameObject m_goSIWA;

	private AuthenticationManager.AuthType m_eAuthType;

	public AuthenticationManager.AuthType AuthType
	{
		get
		{
			return (AuthenticationManager.AuthType)0;
		}
	}

	public void Init(AuthenticationManager.AuthType type)
	{
	}
}
