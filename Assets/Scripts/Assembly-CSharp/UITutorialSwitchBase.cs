using UnityEngine;

public abstract class UITutorialSwitchBase : MonoBehaviour
{
	public enum EFlag
	{
		eEND_FIELD = 0,
		eEND_QUEST = 1,
		eEND_ALL = 2,
		eEND_ALTER = 3,
		eEND_EQUIP = 4,
		eGATE = 5,
		eMULTIPLAY = 6,
		eEND_GACHA = 7,
		eEND_ACADEMY = 8,
		eEND_UNLOCKFORGE = 9,
		eEND_UNLOCKCONTAINER = 10,
		eNUMMAX = 11
	}

	private readonly eTutorial[] aeFLAGLIST;

	public bool IsGetFlag(EFlag flag)
	{
		return false;
	}

	protected virtual void Start()
	{
	}

	private void OnEnable()
	{
	}

	public abstract void UpdateStatus();
}
