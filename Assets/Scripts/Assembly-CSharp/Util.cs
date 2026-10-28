using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

public static class Util
{
	private static readonly DateTime UNIX_EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	private const string csSTRING_IV = "Tc3Pw8C7";

	private const string csSTRING_KEY = "W7nX4jeu";

	public static string GetAssetFullPath(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return LocalDirectory.CachesDirectoryPath;
		}
		return LocalDirectory.CachesDirectoryPath + "/" + GetAssetFileName(path, true);
	}

	public static string GetAssetFileName(string path, bool encrypt = true)
	{
		if (string.IsNullOrEmpty(path))
		{
			return string.Empty;
		}
		string normalized = path.ToLower();
		if (encrypt)
		{
			return ToMD5HashString(normalized);
		}
		return normalized;
	}

	public static string GetObjectPath(GameObject obj)
	{
		if (obj == null)
		{
			return string.Empty;
		}
		string path = "/" + obj.name;
		Transform current = obj.transform.parent;
		while (current != null)
		{
			path = "/" + current.name + path;
			current = current.parent;
		}
		return path;
	}

	public static Transform FindOfName(Transform parent, string prefabName)
	{
		if (parent == null || string.IsNullOrEmpty(prefabName))
		{
			return null;
		}
		if (parent.name == prefabName)
		{
			return parent;
		}
		foreach (Transform child in parent)
		{
			Transform found = FindOfName(child, prefabName);
			if (found != null)
			{
				return found;
			}
		}
		return null;
	}

	public static T FindObjectFromName<T>(GameObject root, string name = null) where T : Component
	{
		if (root == null)
		{
			return null;
		}
		if (string.IsNullOrEmpty(name))
		{
			return root.GetComponentInChildren<T>(true);
		}
		T[] components = root.GetComponentsInChildren<T>(true);
		for (int i = 0; i < components.Length; i++)
		{
			if (components[i] != null && components[i].name == name)
			{
				return components[i];
			}
		}
		return null;
	}

	public static List<Transform> MultiFindOfName(Transform parent, string prefabName)
	{
		List<Transform> result = new List<Transform>();
		if (parent == null || string.IsNullOrEmpty(prefabName))
		{
			return result;
		}
		Transform[] all = parent.GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < all.Length; i++)
		{
			if (all[i] != null && all[i].name == prefabName)
			{
				result.Add(all[i]);
			}
		}
		return result;
	}

	public static Transform FindOfNameEx(Transform parent, string prefabName)
	{
		if (parent == null || string.IsNullOrEmpty(prefabName))
		{
			return null;
		}
		Transform[] all = parent.GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < all.Length; i++)
		{
			if (all[i] != null && all[i].name.Contains(prefabName))
			{
				return all[i];
			}
		}
		return null;
	}

	public static byte[] HexStringToBytes(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			return new byte[0];
		}
		int len = str.Length / 2;
		byte[] bytes = new byte[len];
		for (int i = 0; i < len; i++)
		{
			bytes[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
		}
		return bytes;
	}

	public static byte[] HexStringToBytes2(string str)
	{
		return HexStringToBytes(str);
	}

	public static string BytesToHexString(byte[] bytes)
	{
		if (bytes == null)
		{
			return string.Empty;
		}
		StringBuilder sb = new StringBuilder(bytes.Length * 2);
		for (int i = 0; i < bytes.Length; i++)
		{
			sb.Append(bytes[i].ToString("x2"));
		}
		return sb.ToString();
	}

	public static int GetShiftJisByte(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			return 0;
		}
		int count = 0;
		for (int i = 0; i < str.Length; i++)
		{
			count += (str[i] <= '\u007f' || (str[i] >= '\uff61' && str[i] <= '\uff9f')) ? 1 : 2;
		}
		return count;
	}

	public static KeyValuePair<int, int> GetStrNum_EmHalf(string str)
	{
		if (string.IsNullOrEmpty(str))
		{
			return new KeyValuePair<int, int>(0, 0);
		}
		int em = 0;
		int half = 0;
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] <= '\u007f' || (str[i] >= '\uff61' && str[i] <= '\uff9f'))
			{
				half++;
			}
			else
			{
				em++;
			}
		}
		return new KeyValuePair<int, int>(em, half);
	}

	public static string ToMD5HashString(string src)
	{
		if (src == null)
		{
			src = string.Empty;
		}
		byte[] data = Encoding.UTF8.GetBytes(src);
		return ToMD5HashStringFromBinary(data);
	}

	public static string ToMD5HashStringFromBinary(string path)
	{
		if (string.IsNullOrEmpty(path) || !File.Exists(path))
		{
			return string.Empty;
		}
		return ToMD5HashStringFromBinary(File.ReadAllBytes(path));
	}

	public static string ToMD5HashStringFromBinary(byte[] data)
	{
		if (data == null)
		{
			return string.Empty;
		}
		using (MD5 md5 = MD5.Create())
		{
			byte[] hash = md5.ComputeHash(data);
			return BytesToHexString(hash);
		}
	}

	public static string GetFileSizeText(long totalByte)
	{
		if (totalByte >= 1048576)
		{
			return string.Format("{0:F2}MB", (double)totalByte / 1048576.0);
		}
		if (totalByte >= 1024)
		{
			return string.Format("{0:F2}KB", (double)totalByte / 1024.0);
		}
		return string.Format("{0}B", totalByte);
	}

	public static string GetTimeSpanString(TimeSpan timeSpan)
	{
		if (timeSpan.TotalDays >= 1.0)
		{
			return string.Format("{0}日", (int)timeSpan.TotalDays);
		}
		if (timeSpan.TotalHours >= 1.0)
		{
			return string.Format("{0}時間", (int)timeSpan.TotalHours);
		}
		return string.Format("{0}分", Mathf.Max(1, (int)timeSpan.TotalMinutes));
	}

	[DebuggerHidden]
	public static IEnumerator UnusedAssets()
	{
		AsyncOperation op = Resources.UnloadUnusedAssets();
		if (op != null)
		{
			while (!op.isDone)
			{
				yield return null;
			}
		}
		GC.Collect();
	}

	public static void SetLayerRecursively(GameObject obj, int newLayer)
	{
		if (obj == null)
		{
			return;
		}
		obj.layer = newLayer;
		foreach (Transform child in obj.transform)
		{
			if (child != null)
			{
				SetLayerRecursively(child.gameObject, newLayer);
			}
		}
	}

	public static GameObject InstantiateInChildren(UnityEngine.Object obj, Transform parent, bool orgSize = false, bool orgPosition = false, bool changeLayer = false)
	{
		if (obj == null)
		{
			return null;
		}
		Vector3 scale = Vector3.one;
		Vector3 pos = Vector3.zero;
		GameObject srcGo = obj as GameObject;
		if (orgSize && srcGo != null)
		{
			scale = srcGo.transform.localScale;
		}
		if (orgPosition && srcGo != null)
		{
			pos = srcGo.transform.localPosition;
		}
		GameObject go = UnityEngine.Object.Instantiate(obj) as GameObject;
		if (go == null)
		{
			return null;
		}
		go.transform.SetParent(parent);
		go.transform.localPosition = pos;
		go.transform.localScale = scale;
		go.transform.localRotation = Quaternion.identity;
		go.SetActive(true);
		if (changeLayer && parent != null)
		{
			SetLayerRecursively(go, parent.gameObject.layer);
		}
		return go;
	}

	public static T InstantiateInChildren<T>(UnityEngine.Object obj, Transform parent, bool orgSize = false, bool orgPosition = false, bool changeLayer = false)
	{
		GameObject go = InstantiateInChildren(obj, parent, orgSize, orgPosition, changeLayer);
		if (go != null)
		{
			return go.GetComponent<T>();
		}
		return default(T);
	}

	public static T ArrayRand<T>(IEnumerable<T> array)
	{
		if (array == null)
		{
			return default(T);
		}
		List<T> list = new List<T>(array);
		if (list.Count == 0)
		{
			return default(T);
		}
		return list[UnityEngine.Random.Range(0, list.Count)];
	}

	public static DateTime FromUnixTime(long unixTime)
	{
		return UNIX_EPOCH.AddSeconds(unixTime).ToLocalTime();
	}

	public static long FromDateTime(DateTime dateTime)
	{
		return (long)(dateTime.ToUniversalTime() - UNIX_EPOCH).TotalSeconds;
	}

	public static bool IsTapScreen()
	{
		if (Input.touchCount > 0)
		{
			return Input.GetTouch(0).phase == TouchPhase.Began;
		}
		return Input.GetMouseButtonDown(0);
	}

	public static Dictionary<string, string> SplitMulti(string text, string outer = "&", string inner = "=")
	{
		Dictionary<string, string> dict = new Dictionary<string, string>();
		if (string.IsNullOrEmpty(text))
		{
			return dict;
		}
		string[] pairs = text.Split(new string[] { outer }, StringSplitOptions.None);
		for (int i = 0; i < pairs.Length; i++)
		{
			string[] kv = pairs[i].Split(new string[] { inner }, StringSplitOptions.None);
			if (kv.Length >= 2)
			{
				dict[kv[0]] = kv[1];
			}
		}
		return dict;
	}

	public static bool IsUrl(string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return false;
		}
		return Regex.IsMatch(input, "^s?https?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+$");
	}

	public static string MakeDateSpan(string open_date, string close_date)
	{
		return MakeDateSpan(close_date);
	}

	public static string MakeDateSpan(string close_date)
	{
		if (DateTime.TryParse(close_date, out DateTime dt))
		{
			return string.Format("{0}/{1} {2:D2}:{3:D2}まで", dt.Month, dt.Day, dt.Hour, dt.Minute);
		}
		return close_date ?? string.Empty;
	}

	public static void AddUIDepth(GameObject root, int depth)
	{
		if (root == null)
		{
			return;
		}
		UIPanel[] panels = root.GetComponentsInChildren<UIPanel>(true);
		for (int i = 0; i < panels.Length; i++)
		{
			if (panels[i] != null)
			{
				panels[i].depth += depth;
			}
		}
	}

	public static T GetInstance<T>(T instance, string path, Transform root = null)
	{
		if (instance != null)
		{
			return instance;
		}
		UnityEngine.Object prefab = Resources.Load(path);
		if (prefab == null)
		{
			return default(T);
		}
		GameObject go = InstantiateInChildren(prefab, root, false, false, false);
		return go != null ? go.GetComponent<T>() : default(T);
	}

	public static T GetInstance<T>(T instance, GameObject prefab, Transform root = null, bool orgSize = false, bool orgPosition = false, bool changeLayer = false)
	{
		if (instance != null)
		{
			return instance;
		}
		GameObject go = InstantiateInChildren(prefab, root, orgSize, orgPosition, changeLayer);
		return go != null ? go.GetComponent<T>() : default(T);
	}

	public static T GetVerticalNextObject<T>(List<T> list, T center, bool up) where T : MonoBehaviour
	{
		if (list == null || center == null)
		{
			return center;
		}
		T best = center;
		for (int i = 0; i < list.Count; i++)
		{
			T item = list[i];
			if (item != null && item != center)
			{
				float y = item.transform.localPosition.y;
				float bestY = best.transform.localPosition.y;
				if ((up && y > bestY) || (!up && y < bestY))
				{
					best = item;
				}
			}
		}
		return best;
	}

	public static void SetEnableButton(GameObject root, bool sw)
	{
		if (root == null)
		{
			return;
		}
		UIButton[] buttons = root.GetComponentsInChildren<UIButton>(true);
		for (int i = 0; i < buttons.Length; i++)
		{
			if (buttons[i] != null)
			{
				buttons[i].enabled = sw;
			}
		}
		UIToggle[] toggles = root.GetComponentsInChildren<UIToggle>(true);
		for (int i = 0; i < toggles.Length; i++)
		{
			if (toggles[i] != null)
			{
				toggles[i].enabled = sw;
			}
		}
	}

	public static T GetEnumRondom<T>() where T : struct
	{
		Type t = typeof(T);
		if (!t.IsEnum)
		{
			return default(T);
		}
		Array values = Enum.GetValues(t);
		if (values == null || values.Length == 0)
		{
			return default(T);
		}
		return (T)values.GetValue(UnityEngine.Random.Range(0, values.Length));
	}

	public static string MakeColorText(string original, Color32 color)
	{
		return string.Format("[{0:X2}{1:X2}{2:X2}{3:X2}]{4}[-]", color.r, color.g, color.b, color.a, original ?? string.Empty);
	}

	public static bool HasFlag(this Enum self, Enum flag)
	{
		long selfVal = Convert.ToInt64(self);
		long flagVal = Convert.ToInt64(flag);
		return (selfVal & flagVal) == flagVal;
	}

	public static string EncryptString(string value)
	{
		return EncryptString(value, csSTRING_IV, csSTRING_KEY);
	}

	public static string DecryptString(string value)
	{
		return DecryptString(value, csSTRING_IV, csSTRING_KEY);
	}

	public static string EncryptString(string value, string iv, string key)
	{
		if (string.IsNullOrEmpty(value))
		{
			return string.Empty;
		}
		try
		{
			using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
			{
				des.IV = Encoding.UTF8.GetBytes(iv);
				des.Key = Encoding.UTF8.GetBytes(key);
				byte[] src = Encoding.UTF8.GetBytes(value);
				using (ICryptoTransform enc = des.CreateEncryptor())
				{
					byte[] dest = enc.TransformFinalBlock(src, 0, src.Length);
					return Convert.ToBase64String(dest);
				}
			}
		}
		catch
		{
			return value;
		}
	}

	public static string DecryptString(string value, string iv, string key)
	{
		if (string.IsNullOrEmpty(value))
		{
			return string.Empty;
		}
		try
		{
			using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
			{
				des.IV = Encoding.UTF8.GetBytes(iv);
				des.Key = Encoding.UTF8.GetBytes(key);
				byte[] src = Convert.FromBase64String(value);
				using (ICryptoTransform dec = des.CreateDecryptor())
				{
					byte[] dest = dec.TransformFinalBlock(src, 0, src.Length);
					return Encoding.UTF8.GetString(dest);
				}
			}
		}
		catch
		{
			return value;
		}
	}

	public static float GetiOSVersion()
	{
		return 0f;
	}
}
