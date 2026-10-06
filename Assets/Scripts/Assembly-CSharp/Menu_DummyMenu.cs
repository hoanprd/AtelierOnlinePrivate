public class Menu_DummyMenu : Menu_Base
{
	private enum eMainStep
	{
		First_Init = 0,
		First_Wait = 1,
		FadeI_Init = 2,
		FadeI_Wait = 3,
		ControlWait_Init = 4,
		ControlWait_Wait = 5,
		FadeO_Init = 6,
		FadeO_Wait = 7,
		End = 8
	}

	private static Menu_DummyMenu g_scrInst;

	public System_MenuManager.eSystemMenuKind m_eNextMenuKind;

	public bool m_bPressButton;

	private eMainStep m_eMainStep;

	public static Menu_DummyMenu GetInst()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void MenuUpdate()
	{
	}

	private void First_Init()
	{
	}

	private bool First_Wait()
	{
		return false;
	}

	private void SetChangeMenuRequest()
	{
	}

	public void SetChangeMenuRequest(System_MenuManager.eSystemMenuKind eKind)
	{
	}
}
