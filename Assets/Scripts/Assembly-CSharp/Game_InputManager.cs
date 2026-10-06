using UnityEngine;

public class Game_InputManager : MonoBehaviour
{
	public enum eControlKind
	{
		CharaMove = 0,
		CharaAction = 1,
		EnumMax = 2
	}

	private static Game_InputManager m_inst;

	private Game_InputData[] m_inputDataArray;

	public static Game_InputManager GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Initialize()
	{
	}

	private void Update()
	{
	}

	private eControlKind GetControlKind(Vector3 touchPos)
	{
		return eControlKind.CharaMove;
	}

	private Game_InputData GetInputData(eControlKind kind)
	{
		return null;
	}

	public bool IsTrigger(eControlKind kind)
	{
		return false;
	}

	public bool IsPress(eControlKind kind)
	{
		return false;
	}

	public Vector3 GetTouchPos_Now(eControlKind kind)
	{
		return default(Vector3);
	}

	public Vector3 GetTouchPos_Moved(eControlKind kind)
	{
		return default(Vector3);
	}
}
