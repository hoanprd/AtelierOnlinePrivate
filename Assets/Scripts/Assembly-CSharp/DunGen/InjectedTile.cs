namespace DunGen
{
	public sealed class InjectedTile
	{
		public TileSet TileSet;

		public float NormalizedPathDepth;

		public float NormalizedBranchDepth;

		public bool IsOnMainPath;

		public bool IsRequired;

		public InjectedTile(TileSet tileSet, bool isOnMainPath, float normalizedPathDepth, float normalizedBranchDepth, bool isRequired = false)
		{
		}

		public bool ShouldInjectTileAtPoint(bool isOnMainPath, float pathDepth, float branchDepth)
		{
			return false;
		}
	}
}
