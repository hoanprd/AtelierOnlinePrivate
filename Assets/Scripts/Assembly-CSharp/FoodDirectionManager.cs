using UnityEngine;

public class FoodDirectionManager : MonoBehaviour
{
	[SerializeField]
	private AnimationController m_sAnim;

	[SerializeField]
	private UILabel m_sName;

	[SerializeField]
	private UITexture m_txCharaPic;

	[SerializeField]
	private TrainingParam m_sParam;

	[SerializeField]
	private UIButton m_sOKButton;

	[SerializeField]
	private UITexture[] m_atxFoodPic;

	private int m_iCharaID;

	public void Init(CharaDetail target)
	{
	}

	public void OnClose()
	{
	}

	private void OnCloseEnd()
	{
	}

	private void OnFinish()
	{
	}
}
