using UnityEngine;

[ExecuteInEditMode]
public class CameraColorControl : MonoBehaviour
{
	public Shader m_shader;

	private Material m_material;

	public float red_R;

	public float red_G;

	public float red_B;

	public float red_Constant;

	public float green_R;

	public float green_G;

	public float green_B;

	public float green_Constant;

	public float blue_R;

	public float blue_G;

	public float blue_B;

	public float blue_Constant;

	private int _red_R;

	private int _red_G;

	private int _red_B;

	private int _green_R;

	private int _green_G;

	private int _green_B;

	private int _blue_R;

	private int _blue_G;

	private int _blue_B;

	private int _red_C;

	private int _green_C;

	private int _blue_C;

	private int _ScreenResolution;

	public bool isStop;

	private Material material
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void ExportParam()
	{
	}

	public Vector4[] GetNowParam()
	{
		return null;
	}

	public void SetParam(Vector4[] rgb)
	{
	}

	public void SetParam(CameraFilterInfo info)
	{
	}
}
