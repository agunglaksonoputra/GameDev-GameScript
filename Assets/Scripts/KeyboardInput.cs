using UnityEngine;
using TMPro;

public class KeyboardInput : MonoBehaviour
{
    private TextMeshProUGUI textDisplay;

    void Start()
    {
        textDisplay = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) textDisplay.text = "Tombol W ditekan";
        else if (Input.GetKey(KeyCode.A)) textDisplay.text = "Tombol A ditekan";
        else if (Input.GetKey(KeyCode.S)) textDisplay.text = "Tombol S ditekan";
        else if (Input.GetKey(KeyCode.D)) textDisplay.text = "Tombol D ditekan";
        else if (Input.GetKey(KeyCode.UpArrow)) textDisplay.text = "Tombol Up Arrow ditekan";
        else if (Input.GetKey(KeyCode.DownArrow)) textDisplay.text = "Tombol Down Arrow ditekan";
        else if (Input.GetKey(KeyCode.LeftArrow)) textDisplay.text = "Tombol Left Arrow ditekan";
        else if (Input.GetKey(KeyCode.RightArrow)) textDisplay.text = "Tombol Right Arrow ditekan";
        else if (Input.GetKey(KeyCode.Alpha1)) textDisplay.text = "Tombol 1 ditekan";
        else if (Input.GetKey(KeyCode.Alpha2)) textDisplay.text = "Tombol 2 ditekan";
        else if (Input.GetKey(KeyCode.Alpha3)) textDisplay.text = "Tombol 3 ditekan";
        else if (Input.GetKey(KeyCode.Alpha4)) textDisplay.text = "Tombol 4 ditekan";
        else if (Input.GetKey(KeyCode.Alpha5)) textDisplay.text = "Tombol 5 ditekan";
        else if (Input.GetKey(KeyCode.Alpha6)) textDisplay.text = "Tombol 6 ditekan";
        else if (Input.GetKey(KeyCode.Alpha7)) textDisplay.text = "Tombol 7 ditekan";
        else if (Input.GetKey(KeyCode.Alpha8)) textDisplay.text = "Tombol 8 ditekan";
        else if (Input.GetKey(KeyCode.Alpha9)) textDisplay.text = "Tombol 9 ditekan";
        else if (Input.GetKey(KeyCode.Alpha0)) textDisplay.text = "Tombol 0 ditekan";
        else if (Input.GetKey(KeyCode.F1)) textDisplay.text = "Tombol F1 ditekan";
        else if (Input.GetKey(KeyCode.F2)) textDisplay.text = "Tombol F2 ditekan";
        else if (Input.GetKey(KeyCode.F3)) textDisplay.text = "Tombol F3 ditekan";
        else if (Input.GetKey(KeyCode.F4)) textDisplay.text = "Tombol F4 ditekan";
        else if (Input.GetKey(KeyCode.F5)) textDisplay.text = "Tombol F5 ditekan";
        else if (Input.GetKey(KeyCode.F6)) textDisplay.text = "Tombol F6 ditekan";
        else if (Input.GetKey(KeyCode.F7)) textDisplay.text = "Tombol F7 ditekan";
        else if (Input.GetKey(KeyCode.F8)) textDisplay.text = "Tombol F8 ditekan";
        else if (Input.GetKey(KeyCode.F9)) textDisplay.text = "Tombol F9 ditekan";
        else if (Input.GetKey(KeyCode.F10)) textDisplay.text = "Tombol F10 ditekan";
        else if (Input.GetKey(KeyCode.F11)) textDisplay.text = "Tombol F11 ditekan";
        else if (Input.GetKey(KeyCode.F12)) textDisplay.text = "Tombol F12 ditekan";
        else if (Input.GetKey(KeyCode.Space)) textDisplay.text = "Tombol Space ditekan";
        else if (Input.GetKey(KeyCode.Return)) textDisplay.text = "Tombol Enter ditekan";
        else if (Input.GetKey(KeyCode.Escape)) textDisplay.text = "Tombol Escape ditekan";
        else if (Input.GetKey(KeyCode.Tab)) textDisplay.text = "Tombol Tab ditekan";
        else if (Input.GetKey(KeyCode.BackQuote)) textDisplay.text = "Tombol ` ditekan";
        else if (Input.GetKey(KeyCode.Delete)) textDisplay.text = "Tombol Delete ditekan";
        else if (Input.GetKey(KeyCode.Backspace)) textDisplay.text = "Tombol Backspace ditekan";
        else if (Input.GetKey(KeyCode.Q)) textDisplay.text = "Tombol Q ditekan";
        else if (Input.GetKey(KeyCode.E)) textDisplay.text = "Tombol E ditekan";
        else if (Input.GetKey(KeyCode.R)) textDisplay.text = "Tombol R ditekan";
        else if (Input.GetKey(KeyCode.T)) textDisplay.text = "Tombol T ditekan";
        else if (Input.GetKey(KeyCode.Y)) textDisplay.text = "Tombol Y ditekan";
        else if (Input.GetKey(KeyCode.U)) textDisplay.text = "Tombol U ditekan";
        else if (Input.GetKey(KeyCode.I)) textDisplay.text = "Tombol I ditekan";
        else if (Input.GetKey(KeyCode.O)) textDisplay.text = "Tombol O ditekan";
        else if (Input.GetKey(KeyCode.P)) textDisplay.text = "Tombol P ditekan";
        else if (Input.GetKey(KeyCode.F)) textDisplay.text = "Tombol F ditekan";
        else if (Input.GetKey(KeyCode.G)) textDisplay.text = "Tombol G ditekan";
        else if (Input.GetKey(KeyCode.H)) textDisplay.text = "Tombol H ditekan";
        else if (Input.GetKey(KeyCode.J)) textDisplay.text = "Tombol J ditekan";
        else if (Input.GetKey(KeyCode.K)) textDisplay.text = "Tombol K ditekan";
        else if (Input.GetKey(KeyCode.L)) textDisplay.text = "Tombol L ditekan";
        else if (Input.GetKey(KeyCode.Z)) textDisplay.text = "Tombol Z ditekan";
        else if (Input.GetKey(KeyCode.X)) textDisplay.text = "Tombol X ditekan";
        else if (Input.GetKey(KeyCode.C)) textDisplay.text = "Tombol C ditekan";
        else if (Input.GetKey(KeyCode.V)) textDisplay.text = "Tombol V ditekan";
        else if (Input.GetKey(KeyCode.B)) textDisplay.text = "Tombol B ditekan";
        else if (Input.GetKey(KeyCode.N)) textDisplay.text = "Tombol N ditekan";
        else if (Input.GetKey(KeyCode.M)) textDisplay.text = "Tombol M ditekan";
    }
}