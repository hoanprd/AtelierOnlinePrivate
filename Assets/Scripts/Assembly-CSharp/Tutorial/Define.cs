using System.Collections.Generic;

namespace Tutorial
{
	public class Define
	{
		private static readonly eTutorial[] sr_ConditionTutorial;

		public static readonly Dictionary<eTutorial, Info> sr_vTutorialInfo;

		public static readonly string[] sr_strCategory;

		private static Info GetInfo(eTutorial eKind)
		{
			return null;
		}

		public static int GetDF(eTutorial eKind)
		{
			return 0;
		}

		public static eTutorial GetTutorialKind(int iDF)
		{
			return eTutorial.Main01_Academy001;
		}

		public static string GetAssetName(eTutorial eKind)
		{
			return null;
		}

		public static bool GetSendFlag(eTutorial eKind)
		{
			return false;
		}

		public static List<eTutorial> GetSkipList(eTutorial eRoot)
		{
			return null;
		}

		public static eTutorial GetConditionTutorial(eTutorialCondition eKind)
		{
			return eTutorial.Main01_Academy001;
		}
	}
}
