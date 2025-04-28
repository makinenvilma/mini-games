using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance;

    public Color SelectedColor = Color.red;

    private void Awake()
    {
        Instance = this;
    }

    public void SetColor(Color newColor)
    {
        SelectedColor = newColor;
    }
}
