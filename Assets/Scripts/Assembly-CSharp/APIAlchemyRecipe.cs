public class APIAlchemyRecipe : APISimple
{
	public class Request
	{
		public int DF;
	}

	private Request m_sRequest;

	public int RecipeID
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
