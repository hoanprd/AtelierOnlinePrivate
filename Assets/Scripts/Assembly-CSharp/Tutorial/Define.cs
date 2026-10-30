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
			return (int)eKind;
		}

		public static eTutorial GetTutorialKind(int iDF)
		{
			return (eTutorial)iDF;
		}

		public static string GetAssetName(eTutorial eKind)
		{
			switch (eKind)
			{
				case eTutorial.Main01_Academy001:
					return "tutorial/academy_first/Academy_First";
				case eTutorial.Main02_Field001:
					return "tutorial/field_first/Field_First";
				case eTutorial.Main03_Pickup001:
					return "tutorial/pickup_001/PickUp_001";
				case eTutorial.Main03_Pickup004:
					return "tutorial/pickup_004/PickUp_004";
				case eTutorial.Main03_Pickup002:
					return "tutorial/pickup_002/PickUp_002";
				case eTutorial.Main03_Pickup003:
					return "tutorial/pickup_003/PickUp_003";
				case eTutorial.Main04_Battle001:
					return "tutorial/battle_first/Battle_First";
				case eTutorial.Main04_Battle002:
					return "tutorial/battle_002/Battle_002";
				case eTutorial.Main04_Battle003:
					return "tutorial/battle_003/Battle_003";
				case eTutorial.Main04_Battle004:
					return "tutorial/battle_004/Battle_004";
				case eTutorial.Main04_Battle005:
					return "tutorial/battle_005/Battle_005";
				case eTutorial.Main04_Battle006:
					return "tutorial/battle_006/Battle_006";
				case eTutorial.Main04_Battle007:
					return "tutorial/battle_007/Battle_007";
				case eTutorial.Main04_Battle008:
					return "tutorial/battle_008/Battle_008";
				case eTutorial.Main04_Battle008_2:
					return "tutorial/battle_008_2/Battle_008_2";
				case eTutorial.Main04_Battle009:
					return "tutorial/battle_009/Battle_009";
				case eTutorial.Main04_Battle009_2:
					return "tutorial/battle_009_2/Battle_009_2";
				case eTutorial.Main04_Battle009_3:
					return "tutorial/battle_009_3/Battle_009_3";
				case eTutorial.Main04_Battle010:
					return "tutorial/battle_010/Battle_010";
				case eTutorial.Main04_Battle010_2:
					return "tutorial/battle_010_2/Battle_010_2";
				case eTutorial.Main04_Battle010_3:
					return "tutorial/battle_010_3/Battle_010_3";
				case eTutorial.Main04_Battle011:
					return "tutorial/battle_011/Battle_011";
				case eTutorial.Main05_Academy002:
					return "tutorial/academy_001/Academy_001";
				case eTutorial.Main06_Alter001:
					return "tutorial/alter_001/Alter_001";
				default:
					return "tutorial/academy_first/Academy_First";
			}
		}

		public static bool GetSendFlag(eTutorial eKind)
		{
			return true;
		}

		public static List<eTutorial> GetSkipList(eTutorial eRoot)
		{
			return new List<eTutorial>();
		}

		public static eTutorial GetConditionTutorial(eTutorialCondition eKind)
		{
			return eTutorial.Main01_Academy001;
		}
	}
}
