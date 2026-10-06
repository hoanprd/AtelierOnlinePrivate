public class System_Resolution_Button : System_Resolution_Base
{
	public enum eUpdatePosKind
	{
		Override_World = 0,
		Override_Local = 1,
		Additive_World = 2,
		Additive_Local = 3
	}

	public enum eUpdateScaleKind
	{
		Override = 0,
		Additive = 1
	}

	public eUpdatePosKind m_eUpdatePosKind;

	public eUpdateScaleKind m_eUpdateScaleKind;

	public stButtonRelocateData[] m_stRelocateData;

	protected override void SetRelocation()
	{
	}
}
