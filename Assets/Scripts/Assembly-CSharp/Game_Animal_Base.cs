using UnityEngine;

public class Game_Animal_Base : Game_Mover_Base
{
	public enum eDrawFlagKind
	{
		Culling = 0,
		Blink = 1,
		Fade = 2,
		EnumMax = 3
	}

	public enum eMainStep
	{
		First = 0,
		MoveOK_Init = 1,
		MoveOK_Fade = 2,
		MoveOK_Wait = 3,
		MoveNG_Init = 4,
		MoveNG_Fade = 5,
		MoveNG_Wait = 6
	}

	public bool[] m_moveTimeArray;

	public bool[] m_moveWeatherArray;

	protected GameObject m_shadowObject;

	public float m_mdoelScale;

	public float m_shadowScale;

	public bool m_makeShadow;

	protected float m_appearSec_Now;

	protected float m_appearSec_Max;

	protected float m_drawDist;

	protected bool m_enableDrawFlag_Main;

	protected bool[] m_drawFlagArray;

	protected bool m_initialized;

	private int m_animalIndex;

	private eMainStep m_mainStep;

	public eMainStep MainStep
	{
		get
		{
			return eMainStep.First;
		}
	}

	protected override void Start()
	{
	}

	public virtual void InitializeAnimal()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected void SetShadowParent(Transform parent)
	{
	}

	protected override void MoverUpdate_Normal()
	{
	}

	protected virtual void AnimalUpdate_Main()
	{
	}

	protected virtual void MoveOK_Init()
	{
	}

	protected virtual bool MoveOK_Fade()
	{
		return false;
	}

	protected virtual void MoveOK_Wait()
	{
	}

	protected virtual bool IsMoveOKtoNG()
	{
		return false;
	}

	protected virtual void MoveNG_Init()
	{
	}

	protected virtual bool MoveNG_Fade()
	{
		return false;
	}

	protected virtual void MoveNG_Wait()
	{
	}

	protected virtual bool IsMoveNGtoOK()
	{
		return false;
	}

	protected virtual void AnimalUpdate_Always()
	{
	}

	protected virtual void AnimalUpdate_FadeInit(bool forward)
	{
	}

	protected virtual void AnimalUpdate_Fade(bool forward, float percentNow)
	{
	}

	protected virtual void AnimalUpdate_FadeLast(bool forward)
	{
	}

	protected virtual void AnimalUpdate_Culling()
	{
	}

	protected virtual bool IsAnimalDrawCheckSub(bool enable)
	{
		return false;
	}

	public void SetAnimalDrawOK(eDrawFlagKind kind, bool enableDrawNow)
	{
	}

	protected virtual void SetAnimalDrawSub(bool enableDrawNow)
	{
	}

	public bool IsMoveTimeOK()
	{
		return false;
	}

	public void ForceUpdate()
	{
	}

	public bool IsDrawing()
	{
		return false;
	}

	public bool IsDrawFlag(eDrawFlagKind kind)
	{
		return false;
	}
}
