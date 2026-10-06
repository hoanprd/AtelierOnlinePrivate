using System.Reflection.Emit;

namespace MessagePack.Internal
{
	internal class DynamicAssembly
	{
		private readonly AssemblyBuilder assemblyBuilder;

		private readonly ModuleBuilder moduleBuilder;

		public ModuleBuilder ModuleBuilder
		{
			get
			{
				return null;
			}
		}

		public DynamicAssembly(string moduleName)
		{
		}
	}
}
