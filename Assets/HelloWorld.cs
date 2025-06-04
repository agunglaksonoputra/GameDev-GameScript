using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public TextMeshProUGUI helloText;

    void Start()
    {
        helloText.text = "Hello World";
    }
}
