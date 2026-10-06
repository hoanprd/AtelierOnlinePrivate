public class APIComProductRegisterAge : APISimple
{
	public class Request
	{
		public int AGE_CLASS;

		public int IS_CHECKED;
	}

	private Request m_sRequest;

	public int AGECLASS
	{
		set
		{
		}
	}

	public int IS_CHECKED
	{
		set
		{
		}
	}

	public override byte[] GetAPI()
	{
		return null;
	}
}
