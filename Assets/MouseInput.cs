using UnityEngine;
using TMPro;

public class MouseInput : MonoBehaviour
{
    public TextMeshProUGUI mouseInfoText;

    private string clickStatus = "Belum ada klik";

    void Update()
    {
        // Deteksi klik kiri
        if (Input.GetMouseButtonDown(0))
        {
            clickStatus = "Klik Kiri";
        }

        // Deteksi klik kanan
        if (Input.GetMouseButtonDown(1))
        {
            clickStatus = "Klik Kanan";
        }

        // Dapatkan posisi kursor di layar
        Vector3 mousePos = Input.mousePosition;

        // Tampilkan ke TMP Text
        mouseInfoText.text = $"Status Klik: {clickStatus}\nPosisi Kursor: {mousePos.x:F0}, {mousePos.y:F0}";
    }
}
