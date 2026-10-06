using System.Collections.Generic;
using UnityEngine;

public class Game_Animal_GimmickFader : Game_Animal_BaseFader
{
	private Game_Gimmick_Base m_scrGimmick;

	private List<Collider> m_scrCollList;

	private List<GameObject> m_goChildList;

	private List<GameObject> m_goLinkObjList;

	public void SetGimmick(Game_Gimmick_Base scrGim)
	{
	}

	public void AddLinkObj(GameObject goObj)
	{
	}

	public override void InitializeAnimal()
	{
	}

	protected override void AnimalUpdate_FadeInit(bool forward)
	{
	}

	protected override void AnimalUpdate_FadeLast(bool forward)
	{
	}
}
