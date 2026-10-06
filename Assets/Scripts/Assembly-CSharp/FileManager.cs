public static class FileManager
{
	public static string sc_salt;

	public static string sc_EncryptKey;

	private const string c_sFILE_EXT = ".dat";

	private static byte[] ReadFile(string path)
	{
		return null;
	}

	public static bool SaveLocalEncrypt(string path, string content, string password = "")
	{
		return false;
	}

	public static bool SaveLocalEncrypt(string path, byte[] content, string password = "")
	{
		return false;
	}

	public static string LoadFromLocal(string path, string password = "")
	{
		return null;
	}

	public static string LoadGZ(byte[] bytes)
	{
		return null;
	}

	public static string LoadFromBytes(byte[] bytes, string password = "")
	{
		return null;
	}

	public static byte[] LoadBytes(byte[] bytes, string password = "")
	{
		return null;
	}

	private static void GenerateKeyFromPassword(string password, int keySize, out byte[] key, int blockSize, out byte[] iv)
	{
		key = null;
		iv = null;
	}

	private static byte[] EncryptBytes(byte[] rawBytes, string password)
	{
		return null;
	}

	private static byte[] DecryptBytes(byte[] encBytes, string password)
	{
		return null;
	}

	public static bool EncryptFile(string path, byte[] rawBytes, string password)
	{
		return false;
	}

	public static byte[] DecryptFile(string path, string password)
	{
		return null;
	}

	public static bool CompareBytes(byte[] array1, byte[] array2)
	{
		return false;
	}

	public static bool IsExist(string path)
	{
		return false;
	}

	public static bool Delete(string path)
	{
		return false;
	}
}
