using System;
using System.Collections.Generic;
using UnityEngine;

public class Game_Chara_BA_AnimeSet : MonoBehaviour
{
	[Serializable]
	public class Base_Anime_Dictionary : AnimeKeyAndValue<int, AnimationClip[]>
	{
		public Base_Anime_Dictionary()
		{
		}

		public Base_Anime_Dictionary(int key, AnimationClip[] value)
		{
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

	private static Game_Chara_BA_AnimeSet m_inst;

	public List<Base_Anime_Dictionary> m_animArray_Weapon;

	public static Game_Chara_BA_AnimeSet GetInst()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void GetAnimeSet(Animation targetAnim, eRaceKind raceKind, EWeaponKind weaponKind, int charaID = 0)
	{
	}
}
