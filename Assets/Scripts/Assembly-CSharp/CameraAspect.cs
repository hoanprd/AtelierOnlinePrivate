using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraAspect : MonoBehaviour
{
    [SerializeField]
    private float x_aspect = 16f;

    [SerializeField]
    private float y_aspect = 9f;

    private bool iphoneX;

    private float offset;

    private void Awake()
    {
        // Kiểm tra tỷ lệ thiết bị dạng màn hình dọc đặc biệt (như iPhone X / màn hình tràn viền)
        iphoneX = (Screen.height > Screen.width && ((float)Screen.height / Screen.width) > 2.1f);
        Adjust();
    }

    private void Start()
    {
        Adjust();
        // Theo logic gốc, component CameraAspect tự hủy sau khi hoàn thành việc căn chỉnh rect
        Destroy(this);
    }

    private void Adjust()
    {
        Camera cam = GetComponent<Camera>();
        if (cam != null)
        {
            cam.rect = calcAspect(x_aspect, y_aspect);
        }
    }

    private Rect calcAspect(float width, float height)
    {
        float targetAspect = width / height;
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Rect rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        if (scaleHeight < 1.0f)
        {
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0.0f;
            rect.y = (1.0f - scaleHeight) * 0.5f;
        }
        else
        {
            float scaleWidth = 1.0f / scaleHeight;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) * 0.5f;
            rect.y = 0.0f;
        }

        return rect;
    }
}