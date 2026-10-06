public class Game_Animal_ItemDrop : Game_Animal_BaseMover
{
	private float m_dist_Hit;

	private Game_Item_PickUp_Base m_itemBase;

	protected bool m_isTouched;

	protected virtual float m_dist_Appear
	{
		get
		{
			return 0f;
		}
	}

	public override void InitializeAnimal()
	{
	}

	public virtual void SetItemBase(Game_Item_PickUp_Base item)
	{
	}

	protected override bool IsMoveOKtoNG()
	{
		return false;
	}

	protected override void MoveNG_Init()
	{
	}

	protected override void MoveNG_Wait()
	{
	}

	protected bool IsTouched()
	{
		return false;
	}

	public override void SetAgent()
	{
	}
}
