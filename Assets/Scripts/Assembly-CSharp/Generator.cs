using System.Text;
using DunGen;
using UnityEngine;

public class Generator : MonoBehaviour
{
	public RuntimeDungeon DungeonGenerator;

	private StringBuilder infoText;

	private bool showStats;

	private float keypressDelay;

	private float timeSinceLastPress;

	private bool allowHold;

	private bool isKeyDown;

	private void Start()
	{
	}

	private void OnGenerationStatusChanged(DungeonGenerator generator, GenerationStatus status)
	{
	}

	public void GenerateRandom()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}
}
