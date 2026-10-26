using UnityEngine;
using UnityEngine.SceneManagement;

public class TestNhanh : MonoBehaviour
{
    void Start()
    {
        // Khởi tạo các hệ thống quản lý cơ bản nếu chưa có
        Debug.Log("--- [Proof of Life] Đang ép hệ thống nhảy thẳng vào Title ---");

        // Gọi trực tiếp yêu cầu chuyển đến Menu Title thông qua System_MenuManager
        if (System_MenuManager.GetInst() != null)
        {
            System_MenuManager.GetInst().SetMenuRequest(System_MenuManager.eSystemMenuKind.Title, false, true, true);
            SceneManager.LoadScene("Title");
        }
        else
        {
            Debug.LogWarning("System_MenuManager chưa xuất hiện trong Scene! Hãy gắn nó vào một đối tượng DontDestroyOnLoad.");
        }
    }
}