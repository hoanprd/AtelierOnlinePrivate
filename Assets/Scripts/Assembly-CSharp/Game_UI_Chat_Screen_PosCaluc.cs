using UnityEngine;

public class Game_UI_Chat_Screen_PosCaluc : MonoBehaviour
{
	private enum eDir
	{
		Up = 0,
		Down = 1,
		Right = 2,
		Left = 3
	}

	private static readonly Vector3[] c_v3OffsetArray_F;

	private static readonly Vector3[] c_v3OffsetArray_B;

	private static readonly Game_UI_Chat_Screen_Manager.eBaloonArrow[] c_eArrowPriorityArray;

	[SerializeField]
	private BoxCollider[] m_scrColliderArray_F;

	[SerializeField]
	private BoxCollider[] m_scrColliderArray_B;

	[SerializeField]
	private BoxCollider[] m_scrColliderArray_T;

	private Vector3 GetOffset(Game_UI_Chat_Screen_Manager.eOffset eOffset, Game_UI_Chat_Screen_Manager.eBaloonArrow eArrow)
	{
		return default(Vector3);
	}

	private Vector3 GetDiff(Vector3 v3LocalPos, Vector3 v3BL, Vector3 v3TR, Game_UI_Chat_Screen_Manager.eBaloonArrow eArrow, Vector2 v2BaloonSize)
	{
		return default(Vector3);
	}

	public Game_UI_Chat_Screen_Manager.BaloonPos GetInsidePos(Vector3 v3CheckPos, Game_UI_Chat_Manager.eMode eMode, Game_UI_Chat_Screen_Manager.eOffset eOffset, Vector2 v2BaloonSize, Game_UI_Chat_Screen_Manager.eBaloonArrow eSpecifyArrow = Game_UI_Chat_Screen_Manager.eBaloonArrow.EnumMax)
	{
		return null;
	}
}
