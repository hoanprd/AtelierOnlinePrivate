using UnityEngine;

[ExecuteInEditMode]
public class RecipeListIconBase : MonoBehaviour
{
	public UITexture m_sDetailTexture;

	public UILabel m_sName;

	public GameObject m_goNewBadge;

	public UILabel m_sHaveNum;

	public UILongTapButton m_sSelectButton;

	public UILabel m_sInfoLabel;

	public UISprite m_sInfoColor;

	public UISprite m_sInfoNone;

	public UITweenReset m_sSelectAnim;

	protected RecipeInfo m_sRecipe;

	protected MasterItem m_sMaster;

	public RecipeInfo RecipeData
	{
		get
		{
			return null;
		}
	}

	public MasterItem Master
	{
		get
		{
			return null;
		}
	}

	private bool IsEnableAlter()
	{
		return false;
	}

	private bool IsEnoughEther()
	{
		return false;
	}

	public virtual void Init(RecipeInfo recipe)
	{
	}

	private void PlayAnim()
	{
	}

	public virtual void Modify()
	{
	}
}
