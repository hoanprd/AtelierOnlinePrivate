using System.Collections.Generic;
using UnityEngine;

public class AlterExecuteEffect : MonoBehaviour
{
	[SerializeField]
	private GameObject m_goIngredientPrefab;

	[SerializeField]
	private Transform[] m_atrIngredient;

	[SerializeField]
	private ParticleSystem[] m_asResult;

	[SerializeField]
	private ParticleSystem m_sMana;

	[SerializeField]
	private ParticleSystem m_sFree;

	[SerializeField]
	private GameObject m_goSuccessEffect;

	private List<ParticleSystem> m_vIngredientEffects;

	public void Init()
	{
	}

	public void Action(int ingredientNum, bool extra, bool greatSuccess)
	{
	}

	private ParticleSystem PlayEffect(ParticleSystem particle, int index)
	{
		return null;
	}
}
