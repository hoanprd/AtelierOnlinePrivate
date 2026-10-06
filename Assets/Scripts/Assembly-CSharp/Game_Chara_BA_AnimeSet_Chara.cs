using System;
using System.Collections.Generic;
using UnityEngine;

public class Game_Chara_BA_AnimeSet_Chara : MonoBehaviour
{
	[Serializable]
	public class Chara_Dictionary : CharaKeyAndValue<int, List<Chara_Anime_Dictionary>>
	{
		public Chara_Dictionary(int key, List<Chara_Anime_Dictionary> value)
			: base(0, (List<Chara_Anime_Dictionary>)null)
		{
		}
	}

	[Serializable]
	public class Chara_Anime_Dictionary : AnimeKeyAndValue<int, AnimationClip[]>
	{
		public Chara_Anime_Dictionary()
		{
		}

		public Chara_Anime_Dictionary(int key, AnimationClip[] value)
		{
		}
	}

	[Serializable]
	public class CharaKeyAndValue<TKey, TValue>
	{
		public TKey Key;

		public TValue Value;

		public CharaKeyAndValue(TKey key, TValue value)
		{
		}

		public CharaKeyAndValue(KeyValuePair<TKey, TValue> pair)
		{
		}

		public TValue GetValue(int key)
		{
			return default(TValue);
		}
	}

	[Serializable]
	public class AnimeKeyAndValue<TKey, TValue>
	{
		public TKey Key;

		public TValue Value;

		public AnimeKeyAndValue()
		{
		}

		public AnimeKeyAndValue(TKey key, TValue value)
		{
		}

		public AnimeKeyAndValue(KeyValuePair<TKey, TValue> pair)
		{
		}

		public TValue GetValue(int key)
		{
			return default(TValue);
		}
	}

	[SerializeField]
	public List<Chara_Dictionary> m_charaArray;

	private static Game_Chara_BA_AnimeSet_Chara m_inst;

	public static Game_Chara_BA_AnimeSet_Chara GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public Animation GetAnimeSet(Animation targetAnim, eRaceKind raceKind, EWeaponKind weaponKind, int charaID)
	{
		return null;
	}
}
