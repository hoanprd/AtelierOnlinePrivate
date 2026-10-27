using UnityEngine;

public class DialogError : MonoBehaviour
{
    public UILabel m_sContent;

    public void Init(string content)
    {
        if (m_sContent != null)
        {
            m_sContent.text = content;
        }
    }

    public void Add(string content)
    {
        if (m_sContent != null && !string.IsNullOrEmpty(content))
        {
            m_sContent.text += "\n" + content;
        }
    }

    public void OnCopyText()
    {
        if (m_sContent != null && !string.IsNullOrEmpty(m_sContent.text))
        {
            GUIUtility.systemCopyBuffer = m_sContent.text;
            Debug.Log("[DialogError] Đã sao chép nội dung lỗi vào bộ nhớ tạm.");
        }
    }

    public void OnClose()
    {
        Destroy(gameObject);
    }

    public static DialogError Create()
    {
        // Sửa lại đúng theo đường dẫn thực tế trong thư mục Resources của bạn
        GameObject prefab = Resources.Load<GameObject>("ui/dialog/Dialog_Error");
        if (prefab != null)
        {
            GameObject go = Instantiate(prefab);
            if (go != null)
            {
                return go.GetComponent<DialogError>();
            }
        }

        Debug.LogWarning("[DialogError] Không tìm thấy Prefab Dialog_Error trong thư mục Resources!");
        return null;
    }
}