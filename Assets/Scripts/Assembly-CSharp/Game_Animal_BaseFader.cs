using System.Collections.Generic;
using UnityEngine;

public class Game_Animal_BaseFader : Game_Animal_Base
{
	protected List<AnimalColorDataLog> m_changeMaterialList;

	protected bool m_enableDrawFlag_Fade;

	protected Renderer m_shadowRenderer;

	protected GameObject m_overHeadObj;

	protected bool m_isEveryRefreshMat;

	private bool m_bEnableCulling;

	public override void InitializeAnimal()
	{
	}

	protected virtual void SetChangeMaterialList(GameObject tempObj)
	{
	}

	protected override void SetAnimalDrawSub(bool enableDrawNow)
	{
	}

	protected override bool IsAnimalDrawCheckSub(bool enable)
	{
		return false;
	}

	protected override void AnimalUpdate_Fade(bool forward, float percentNow)
	{
	}

	protected override void AnimalUpdate_FadeInit(bool forward)
	{
	}

	protected override void AnimalUpdate_FadeLast(bool forward)
	{
	}

	protected void AddColorDataLog(Renderer renderer)
	{
	}

	public void SetOverHeadObj(GameObject obj)
	{
	}

	public GameObject SetOverHeadIcon(bool flag, eOverHeadIcon icon, Game_UI_OverHeadIcon.eParent parent = Game_UI_OverHeadIcon.eParent.MapArea)
	{
		return null;
	}

	public void SetEveryRefreshMaterial(bool flag)
	{
	}

	protected override void AnimalUpdate_Culling()
	{
	}

	public void SetCulling(bool bEnable)
	{
	}
}
