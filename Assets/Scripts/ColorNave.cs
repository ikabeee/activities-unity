using UnityEngine;

public class ColorNave : MonoBehaviour
{
    private CambioColor cambioColor;

    void Start()
    {
        cambioColor = GetComponent<CambioColor>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cambioColor.CambiarColor(Random.ColorHSV(0f, 1f, 0.7f, 1f, 0.8f, 1f));
        }
    }
}
