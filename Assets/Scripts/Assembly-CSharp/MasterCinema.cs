using System.Collections.Generic;
using UnityEngine;

public class MasterCinema : ScriptableObject
{
	public bool isLocal;

	public int df;

	public List<Method> methodList;

	public List<AnimationClip> animationList;

	public List<GameObject> effectList;

	public List<AudioClip> SEList;
}
