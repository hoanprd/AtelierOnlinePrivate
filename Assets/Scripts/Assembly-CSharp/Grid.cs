using UnityEngine;

[ExecuteInEditMode]
public class Grid : MonoBehaviour
{
	public enum Face
	{
		xy = 0,
		zx = 1,
		yz = 2
	}

	public float gridSize;

	public int size;

	public Color color;

	public Face face;

	public bool back;

	private float preGridSize;

	private int preSize;

	private Color preColor;

	private Face preFace;

	private bool preBack;

	private Mesh mesh;

	private void Start()
	{
	}

	private Mesh ReGrid(Mesh mesh)
	{
		return null;
	}

	private Vector3[] RotationVertices(Vector3[] vertices, Vector3 rotDirection)
	{
		return null;
	}

	private void Update()
	{
	}
}
