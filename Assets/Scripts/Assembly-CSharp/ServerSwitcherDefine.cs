public class ServerSwitcherDefine
{
	public enum Env
	{
		Develop = 0,
		Dev1 = 1,
		Dev2 = 2,
		Dev3 = 3,
		Dev4 = 4,
		Dev5 = 5,
		Stg = 6,
		Java = 7,
		Master = 8,
		Max = 9
	}

	public static string[] EnvNames;

	public static string[] ServerNames;
}
