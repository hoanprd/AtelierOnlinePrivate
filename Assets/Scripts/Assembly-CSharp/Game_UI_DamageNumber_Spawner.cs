using System.Collections.Generic;
using UnityEngine;

public class Game_UI_DamageNumber_Spawner : MonoBehaviour
{
	public int m_iReserveNum;

	public GameObject m_goPrefab;

	public GameObject m_goPrefabRecov;

	private List<Game_UI_DamageNumber> m_sExecution;

	private List<Game_UI_DamageNumber> m_sReserve;

	private void Awake()
	{
	}

	private Game_UI_DamageNumber GetObject()
	{
		return null;
	}

	private void Update()
	{
	}

	public Game_UI_DamageNumber Create(Vector3 pos, int num)
	{
		return null;
	}

	public Game_UI_DamageNumber CreateRecov(Vector3 pos, int num)
	{
		return null;
	}

	public Game_UI_DamageNumber CreateSPRecov(Vector3 pos, int num)
	{
		return null;
	}

	public void Delete(Game_UI_DamageNumber del)
	{
	}

	public void DeleteAll()
	{
	}
}
